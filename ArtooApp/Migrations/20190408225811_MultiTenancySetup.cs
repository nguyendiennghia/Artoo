using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtooApp.Migrations
{
    public partial class MultiTenancySetup : Migration
    {
        private const string 
            TENANCY_TABLE = "Tenancies",
            FACTORY_TABLE = "Factories",
            TENANCY_ID_COLUMN = "TenantId";
        private static int _masterTenancyId = 1;

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: TENANCY_TABLE,
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    //ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                    table.PrimaryKey($"PK_{TENANCY_TABLE}", x => x.Id));

            migrationBuilder.InsertData(
                table: TENANCY_TABLE,
                columns: new[] { "Name" },
                values: new object[] { "Master Tenant" }); // ID = 1

            migrationBuilder.AddColumn<int>(
                name: TENANCY_ID_COLUMN, 
                table: FACTORY_TABLE, 
                nullable: false, 
                defaultValue: _masterTenancyId);

            migrationBuilder.CreateIndex(
                name: $"IX_{FACTORY_TABLE}_{TENANCY_ID_COLUMN}", 
                table: FACTORY_TABLE, 
                column: TENANCY_ID_COLUMN);

            migrationBuilder.AddForeignKey(
                name: $"FK_{FACTORY_TABLE}_{TENANCY_TABLE}", 
                table: FACTORY_TABLE, 
                column: TENANCY_ID_COLUMN, 
                principalTable: TENANCY_TABLE, 
                principalColumn: "Id", 
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey($"FK_{FACTORY_TABLE}_{TENANCY_TABLE}", FACTORY_TABLE);

            migrationBuilder.DropIndex($"IX_{FACTORY_TABLE}_{TENANCY_ID_COLUMN}",
                table: FACTORY_TABLE);
            
            migrationBuilder.DropColumn(TENANCY_ID_COLUMN, FACTORY_TABLE);

            migrationBuilder.DropTable(TENANCY_TABLE);
        }
    }
}
