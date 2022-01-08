using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewService.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "StarReview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "StarReview",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StarReview_DoctorId",
                table: "StarReview",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_StarReview_UserId",
                table: "StarReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DoctorId",
                table: "Comments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Doctor_DoctorId",
                table: "Comments",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_User_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarReview_Doctor_DoctorId",
                table: "StarReview",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StarReview_User_UserId",
                table: "StarReview",
                column: "UserId",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Doctor_DoctorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_User_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_StarReview_Doctor_DoctorId",
                table: "StarReview");

            migrationBuilder.DropForeignKey(
                name: "FK_StarReview_User_UserId",
                table: "StarReview");

            migrationBuilder.DropIndex(
                name: "IX_StarReview_DoctorId",
                table: "StarReview");

            migrationBuilder.DropIndex(
                name: "IX_StarReview_UserId",
                table: "StarReview");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DoctorId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "StarReview");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "StarReview");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comments");
        }
    }
}
