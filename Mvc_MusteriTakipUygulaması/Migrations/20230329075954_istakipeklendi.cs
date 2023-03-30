using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_MusteriTakipUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class istakipeklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WebSitesi",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "VergiDairesi",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Unvan",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiMail3",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiMail2",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiMail1",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiAdiSoyadi3",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiAdiSoyadi2",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiAdiSoyadi1",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "IletisimYetkilisiAdiSoyadi3",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IletisimYetkilisiAdiSoyadi2",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IletisimYetkilisiAdiSoyadi1",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");

            migrationBuilder.AddColumn<string>(
                name: "IconLogo",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marka",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "IsTakips",
                columns: table => new
                {
                    IsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YapilacakIs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KurumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsiTakipEdenPersonel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsinTeslimEdilecegiYetkili = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetBedeli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarcBedeli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplamFaturaBedeli = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsTakips", x => x.IsID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsTakips");

            migrationBuilder.DropColumn(
                name: "IconLogo",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Marka",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "WebSitesi",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VergiDairesi",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Unvan",
                table: "Clients",
                type: "Varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiMail3",
                table: "Clients",
                type: "Varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiMail2",
                table: "Clients",
                type: "Varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiMail1",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiAdiSoyadi3",
                table: "Clients",
                type: "Varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiAdiSoyadi2",
                table: "Clients",
                type: "Varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImzaYetkilisiAdiSoyadi1",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IletisimYetkilisiAdiSoyadi3",
                table: "Clients",
                type: "Varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IletisimYetkilisiAdiSoyadi2",
                table: "Clients",
                type: "Varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IletisimYetkilisiAdiSoyadi1",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "Clients",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
