﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoAn.Models.Model.NhanVien
{
    public class HoaDonBanModel
    {
        [Key] public string Id { set; get; }

        public int STT { set; get; }

        public int MaNhanVien { set; get; }

        public int? MaKhach { set; get; }

        public DateTime? NgayBan { set; get; }

        [Display(Name = "Mã Giảm Giá")] public int MaGiamGia { set; get; }


        [Display(Name = "Địa Chỉ")] public string DiaChi { set; get; }


        [Display(Name = "Số Điện Thoại")] public string SDT { set; get; }

        [Display(Name = "Họ Tên")] public string HoTen { set; get; }


        [Display(Name = "Email")] public string Email { set; get; }

        public SelectList SelectChiNhanh { set; get; }

        [Required(ErrorMessage = "Mời chọn chi nhánh gần nhất")]
        [Display(Name = "Chi Nhánh")]
        public int MaChiNhanh { set; get; }

        [Display(Name = "Tổng Tiền")] public int? TongTien { set; get; }

        public int? KhuyenMai { set; get; }

        public int? DaThanhToan { set; get; }

        public int? Status { set; get; }

        public string TenDangNhap { set; get; }

        public int? TongTienDaMua { set; get; }

        public int? TongSoHoaDon { set; get; }
    }
}