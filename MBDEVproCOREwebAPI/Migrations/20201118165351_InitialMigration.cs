using Microsoft.EntityFrameworkCore.Migrations;



namespace MBDEVproCOREwebAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HowTo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Line = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
                });


            migrationBuilder.InsertData(
                table: "Commands",
                    columns: new[] { "Id", "HowTo", "Line", "Platform" },
                    values: new object[] { 1, "Code an API", ".NET CORE", "WebAPI and JSON" });

            migrationBuilder.InsertData(
                table: "Commands",
                    columns: new[] { "Id", "HowTo", "Line", "Platform" },
                    values: new object[] { 2, "Angular 10", "Modules", "Components" });

            migrationBuilder.InsertData(
                table: "Commands",
                    columns: new[] { "Id", "HowTo", "Line", "Platform" },
                    values: new object[] { 3, "WCF", "C#", "SOAP Request" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commands");
        }




    }
}
