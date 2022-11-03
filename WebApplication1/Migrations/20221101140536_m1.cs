using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sk_City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 25, nullable: true),
                    s_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sk_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sk_diet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    my_diet = table.Column<string>(nullable: true),
                    p_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sk_diet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sk_question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(maxLength: 25, nullable: false),
                    last_name = table.Column<string>(maxLength: 25, nullable: false),
                    gender = table.Column<bool>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    s_id = table.Column<int>(nullable: false),
                    c_id = table.Column<int>(nullable: false),
                    height = table.Column<int>(nullable: false),
                    weight = table.Column<int>(nullable: false),
                    question1 = table.Column<string>(maxLength: 100, nullable: true),
                    question2 = table.Column<string>(nullable: true),
                    question3 = table.Column<bool>(nullable: false),
                    problems = table.Column<string>(maxLength: 500, nullable: true),
                    regular_exercise = table.Column<bool>(nullable: false),
                    need_trainer = table.Column<bool>(nullable: false),
                    created_date = table.Column<DateTime>(nullable: false),
                    is_deleted = table.Column<bool>(nullable: false),
                    modified_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sk_question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sk_State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sk_State", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sk_City");

            migrationBuilder.DropTable(
                name: "sk_diet");

            migrationBuilder.DropTable(
                name: "sk_question");

            migrationBuilder.DropTable(
                name: "sk_State");
        }
    }
}
