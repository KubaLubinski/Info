using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Info.Data.Migrations
{
    public partial class tabela_firmy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firmy",
                columns: table => new
                {
                    IdFirmy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PelnaNazwa = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Miejscowosc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KodPocztowy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ulica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmy", x => x.IdFirmy);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Firmy");
        }
    }
}
