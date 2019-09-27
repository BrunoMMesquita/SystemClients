using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemClients.Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(200)", nullable: true),
                    MenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Profession",
                columns: table => new
                {
                    ProfessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(400)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", nullable: false),
                    CBO = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profession", x => x.ProfessionId);
                });

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    AdressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(type: "varchar(200)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(200)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(15)", nullable: false),
                    Referencia = table.Column<string>(type: "varchar(400)", nullable: true),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.AdressId);
                    table.ForeignKey(
                        name: "FK_Adress_Cliente_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Cliente",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(15)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contact_Cliente_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Cliente",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionClient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    ProfessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionClient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionClient_Cliente_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Cliente",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionClient_Profession_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Profession",
                        principalColumn: "ProfessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adress_ClientId",
                table: "Adress",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ClientId",
                table: "Contact",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_MenuId",
                table: "Menu",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionClient_ClientId",
                table: "ProfessionClient",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionClient_ProfessionId",
                table: "ProfessionClient",
                column: "ProfessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "ProfessionClient");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Profession");
        }
    }
}
