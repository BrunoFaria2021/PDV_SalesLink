using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesLinkPRO.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CrudCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ConsultorId",
                table: "Cliente",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ConsultorId",
                table: "Cliente",
                column: "ConsultorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Consultor_ConsultorId",
                table: "Cliente",
                column: "ConsultorId",
                principalTable: "Consultor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Consultor_ConsultorId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_ConsultorId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ConsultorId",
                table: "Cliente");
        }
    }
}
