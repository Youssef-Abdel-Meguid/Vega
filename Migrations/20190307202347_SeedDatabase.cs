using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Makes (Name) values ('Make1')");
            migrationBuilder.Sql("insert into Makes (Name) values ('Make2')");
            migrationBuilder.Sql("insert into Makes (Name) values ('Make3')");

            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make1-ModelA', (Select ID from Makes where Name = 'Make1'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make1-ModelB', (Select ID from Makes where Name = 'Make1'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make1-ModelC', (Select ID from Makes where Name = 'Make1'))");

            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make2-ModelA', (Select ID from Makes where Name = 'Make2'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make2-ModelB', (Select ID from Makes where Name = 'Make2'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make2-ModelC', (Select ID from Makes where Name = 'Make2'))");

            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make3-ModelA', (Select ID from Makes where Name = 'Make3'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make3-ModelB', (Select ID from Makes where Name = 'Make3'))");
            migrationBuilder.Sql("insert into Models (Name, MakeID) values ('Make3-ModelC', (Select ID from Makes where Name = 'Make3'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Makes");
        }
    }
}
