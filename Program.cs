using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Extensions;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;
using Web.Entity.Context;
using Web.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateLifetime = true,
            ValidateAudience = true,
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("RPolicy", p =>
    {
        p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DBConnStr"));
});



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    context.Database.Migrate();
    
    {
        context.Database.EnsureCreated();

        // admin user
        var admin = context.Users.FirstOrDefault(b => b.Username == "admin");
        if (admin == null)
        {
            context.Users.Add(new Web.Entity.User {
                FirstName = "admin",
                Username = "admin",
                Password = "aims@123",
                UserType = 0,

                Dob = new DateTime(),
                Email = "",
                LastName = "",
                Name = "",

            });

            await context.SaveChangesAsync();
        }

        SeedEmployeesData(context);
        await context.SaveChangesAsync();
    }
}

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();
app.UseCors("RPolicy");

// global error handler
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();


static void SeedEmployeesData(AppDbContext context)
{
    string folder = Path.Combine(Directory.GetCurrentDirectory(), "Seed");
    if (!string.IsNullOrWhiteSpace(folder))
    {
        string filter = "*.sql";
        string[] files = Directory.GetFiles(folder, filter);
        foreach (var file in files)
        {
            string command = string.Empty;
            command = File.ReadAllText(file);

            if (String.IsNullOrWhiteSpace(command))
                continue;

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Database.ExecuteSqlRaw(command);
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }

        }
    }
}