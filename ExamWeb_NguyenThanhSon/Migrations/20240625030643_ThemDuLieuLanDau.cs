using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_NguyenThanhSon.Migrations
{
    public partial class ThemDuLieuLanDau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaNhacs",
                columns: new[] { "Id", "NGheSi", "GiaBan", "SoLuong", "TuaCD","TrongNuoc" },
                values: new object[,]
                {
                    { 1, "A", 12000.0, 10, "CD Nỗi buồn gác trọ" },
                    { 2, "A", 12000.0, 15, "CD Bài ca tình đêm" },
                    { 3, "A", 12000.0, 10, "CD BABYMONSTER" },
                    { 4, "A", 12000.0, 15, "CD Chuyện chúng mình" },
                    { 5, "A", 12000.0, 10, "CD Today US-UK Hit" },
                    { 6, "A", 12000.0, 15, "CD Đoá hồng nhạc việt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
