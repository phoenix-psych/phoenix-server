﻿using AIMSService.Entity;
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
        public DbSet<Client> Clients { get; set; }
        public DbSet<ARTMaster> ARTMasters { get; set; }
        public DbSet<WRAT_Blue> WRAT_Blues { get; set; }
        public DbSet<WRAT_Green> WRAT_Greens { get; set; }
        public DbSet<WRAT_CI_Blue> WRAT_CI_Blues { get; set; }
        public DbSet<WRAT_CI_Green> WRAT_CI_Greens { get; set; }
        public DbSet<TowreAgeEqui> TowreAgeEquis { get; set; }
        public DbSet<TowreGradeEqui> TowreGradeEquis { get; set; }
        public DbSet<TowrePde> TowrePdes { get; set; }
        public DbSet<TowreRank> TowreRanks { get; set; }
        public DbSet<TowreSwe> TowreSwes { get; set; }
        public DbSet<TowreWR> TowreWRs { get; set; }

        public DbSet<GoartFormAAccuracy> GoartFormAAccuracys { get; set; }
        public DbSet<GoartFormAAgeEqui> GoartFormAAgeEquis { get; set; }
        public DbSet<GoartFormAComprehension> GoartFormAComprehensions { get; set; }
        public DbSet<GoartFormAFluency> GoartFormAFluencys { get; set; }
        public DbSet<GoartFormAGradeEqui> GoartFormAGradeEquis { get; set; }
        public DbSet<GoartFormARate> GoartFormARates { get; set; }
        public DbSet<GoartFormBAccuracy> GoartFormBAccuracys { get; set; }
        public DbSet<GoartFormBAgeEqui> GoartFormBAgeEquis { get; set; }
        public DbSet<GoartFormBComprehension> GoartFormBComprehensions { get; set; }
        public DbSet<GoartFormBFluency> GoartFormBFluencys { get; set; }
        public DbSet<GoartFormBGradeEqui> GoartFormBGradeEquis { get; set; }
        public DbSet<GoartFormBRate> GoartFormBRates { get; set; }
        public DbSet<GoartRank> GoartRanks { get; set; }
        public DbSet<ClientARTDetail> ClientARTDetails { get; set; }
        public DbSet<ClientCTOPPDetail> ClientCTOPPDetails { get; set; }
        public DbSet<ClientGOARTDetail> ClientGOARTDetails { get; set; }
        public DbSet<ClientTOMALDetail> ClientTOMALDetails { get; set; }
        public DbSet<ClientTOWREDetail> ClientTOWREDetails { get; set; }
        public DbSet<ClientWRATDetail> ClientWRATDetails { get; set; }
        public DbSet<ClientWRITDetail> ClientWRITDetails { get; set; }

        public DbSet<StudentPage1> StudentPage1 { get; set; }
        public DbSet<StudentPage2> StudentPage2 { get; set; }
        public DbSet<StudentPage3> StudentPage3 { get; set; }
        public DbSet<StudentPage4> StudentPage4 { get; set; }
        public DbSet<StudentDocument> StudentDocuments { get; set; }



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
