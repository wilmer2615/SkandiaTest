using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeTransactionStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeTransactionStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Franchise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Franchise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingsAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionsCreditCardTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionsCreditCardTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NaturalPersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DocumentTipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    MunicipalityId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NaturalPersons_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaturalPersons_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaturalPersons_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavingsAccountTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SavingsAccountId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    ExchangeTransactionStateId = table.Column<int>(type: "int", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsAccountTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavingsAccountTransactions_ExchangeTransactionStates_ExchangeTransactionStateId",
                        column: x => x.ExchangeTransactionStateId,
                        principalTable: "ExchangeTransactionStates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SavingsAccountTransactions_SavingsAccounts_SavingsAccountId",
                        column: x => x.SavingsAccountId,
                        principalTable: "SavingsAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavingsAccountTransactions_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FranchiseId = table.Column<int>(type: "int", nullable: false),
                    ApprovedLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditCards_Franchise_FranchiseId",
                        column: x => x.FranchiseId,
                        principalTable: "Franchise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditCards_NaturalPersons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "NaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LegalPersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalRepresentativeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegalPersons_NaturalPersons_LegalRepresentativeId",
                        column: x => x.LegalRepresentativeId,
                        principalTable: "NaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavingsAccountHolders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SavingsAccountId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsAccountHolders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavingsAccountHolders_NaturalPersons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "NaturalPersons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SavingsAccountHolders_SavingsAccounts_SavingsAccountId",
                        column: x => x.SavingsAccountId,
                        principalTable: "SavingsAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditCardTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditCardId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionCreditCardTypeId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditCardTransactions_CreditCards_CreditCardId",
                        column: x => x.CreditCardId,
                        principalTable: "CreditCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditCardTransactions_TransactionsCreditCardTypes_TransactionCreditCardTypeId",
                        column: x => x.TransactionCreditCardTypeId,
                        principalTable: "TransactionsCreditCardTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PersonType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonRoles_LegalPersons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "LegalPersons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonRoles_NaturalPersons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "NaturalPersons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShareholdingCompositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ShareholderId = table.Column<int>(type: "int", nullable: false),
                    percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShareholderLegalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShareholdingCompositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShareholdingCompositions_LegalPersons_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "LegalPersons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShareholdingCompositions_LegalPersons_ShareholderLegalId",
                        column: x => x.ShareholderLegalId,
                        principalTable: "LegalPersons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShareholdingCompositions_NaturalPersons_ShareholderId",
                        column: x => x.ShareholderId,
                        principalTable: "NaturalPersons",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Antioquia" },
                    { 2, "Cundinamarca" }
                });

            migrationBuilder.InsertData(
                table: "ExchangeTransactionStates",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Validacion" },
                    { 2, "Aprobado" },
                    { 3, "Rechazado" }
                });

            migrationBuilder.InsertData(
                table: "Franchise",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Visa" },
                    { 2, "MasterCard" },
                    { 3, "AmericanExpress" },
                    { 4, "Diners" }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Medellín " },
                    { 2, "Envigado" },
                    { 3, "Bogotá  " },
                    { 4, "Soacha" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Colombiana" },
                    { 2, "Americana" }
                });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "DepositoEfectivo" },
                    { 2, "DepositoCheque" },
                    { 3, "Retiro" }
                });

            migrationBuilder.InsertData(
                table: "TransactionsCreditCardTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "ComprasNacionales" },
                    { 2, "CuotaManejo" },
                    { 3, "PagoTarjeta" },
                    { 4, "RetirosAvance" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_FranchiseId",
                table: "CreditCards",
                column: "FranchiseId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_PersonId",
                table: "CreditCards",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCardTransactions_CreditCardId",
                table: "CreditCardTransactions",
                column: "CreditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCardTransactions_TransactionCreditCardTypeId",
                table: "CreditCardTransactions",
                column: "TransactionCreditCardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalPersons_LegalRepresentativeId",
                table: "LegalPersons",
                column: "LegalRepresentativeId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalPersons_DepartmentId",
                table: "NaturalPersons",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalPersons_MunicipalityId",
                table: "NaturalPersons",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalPersons_NationalityId",
                table: "NaturalPersons",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRoles_PersonId",
                table: "PersonRoles",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRoles_RoleId",
                table: "PersonRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingsAccountHolders_PersonId",
                table: "SavingsAccountHolders",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingsAccountHolders_SavingsAccountId",
                table: "SavingsAccountHolders",
                column: "SavingsAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingsAccountTransactions_ExchangeTransactionStateId",
                table: "SavingsAccountTransactions",
                column: "ExchangeTransactionStateId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingsAccountTransactions_SavingsAccountId",
                table: "SavingsAccountTransactions",
                column: "SavingsAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingsAccountTransactions_TransactionTypeId",
                table: "SavingsAccountTransactions",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShareholdingCompositions_CompanyId",
                table: "ShareholdingCompositions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShareholdingCompositions_ShareholderId",
                table: "ShareholdingCompositions",
                column: "ShareholderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShareholdingCompositions_ShareholderLegalId",
                table: "ShareholdingCompositions",
                column: "ShareholderLegalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCardTransactions");

            migrationBuilder.DropTable(
                name: "PersonRoles");

            migrationBuilder.DropTable(
                name: "SavingsAccountHolders");

            migrationBuilder.DropTable(
                name: "SavingsAccountTransactions");

            migrationBuilder.DropTable(
                name: "ShareholdingCompositions");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "TransactionsCreditCardTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ExchangeTransactionStates");

            migrationBuilder.DropTable(
                name: "SavingsAccounts");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropTable(
                name: "LegalPersons");

            migrationBuilder.DropTable(
                name: "Franchise");

            migrationBuilder.DropTable(
                name: "NaturalPersons");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Nationalities");
        }
    }
}
