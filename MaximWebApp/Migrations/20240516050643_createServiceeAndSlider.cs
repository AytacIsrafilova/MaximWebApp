using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaximWebApp.Migrations
{
    /// <inheritdoc />
    public partial class createServiceeAndSlider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servicees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicees_Servicees_ServiceeId",
                        column: x => x.ServiceeId,
                        principalTable: "Servicees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackGroundImg = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicees_ServiceeId",
                table: "Servicees",
                column: "ServiceeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servicees");

            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
