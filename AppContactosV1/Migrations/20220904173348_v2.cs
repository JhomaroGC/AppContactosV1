using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppContactosV1._0.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "correo",
                table: "Contactos",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Contactos",
                newName: "Celular");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contactos",
                newName: "correo");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Contactos",
                newName: "Direccion");
        }
    }
}
