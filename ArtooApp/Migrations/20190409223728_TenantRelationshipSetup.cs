using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtooApp.Migrations
{
    public partial class TenantRelationshipSetup : Migration
    {
        private const string 
            DEPENDENCY_TABLE = "TenantDependencies",
            PARENT_COLUMN = "ParentID",
            CHILD_COLUMN = "ChildID",
            TENANCY_TABLE = "Tenancies";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: DEPENDENCY_TABLE,
                columns: table => new
                {
                    ParentID = table.Column<int>(nullable: false),
                    ChildID = table.Column<int>(nullable: false)
                },
                constraints: table => table.UniqueConstraint(
                    name: $"UC_{DEPENDENCY_TABLE}",
                    columns: c => new { c.ChildID, c.ParentID }));

            migrationBuilder.CreateIndex(
                name: $"IX_{DEPENDENCY_TABLE}",
                table: DEPENDENCY_TABLE,
                columns: new[] { PARENT_COLUMN, CHILD_COLUMN });

            migrationBuilder.AddForeignKey(
                name: $"FK_{DEPENDENCY_TABLE}_{PARENT_COLUMN}",
                table: DEPENDENCY_TABLE,
                column: PARENT_COLUMN,
                principalTable: TENANCY_TABLE,
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: $"FK_{DEPENDENCY_TABLE}_{CHILD_COLUMN}",
                table: DEPENDENCY_TABLE,
                column: CHILD_COLUMN,
                principalTable: TENANCY_TABLE,
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey($"FK_{DEPENDENCY_TABLE}_{CHILD_COLUMN}", DEPENDENCY_TABLE);

            migrationBuilder.DropForeignKey($"FK_{DEPENDENCY_TABLE}_{PARENT_COLUMN}", DEPENDENCY_TABLE);

            migrationBuilder.DropIndex($"IX_{DEPENDENCY_TABLE}", table: DEPENDENCY_TABLE);

            migrationBuilder.DropTable(DEPENDENCY_TABLE);
        }
    }
}
