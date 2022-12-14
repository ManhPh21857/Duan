using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class duan1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCV = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TenCV = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangSP",
                columns: table => new
                {
                    IdHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHang = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSP", x => x.IdHang);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "Datetime", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKhuyenMai = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    MotaKM = table.Column<string>(type: "nvarchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoai = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaMS = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TenMS = table.Column<string>(type: "nvarchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSp = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCV",
                        column: x => x.IdCV,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Soluongton = table.Column<int>(type: "int", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    GiaBan = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_HangSP_IdHang",
                        column: x => x.IdHang,
                        principalTable: "HangSP",
                        principalColumn: "IdHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_LoaiSP_IdLoai",
                        column: x => x.IdLoai,
                        principalTable: "LoaiSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_SanPham_IdSp",
                        column: x => x.IdSp,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGioHang = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NguoiNhan = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    TinhTrang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHang_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayShip = table.Column<DateTime>(type: "DateTime", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "DateTime", nullable: true),
                    TinhTrang = table.Column<int>(type: "int", nullable: true),
                    NguoiNhan = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangCT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangCT", x => new { x.Id, x.IdCTSP, x.IdGioHang });
                    table.ForeignKey(
                        name: "FK_GioHangCT_ChiTietSP_IdCTSP",
                        column: x => x.IdCTSP,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangCT_GioHang_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "GioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoiTra",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDoi = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoiTra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoiTra_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.IDCTSP, x.IdHoaDon });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietSP_IDCTSP",
                        column: x => x.IDCTSP,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_KhuyenMai_IDKM",
                        column: x => x.IDKM,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdHang",
                table: "ChiTietSP",
                column: "IdHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdLoai",
                table: "ChiTietSP",
                column: "IdLoai");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdMauSac",
                table: "ChiTietSP",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_IdSp",
                table: "ChiTietSP",
                column: "IdSp");

            migrationBuilder.CreateIndex(
                name: "IX_DoiTra_IdHoaDon",
                table: "DoiTra",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdKH",
                table: "GioHang",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdNV",
                table: "GioHang",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCT_IdCTSP",
                table: "GioHangCT",
                column: "IdCTSP");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCT_IdGioHang",
                table: "GioHangCT",
                column: "IdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKH",
                table: "HoaDon",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNV",
                table: "HoaDon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDKM",
                table: "HoaDonChiTiet",
                column: "IDKM");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoiTra");

            migrationBuilder.DropTable(
                name: "GioHangCT");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "ChiTietSP");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "HangSP");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
