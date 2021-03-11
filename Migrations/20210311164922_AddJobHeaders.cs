using Microsoft.EntityFrameworkCore.Migrations;

namespace DHSCRM.Migrations
{
    public partial class AddJobHeaders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobHeaderId",
                table: "Jobs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobHeader",
                columns: table => new
                {
                    JobHeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobHeader", x => x.JobHeaderId);
                    table.ForeignKey(
                        name: "FK_JobHeader_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobHeaderId",
                table: "Jobs",
                column: "JobHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_JobHeader_CustomerId",
                table: "JobHeader",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobHeader_JobHeaderId",
                table: "Jobs",
                column: "JobHeaderId",
                principalTable: "JobHeader",
                principalColumn: "JobHeaderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobHeader_JobHeaderId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "JobHeader");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_JobHeaderId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobHeaderId",
                table: "Jobs");
        }
    }
}
