using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class Clienttests1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientGOARTDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ElRawScore = table.Column<int>(type: "int", nullable: true),
                    BwRawScore = table.Column<int>(type: "int", nullable: true),
                    PlRawScore = table.Column<int>(type: "int", nullable: true),
                    MdRawScore = table.Column<int>(type: "int", nullable: true),
                    NrRawScore = table.Column<int>(type: "int", nullable: true),
                    RdRawScore = table.Column<int>(type: "int", nullable: true),
                    RlRawScore = table.Column<int>(type: "int", nullable: true),
                    BnRawScore = table.Column<int>(type: "int", nullable: true),
                    SnRawScore = table.Column<int>(type: "int", nullable: true),
                    CI = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientGOARTDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTOMALDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    selected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mfsVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    mfsVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    mfsVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    fmNonVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    fmNonVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    fmNonVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    wsrVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    wsrVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    wsrVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    avmNonVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    avmNonVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    avmNonVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    orVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    orVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    orVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    vsmNonVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    vsmNonVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    vsmNonVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    prVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    prVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    prVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    mflNonVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    mflNonVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    mflNonVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    ofVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    ofVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    ofVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    vsrNonVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    vsrNonVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    vsrNonVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    lfVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    lfVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    lfVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    mlNonVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    mlNonVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    mlNonVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    dbVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    dbVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    dbVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    lbVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    lbVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    lbVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    mfsdVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    mfsdVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    mfsdVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    wsrdVerbalRawScore = table.Column<int>(type: "int", nullable: true),
                    wsrdVerbalScaleScore = table.Column<int>(type: "int", nullable: true),
                    wsrdVerbalPercentageRank = table.Column<int>(type: "int", nullable: true),
                    mfsVmi = table.Column<int>(type: "int", nullable: true),
                    mfsCmi = table.Column<int>(type: "int", nullable: true),
                    mfsAri = table.Column<int>(type: "int", nullable: true),
                    fmNmi = table.Column<int>(type: "int", nullable: true),
                    fmCmi = table.Column<int>(type: "int", nullable: true),
                    fmFri = table.Column<int>(type: "int", nullable: true),
                    wsrVmi = table.Column<int>(type: "int", nullable: true),
                    wsrCmi = table.Column<int>(type: "int", nullable: true),
                    wsrLi = table.Column<int>(type: "int", nullable: true),
                    avmNmi = table.Column<int>(type: "int", nullable: true),
                    avmCmi = table.Column<int>(type: "int", nullable: true),
                    avmFri = table.Column<int>(type: "int", nullable: true),
                    orVmi = table.Column<int>(type: "int", nullable: true),
                    orCmi = table.Column<int>(type: "int", nullable: true),
                    orLi = table.Column<int>(type: "int", nullable: true),
                    vsmNmi = table.Column<int>(type: "int", nullable: true),
                    vsmCmi = table.Column<int>(type: "int", nullable: true),
                    vsmSri = table.Column<int>(type: "int", nullable: true),
                    prVmi = table.Column<int>(type: "int", nullable: true),
                    prCmi = table.Column<int>(type: "int", nullable: true),
                    prAri = table.Column<int>(type: "int", nullable: true),
                    prLi = table.Column<int>(type: "int", nullable: true),
                    mflNmi = table.Column<int>(type: "int", nullable: true),
                    mflCmi = table.Column<int>(type: "int", nullable: true),
                    mflFri = table.Column<int>(type: "int", nullable: true),
                    dfAci = table.Column<int>(type: "int", nullable: true),
                    dfSri = table.Column<int>(type: "int", nullable: true),
                    vsrLi = table.Column<int>(type: "int", nullable: true),
                    lfAci = table.Column<int>(type: "int", nullable: true),
                    lfSri = table.Column<int>(type: "int", nullable: true),
                    miAci = table.Column<int>(type: "int", nullable: true),
                    miSri = table.Column<int>(type: "int", nullable: true),
                    dbAci = table.Column<int>(type: "int", nullable: true),
                    lbAci = table.Column<int>(type: "int", nullable: true),
                    mfsdVdri = table.Column<int>(type: "int", nullable: true),
                    wsrdVdri = table.Column<int>(type: "int", nullable: true),
                    smVmi = table.Column<int>(type: "int", nullable: true),
                    smNmi = table.Column<int>(type: "int", nullable: true),
                    smCmi = table.Column<int>(type: "int", nullable: true),
                    smVdri = table.Column<int>(type: "int", nullable: true),
                    smAci = table.Column<int>(type: "int", nullable: true),
                    smSri = table.Column<int>(type: "int", nullable: true),
                    smFri = table.Column<int>(type: "int", nullable: true),
                    smAri = table.Column<int>(type: "int", nullable: true),
                    smli = table.Column<int>(type: "int", nullable: true),
                    indVmi = table.Column<int>(type: "int", nullable: true),
                    indNmi = table.Column<int>(type: "int", nullable: true),
                    indCmi = table.Column<int>(type: "int", nullable: true),
                    indVdri = table.Column<int>(type: "int", nullable: true),
                    indAci = table.Column<int>(type: "int", nullable: true),
                    indSri = table.Column<int>(type: "int", nullable: true),
                    indFri = table.Column<int>(type: "int", nullable: true),
                    indAri = table.Column<int>(type: "int", nullable: true),
                    indli = table.Column<int>(type: "int", nullable: true),
                    perVmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perNmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perCmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perVdri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perAci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perSri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perFri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perAri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTOMALDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTOWREDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    selected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sweRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sweAgeEqui = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sweGradeEqui = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sweRank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sweScale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sweDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pdeRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pdeAgeEqui = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pdeGradeEqui = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pdeRank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pdeScale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pdeDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pdeSum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descriptiveTerm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTOWREDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientWRATDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    selected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wrRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wrStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wrCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wrPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wrGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mcRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mcStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mcCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mcPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mcGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rcRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rcStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rcCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rcPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rcGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientWRATDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientWRITDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    selected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vaRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vaStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vaPercentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vcRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vcStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vcPercentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vaSum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maPercentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diRawScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diStandardScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diPercentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dSum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vbSumScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vbIQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vbPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vbCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viSumScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viIQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    viCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iqSumScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iqIQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iqPer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iqCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientWRITDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientGOARTDetails");

            migrationBuilder.DropTable(
                name: "ClientTOMALDetails");

            migrationBuilder.DropTable(
                name: "ClientTOWREDetails");

            migrationBuilder.DropTable(
                name: "ClientWRATDetails");

            migrationBuilder.DropTable(
                name: "ClientWRITDetails");
        }
    }
}
