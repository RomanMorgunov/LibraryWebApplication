using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryWebApplicationUI.Data.Migrations
{
    public partial class AddingBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Authors = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 2000, nullable: false),
                    Language = table.Column<string>(maxLength: 50, nullable: false),
                    Genre = table.Column<string>(maxLength: 100, nullable: false),
                    CoverImage = table.Column<byte[]>(nullable: false),
                    File = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
