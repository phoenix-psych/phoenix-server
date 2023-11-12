using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Web.Entity.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<AssessorSlot> AssessorSlots { get; set; }
        public DbSet<AssessorPayment> AssessorPayments { get; set; }
        public DbSet<AssessorBooking> AssessorBookings { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<AssessorProfile> AssessorProfiles { get; set; }
        public DbSet<AssessorAnswer> AssessorAnswers { get; set; }
        public DbSet<CTOPPMaster> CTOPPMasters { get; set; }
        public DbSet<CTOPPCompositeMaster> CTOPPCompositeMasters { get; set; }
        public DbSet<CTOPPDescriptiveTerm> CTOPPDescriptiveTerms { get; set; }
        public DbSet<TOMALMaster> TOMALMasters { get; set; }
        public DbSet<TOMALIndex> TOMALIndexs { get; set; }
        public DbSet<WRITGeneral> WRITGenerals { get; set; }
        public DbSet<WRITSubtest> WRITSubtests { get; set; }
        public DbSet<WRITVerbal> WRITVerbals { get; set; }
        public DbSet<WRITVisual> WRITVisuals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserRelations(modelBuilder);
            UserAnswers(modelBuilder);
            AssessorProfileRelation(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void AssessorProfileRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssessorProfile>()
                .HasOne(e => e.User)
                .WithOne(e => e.AssessorProfile)
                .HasForeignKey<AssessorProfile>(e => e.UserId)
                .IsRequired();

        }

        private void UserRelations(ModelBuilder modelBuilder)
        {

        }

        private void UserAnswers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answers>()
            .HasOne<Questions>(x => x.Question)
            .WithMany(x => x.Answers)
            .HasForeignKey(x => x.QuestionId)
            .HasPrincipalKey(x => x.Id);

            //modelBuilder.Entity<Answers>()
            //.HasOne<User>(x => x.User)
            //.WithMany(x => x.Answers)
            //.HasForeignKey(x => x.IndividualId)
            //.HasPrincipalKey(x=>x.Id);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var applicationUserId = Guid.Parse("f0f9664e-2069-419b-a8e9-431e3089fbdc");
            var applicationDate = DateTime.Now;
            UpdateBaseEntity(applicationUserId, applicationDate);
            return base.SaveChangesAsync(cancellationToken);
        }


        public override int SaveChanges()
        {
            var applicationUserId = Guid.Parse("f0f9664e-2069-419b-a8e9-431e3089fbdc");
            var applicationDate = DateTime.Now;
            UpdateBaseEntity(applicationUserId, applicationDate);
            return base.SaveChanges();
        }

        private void UpdateBaseEntity(Guid applicationUserId, DateTime applicationDate)
        {
            var addedEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Added).ToList();
            addedEntities.ForEach(x =>
            {
                x.Property("Id").CurrentValue = Guid.NewGuid();
                x.Property("CreatedDate").CurrentValue = applicationDate;
                x.Property("CreatedUser").CurrentValue = applicationUserId;
                x.Property("ModifiedDate").CurrentValue = applicationDate;
                x.Property("ModifiedUser").CurrentValue = applicationUserId;
            });

            var modifiedEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified).ToList();
            modifiedEntities.ForEach(x =>
            {
                x.Property("ModifiedDate").CurrentValue = applicationDate;
                x.Property("ModifiedUser").CurrentValue = applicationUserId;
            });
        }
    }
}
