﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra02.Data.Migrations
{
    /// <inheritdoc />
    public partial class enit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLopHoc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NamNhapHoc = table.Column<int>(type: "int", nullable: false),
                    NamRaTruong = table.Column<int>(type: "int", nullable: false),
                    SoLuongSinhVien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LopHoc");
        }
    }
}
