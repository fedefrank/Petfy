using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petfy.Data.Migrations
{
    public partial class AddTriggerToOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //if (migrationBuilder.IsSqlServer())
            //{
                migrationBuilder.Sql(@"CREATE TRIGGER dbo.trg_owner_audit
ON dbo.Owners
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;
END");
            //}
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP TRIGGER dbo.trg_owner_audit");
        }
    }
}
