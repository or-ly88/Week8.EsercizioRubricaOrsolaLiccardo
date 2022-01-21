﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week8.RepositoryEntityFramework.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatto",
                columns: table => new
                {
                    ContattoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatto", x => x.ContattoID);
                });

            migrationBuilder.CreateTable(
                name: "Indirizzo",
                columns: table => new
                {
                    IndirizzoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipologia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Via = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Città = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CAP = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nazione = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContattoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indirizzo", x => x.IndirizzoID);
                    table.ForeignKey(
                        name: "FK_Indirizzo_Contatto_ContattoID",
                        column: x => x.ContattoID,
                        principalTable: "Contatto",
                        principalColumn: "ContattoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Indirizzo_ContattoID",
                table: "Indirizzo",
                column: "ContattoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indirizzo");

            migrationBuilder.DropTable(
                name: "Contatto");
        }
    }
}
