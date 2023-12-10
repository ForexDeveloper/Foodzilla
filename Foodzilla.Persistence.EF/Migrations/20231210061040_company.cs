using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Foodzilla.Persistence.EF.Migrations
{
    /// <inheritdoc />
    public partial class company : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiefExecutiveOfficer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AssignedOrganization = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiefExecutiveOfficer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StringNullable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerRank = table.Column<int>(type: "int", nullable: false),
                    CustomerRankNullable = table.Column<int>(type: "int", nullable: true),
                    Boolean = table.Column<bool>(type: "bit", nullable: false),
                    BooleanNullable = table.Column<bool>(type: "bit", nullable: true),
                    Int = table.Column<int>(type: "int", nullable: false),
                    IntNullable = table.Column<int>(type: "int", nullable: true),
                    Double = table.Column<double>(type: "float", nullable: false),
                    DoubleNullable = table.Column<double>(type: "float", nullable: true),
                    Decimal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DecimalNullable = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Long = table.Column<long>(type: "bigint", nullable: false),
                    LongNullable = table.Column<long>(type: "bigint", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidNullable = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateTimeNullable = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sku = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChiefMarketingOfficer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiefExecutiveOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AssignedOrganization = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiefMarketingOfficer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiefMarketingOfficer_ChiefExecutiveOfficer_ChiefExecutiveOfficerId",
                        column: x => x.ChiefExecutiveOfficerId,
                        principalTable: "ChiefExecutiveOfficer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiefProductOfficer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiefExecutiveOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AssignedOrganization = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiefProductOfficer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiefProductOfficer_ChiefExecutiveOfficer_ChiefExecutiveOfficerId",
                        column: x => x.ChiefExecutiveOfficerId,
                        principalTable: "ChiefExecutiveOfficer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiefTechnicalOfficer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiefExecutiveOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AssignedOrganization = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiefTechnicalOfficer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiefTechnicalOfficer_ChiefExecutiveOfficer_ChiefExecutiveOfficerId",
                        column: x => x.ChiefExecutiveOfficerId,
                        principalTable: "ChiefExecutiveOfficer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarketingTeamLead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiefMarketingOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingTeamLead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketingTeamLead_ChiefMarketingOfficer_ChiefMarketingOfficerId",
                        column: x => x.ChiefMarketingOfficerId,
                        principalTable: "ChiefMarketingOfficer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTeamLead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiefProductOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTeamLead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTeamLead_ChiefProductOfficer_ChiefProductOfficerId",
                        column: x => x.ChiefProductOfficerId,
                        principalTable: "ChiefProductOfficer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScrumMasterTeamLead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiefProductOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrumMasterTeamLead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScrumMasterTeamLead_ChiefProductOfficer_ChiefProductOfficerId",
                        column: x => x.ChiefProductOfficerId,
                        principalTable: "ChiefProductOfficer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QaTestingTeamLead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiefTechnicalOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QaTestingTeamLead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QaTestingTeamLead_ChiefTechnicalOfficer_ChiefTechnicalOfficerId",
                        column: x => x.ChiefTechnicalOfficerId,
                        principalTable: "ChiefTechnicalOfficer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalTeamLead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiefTechnicalOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalTeamLead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnicalTeamLead_ChiefTechnicalOfficer_ChiefTechnicalOfficerId",
                        column: x => x.ChiefTechnicalOfficerId,
                        principalTable: "ChiefTechnicalOfficer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeniorMarketing",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketingTeamLeadId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorMarketing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeniorMarketing_MarketingTeamLead_MarketingTeamLeadId",
                        column: x => x.MarketingTeamLeadId,
                        principalTable: "MarketingTeamLead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeniorProductManager",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTeamLeadId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorProductManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeniorProductManager_ProductTeamLead_ProductTeamLeadId",
                        column: x => x.ProductTeamLeadId,
                        principalTable: "ProductTeamLead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeniorScrumMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScrumMasterTeamLeadId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorScrumMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeniorScrumMaster_ScrumMasterTeamLead_ScrumMasterTeamLeadId",
                        column: x => x.ScrumMasterTeamLeadId,
                        principalTable: "ScrumMasterTeamLead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeniorQaTesting",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QaTestingTeamLeadId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorQaTesting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeniorQaTesting_QaTestingTeamLead_QaTestingTeamLeadId",
                        column: x => x.QaTestingTeamLeadId,
                        principalTable: "QaTestingTeamLead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeniorDeveloper",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnicalTeamLeadId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorDeveloper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeniorDeveloper_TechnicalTeamLead_TechnicalTeamLeadId",
                        column: x => x.TechnicalTeamLeadId,
                        principalTable: "TechnicalTeamLead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MidlevelMarketing",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeniorMarketingId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MidlevelMarketing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MidlevelMarketing_SeniorMarketing_SeniorMarketingId",
                        column: x => x.SeniorMarketingId,
                        principalTable: "SeniorMarketing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MidlevelProductManager",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeniorProductManagerId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MidlevelProductManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MidlevelProductManager_SeniorProductManager_SeniorProductManagerId",
                        column: x => x.SeniorProductManagerId,
                        principalTable: "SeniorProductManager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MidlevelDeveloper",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeniorDeveloperId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MidlevelDeveloper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MidlevelDeveloper_SeniorDeveloper_SeniorDeveloperId",
                        column: x => x.SeniorDeveloperId,
                        principalTable: "SeniorDeveloper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JuniorMarketing",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MidlevelMarketingId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuniorMarketing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JuniorMarketing_MidlevelMarketing_MidlevelMarketingId",
                        column: x => x.MidlevelMarketingId,
                        principalTable: "MidlevelMarketing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JuniorProductManager",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MidlevelProductManagerId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuniorProductManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JuniorProductManager_MidlevelProductManager_MidlevelProductManagerId",
                        column: x => x.MidlevelProductManagerId,
                        principalTable: "MidlevelProductManager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JuniorDeveloper",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MidlevelDeveloperId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuniorDeveloper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JuniorDeveloper_MidlevelDeveloper_MidlevelDeveloperId",
                        column: x => x.MidlevelDeveloperId,
                        principalTable: "MidlevelDeveloper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FresherMarketing",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuniorMarketingId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FresherMarketing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FresherMarketing_JuniorMarketing_JuniorMarketingId",
                        column: x => x.JuniorMarketingId,
                        principalTable: "JuniorMarketing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FresherProductManager",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuniorProductManagerId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FresherProductManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FresherProductManager_JuniorProductManager_JuniorProductManagerId",
                        column: x => x.JuniorProductManagerId,
                        principalTable: "JuniorProductManager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FresherDeveloper",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuniorDeveloperId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PersonalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DaysOfVacation = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: false),
                    UniqueIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EyeColor = table.Column<int>(type: "int", nullable: true),
                    Graduation = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ContractDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FresherDeveloper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FresherDeveloper_JuniorDeveloper_JuniorDeveloperId",
                        column: x => x.JuniorDeveloperId,
                        principalTable: "JuniorDeveloper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiefMarketingOfficer_ChiefExecutiveOfficerId",
                table: "ChiefMarketingOfficer",
                column: "ChiefExecutiveOfficerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiefProductOfficer_ChiefExecutiveOfficerId",
                table: "ChiefProductOfficer",
                column: "ChiefExecutiveOfficerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiefTechnicalOfficer_ChiefExecutiveOfficerId",
                table: "ChiefTechnicalOfficer",
                column: "ChiefExecutiveOfficerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FresherDeveloper_JuniorDeveloperId",
                table: "FresherDeveloper",
                column: "JuniorDeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_FresherMarketing_JuniorMarketingId",
                table: "FresherMarketing",
                column: "JuniorMarketingId");

            migrationBuilder.CreateIndex(
                name: "IX_FresherProductManager_JuniorProductManagerId",
                table: "FresherProductManager",
                column: "JuniorProductManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_JuniorDeveloper_MidlevelDeveloperId",
                table: "JuniorDeveloper",
                column: "MidlevelDeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_JuniorMarketing_MidlevelMarketingId",
                table: "JuniorMarketing",
                column: "MidlevelMarketingId");

            migrationBuilder.CreateIndex(
                name: "IX_JuniorProductManager_MidlevelProductManagerId",
                table: "JuniorProductManager",
                column: "MidlevelProductManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingTeamLead_ChiefMarketingOfficerId",
                table: "MarketingTeamLead",
                column: "ChiefMarketingOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_MidlevelDeveloper_SeniorDeveloperId",
                table: "MidlevelDeveloper",
                column: "SeniorDeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_MidlevelMarketing_SeniorMarketingId",
                table: "MidlevelMarketing",
                column: "SeniorMarketingId");

            migrationBuilder.CreateIndex(
                name: "IX_MidlevelProductManager_SeniorProductManagerId",
                table: "MidlevelProductManager",
                column: "SeniorProductManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductId",
                table: "Order",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTeamLead_ChiefProductOfficerId",
                table: "ProductTeamLead",
                column: "ChiefProductOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_QaTestingTeamLead_ChiefTechnicalOfficerId",
                table: "QaTestingTeamLead",
                column: "ChiefTechnicalOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_ScrumMasterTeamLead_ChiefProductOfficerId",
                table: "ScrumMasterTeamLead",
                column: "ChiefProductOfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_SeniorDeveloper_TechnicalTeamLeadId",
                table: "SeniorDeveloper",
                column: "TechnicalTeamLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_SeniorMarketing_MarketingTeamLeadId",
                table: "SeniorMarketing",
                column: "MarketingTeamLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_SeniorProductManager_ProductTeamLeadId",
                table: "SeniorProductManager",
                column: "ProductTeamLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_SeniorQaTesting_QaTestingTeamLeadId",
                table: "SeniorQaTesting",
                column: "QaTestingTeamLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_SeniorScrumMaster_ScrumMasterTeamLeadId",
                table: "SeniorScrumMaster",
                column: "ScrumMasterTeamLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalTeamLead_ChiefTechnicalOfficerId",
                table: "TechnicalTeamLead",
                column: "ChiefTechnicalOfficerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FresherDeveloper");

            migrationBuilder.DropTable(
                name: "FresherMarketing");

            migrationBuilder.DropTable(
                name: "FresherProductManager");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "SeniorQaTesting");

            migrationBuilder.DropTable(
                name: "SeniorScrumMaster");

            migrationBuilder.DropTable(
                name: "JuniorDeveloper");

            migrationBuilder.DropTable(
                name: "JuniorMarketing");

            migrationBuilder.DropTable(
                name: "JuniorProductManager");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "QaTestingTeamLead");

            migrationBuilder.DropTable(
                name: "ScrumMasterTeamLead");

            migrationBuilder.DropTable(
                name: "MidlevelDeveloper");

            migrationBuilder.DropTable(
                name: "MidlevelMarketing");

            migrationBuilder.DropTable(
                name: "MidlevelProductManager");

            migrationBuilder.DropTable(
                name: "SeniorDeveloper");

            migrationBuilder.DropTable(
                name: "SeniorMarketing");

            migrationBuilder.DropTable(
                name: "SeniorProductManager");

            migrationBuilder.DropTable(
                name: "TechnicalTeamLead");

            migrationBuilder.DropTable(
                name: "MarketingTeamLead");

            migrationBuilder.DropTable(
                name: "ProductTeamLead");

            migrationBuilder.DropTable(
                name: "ChiefTechnicalOfficer");

            migrationBuilder.DropTable(
                name: "ChiefMarketingOfficer");

            migrationBuilder.DropTable(
                name: "ChiefProductOfficer");

            migrationBuilder.DropTable(
                name: "ChiefExecutiveOfficer");
        }
    }
}
