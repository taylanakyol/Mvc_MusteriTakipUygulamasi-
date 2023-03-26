using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvc_MusteriTakipUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class musteriler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unvan = table.Column<string>(type: "Varchar(20)", nullable: false),
                    VergiNo = table.Column<string>(type: "Varchar(50)", nullable: false),
                    VergiDairesi = table.Column<string>(type: "Varchar(50)", nullable: false),
                    TelNo = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Adres = table.Column<string>(type: "Varchar(50)", nullable: false),
                    WebSitesi = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "Varchar(50)", nullable: false),
                    ImzaYetkilisiAdiSoyadi1 = table.Column<string>(type: "Varchar(50)", nullable: false),
                    ImzaYetkilisiAdiSoyadi2 = table.Column<string>(type: "Varchar(50)", nullable: true),
                    ImzaYetkilisiAdiSoyadi3 = table.Column<string>(type: "Varchar(50)", nullable: true),
                    ImzaYetkilisiMail1 = table.Column<string>(type: "Varchar(50)", nullable: false),
                    ImzaYetkilisiMail2 = table.Column<string>(type: "Varchar(50)", nullable: true),
                    ImzaYetkilisiMail3 = table.Column<string>(type: "Varchar(50)", nullable: true),
                    IletisimYetkilisiAdiSoyadi1 = table.Column<string>(type: "Varchar(50)", nullable: false),
                    IletisimYetkilisiAdiSoyadi2 = table.Column<string>(type: "Varchar(50)", nullable: true),
                    IletisimYetkilisiAdiSoyadi3 = table.Column<string>(type: "Varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.MusteriID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
