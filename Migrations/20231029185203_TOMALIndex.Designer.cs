﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Entity.Context;

#nullable disable

namespace Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231029185203_TOMALIndex")]
    partial class TOMALIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Web.Entity.Answers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IndividualId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Web.Entity.AssessorAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Page")
                        .HasColumnType("int");

                    b.Property<Guid>("QustionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AssessorAnswers");
                });

            modelBuilder.Entity("Web.Entity.AssessorBooking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssessorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IndividualId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Slot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssessorBookings");
                });

            modelBuilder.Entity("Web.Entity.AssessorPayment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssessorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Payment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AssessorPayments");
                });

            modelBuilder.Entity("Web.Entity.AssessorProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CurrentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pronoun")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("AssessorProfiles");
                });

            modelBuilder.Entity("Web.Entity.AssessorSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssessorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Availability")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SlotId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AssessorSlots");
                });

            modelBuilder.Entity("Web.Entity.Billing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("IndividualContribution")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IndividualId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("UniversityContribution")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Billings");
                });

            modelBuilder.Entity("Web.Entity.CTOPPCompositeMaster", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CompositeScore")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PercentileRank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SumOf2")
                        .HasColumnType("int");

                    b.Property<int?>("SumOf3")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CTOPPCompositeMasters");
                });

            modelBuilder.Entity("Web.Entity.CTOPPDescriptiveTerm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CompositeScoreFrom")
                        .HasColumnType("int");

                    b.Property<int?>("CompositeScoreTo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescriptiveTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ScaledScoreFrom")
                        .HasColumnType("int");

                    b.Property<int?>("ScaledScoreTo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CTOPPDescriptiveTerms");
                });

            modelBuilder.Entity("Web.Entity.CTOPPMaster", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AgeFromMonth")
                        .HasColumnType("int");

                    b.Property<int?>("AgeFromYear")
                        .HasColumnType("int");

                    b.Property<int?>("AgeToMonth")
                        .HasColumnType("int");

                    b.Property<int?>("AgeToYear")
                        .HasColumnType("int");

                    b.Property<int?>("BlendingNonwordsFrom")
                        .HasColumnType("int");

                    b.Property<int?>("BlendingNonwordsTo")
                        .HasColumnType("int");

                    b.Property<int?>("BlendingWordsFrom")
                        .HasColumnType("int");

                    b.Property<int?>("BlendingWordsTo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ElisionFrom")
                        .HasColumnType("int");

                    b.Property<int?>("ElisionTo")
                        .HasColumnType("int");

                    b.Property<int?>("MemoryForDigitsFrom")
                        .HasColumnType("int");

                    b.Property<int?>("MemoryForDigitsTo")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("NonwordRepetitionFrom")
                        .HasColumnType("int");

                    b.Property<int?>("NonwordRepetitionTo")
                        .HasColumnType("int");

                    b.Property<int?>("PercentageRankFrom")
                        .HasColumnType("int");

                    b.Property<int?>("PercentageRankTo")
                        .HasColumnType("int");

                    b.Property<int?>("PhonemeIsolationFrom")
                        .HasColumnType("int");

                    b.Property<int?>("PhonemeIsolationTo")
                        .HasColumnType("int");

                    b.Property<int?>("RapidColorNamingFrom")
                        .HasColumnType("int");

                    b.Property<int?>("RapidColorNamingTo")
                        .HasColumnType("int");

                    b.Property<int?>("RapidDigitNamingFrom")
                        .HasColumnType("int");

                    b.Property<int?>("RapidDigitNamingTo")
                        .HasColumnType("int");

                    b.Property<int?>("RapidLetterNamingFrom")
                        .HasColumnType("int");

                    b.Property<int?>("RapidLetterNamingTo")
                        .HasColumnType("int");

                    b.Property<int?>("RapidObjectNamingFrom")
                        .HasColumnType("int");

                    b.Property<int?>("RapidObjectNamingTo")
                        .HasColumnType("int");

                    b.Property<int?>("ScaledScore")
                        .HasColumnType("int");

                    b.Property<int?>("SegmentingNonwordsFrom")
                        .HasColumnType("int");

                    b.Property<int?>("SegmentingNonwordsTo")
                        .HasColumnType("int");

                    b.Property<int?>("SoundMatchingFrom")
                        .HasColumnType("int");

                    b.Property<int?>("SoundMatchingTo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CTOPPMasters");
                });

            modelBuilder.Entity("Web.Entity.Questions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Group")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Option1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Web.Entity.Slot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("MaxHour")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MaxMinute")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MinHour")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MinMinute")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("Web.Entity.TOMALIndex", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ACI")
                        .HasColumnType("int");

                    b.Property<int?>("ACI_TO")
                        .HasColumnType("int");

                    b.Property<int?>("ARI")
                        .HasColumnType("int");

                    b.Property<int?>("ARI_TO")
                        .HasColumnType("int");

                    b.Property<int?>("CMI")
                        .HasColumnType("int");

                    b.Property<int?>("CMI_TO")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("FRI")
                        .HasColumnType("int");

                    b.Property<int?>("FRI_TO")
                        .HasColumnType("int");

                    b.Property<int?>("Ind")
                        .HasColumnType("int");

                    b.Property<int?>("LI")
                        .HasColumnType("int");

                    b.Property<int?>("LI_TO")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("NMI")
                        .HasColumnType("int");

                    b.Property<int?>("NMI_TO")
                        .HasColumnType("int");

                    b.Property<int?>("Percentile")
                        .HasColumnType("int");

                    b.Property<int?>("Percentile_TO")
                        .HasColumnType("int");

                    b.Property<int?>("SRI")
                        .HasColumnType("int");

                    b.Property<int?>("SRI_TO")
                        .HasColumnType("int");

                    b.Property<int?>("VDRI")
                        .HasColumnType("int");

                    b.Property<int?>("VDRI_1")
                        .HasColumnType("int");

                    b.Property<int?>("VMI")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TOMALIndexs");
                });

            modelBuilder.Entity("Web.Entity.TOMALMaster", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AVM_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("AVM_TO")
                        .HasColumnType("int");

                    b.Property<int>("AgeFromMonth")
                        .HasColumnType("int");

                    b.Property<int>("AgeFromYear")
                        .HasColumnType("int");

                    b.Property<int>("AgeToMonth")
                        .HasColumnType("int");

                    b.Property<int>("AgeToYear")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("DB_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("DB_TO")
                        .HasColumnType("int");

                    b.Property<int?>("DF_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("DF_TO")
                        .HasColumnType("int");

                    b.Property<int?>("FM_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("FM_TO")
                        .HasColumnType("int");

                    b.Property<int?>("LB_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("LB_TO")
                        .HasColumnType("int");

                    b.Property<int?>("LF_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("LF_TO")
                        .HasColumnType("int");

                    b.Property<int?>("MFLTO")
                        .HasColumnType("int");

                    b.Property<int?>("MFL_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("MFSD_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("MFSD_TO")
                        .HasColumnType("int");

                    b.Property<int?>("MFS_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("MFS_TO")
                        .HasColumnType("int");

                    b.Property<int?>("MI_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("MI_TO")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("OR_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("OR_TO")
                        .HasColumnType("int");

                    b.Property<int?>("PR_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("PR_TO")
                        .HasColumnType("int");

                    b.Property<int?>("Scaled_Score")
                        .HasColumnType("int");

                    b.Property<int?>("VSM_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("VSM_TO")
                        .HasColumnType("int");

                    b.Property<int?>("VSR_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("VSR_TO")
                        .HasColumnType("int");

                    b.Property<int?>("WSRD")
                        .HasColumnType("int");

                    b.Property<int?>("WSR_FROM")
                        .HasColumnType("int");

                    b.Property<int?>("WSR_TO")
                        .HasColumnType("int");

                    b.Property<int?>("ile_Rank")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TOMALMasters");
                });

            modelBuilder.Entity("Web.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModifiedUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("UserType")
                        .HasColumnType("tinyint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Web.Entity.Answers", b =>
                {
                    b.HasOne("Web.Entity.Questions", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Web.Entity.AssessorProfile", b =>
                {
                    b.HasOne("Web.Entity.User", "User")
                        .WithOne("AssessorProfile")
                        .HasForeignKey("Web.Entity.AssessorProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Web.Entity.Questions", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Web.Entity.User", b =>
                {
                    b.Navigation("AssessorProfile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}