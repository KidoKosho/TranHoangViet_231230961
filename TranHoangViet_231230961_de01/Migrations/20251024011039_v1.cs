using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranHoangViet_231230961_de01.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "thvComputers",
                columns: table => new
                {
                    thvComputersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    thvComputersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thvComPrice = table.Column<int>(type: "int", nullable: false),
                    thvComImgae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thvComStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thvComputers", x => x.thvComputersId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "thvComputers");
        }
    }
}
