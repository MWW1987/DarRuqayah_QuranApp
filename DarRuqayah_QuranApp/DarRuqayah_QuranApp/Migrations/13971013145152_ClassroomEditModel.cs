using Microsoft.EntityFrameworkCore.Migrations;

namespace DarRuqayah_QuranApp.Migrations
{
    public partial class ClassroomEditModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Ostads_OstadId",
                table: "ClassRooms");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "ClassRooms",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Tell",
                table: "Users",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParentTell",
                table: "Users",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassRoomId",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tell",
                table: "Ostads",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ostads",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OstadId",
                table: "ClassRooms",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ClassRooms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ClassRooms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClassRoomId",
                table: "Users",
                column: "ClassRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Ostads_OstadId",
                table: "ClassRooms",
                column: "OstadId",
                principalTable: "Ostads",
                principalColumn: "OstadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ClassRooms_ClassRoomId",
                table: "Users",
                column: "ClassRoomId",
                principalTable: "ClassRooms",
                principalColumn: "ClassRoomId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Ostads_OstadId",
                table: "ClassRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ClassRooms_ClassRoomId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClassRoomId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClassRoomId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ClassRooms");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ClassRooms",
                newName: "MyProperty");

            migrationBuilder.AlterColumn<string>(
                name: "Tell",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "ParentTell",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Tell",
                table: "Ostads",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ostads",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "OstadId",
                table: "ClassRooms",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ClassRooms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Ostads_OstadId",
                table: "ClassRooms",
                column: "OstadId",
                principalTable: "Ostads",
                principalColumn: "OstadId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
