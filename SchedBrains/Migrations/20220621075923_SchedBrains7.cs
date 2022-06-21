using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedBrains.Migrations
{
    public partial class SchedBrains7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contato",
                table: "TBEvento");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TBEvento");

            migrationBuilder.AlterColumn<int>(
                name: "Periodicidade",
                table: "TBEvento",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "TBEvento",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Contatos",
                table: "TBEvento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Situacao",
                table: "TBEvento",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contatos",
                table: "TBEvento");

            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "TBEvento");

            migrationBuilder.AlterColumn<string>(
                name: "Periodicidade",
                table: "TBEvento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "TBEvento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contato",
                table: "TBEvento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "TBEvento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
