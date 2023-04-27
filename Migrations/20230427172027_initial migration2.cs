using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PendaftaranPasien.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dokter",
                table: "Pasiens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JenisPasien",
                table: "Pasiens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetodePembayaran",
                table: "Pasiens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "poli",
                table: "Pasiens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dokter",
                table: "Pasiens");

            migrationBuilder.DropColumn(
                name: "JenisPasien",
                table: "Pasiens");

            migrationBuilder.DropColumn(
                name: "MetodePembayaran",
                table: "Pasiens");

            migrationBuilder.DropColumn(
                name: "poli",
                table: "Pasiens");
        }
    }
}
