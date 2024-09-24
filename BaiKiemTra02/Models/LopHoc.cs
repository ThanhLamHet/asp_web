using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra02.Models
{
    public class LopHoc
    {
            [Key]
            public int Id { get; set; }
            [Required(ErrorMessage = "Không được để trống Tên Lớp Học!!")]
            [StringLength(20, ErrorMessage = "{0} phải có độ dài phải từ {2} đến {1} ký tự.", MinimumLength = 3)]
            [Display(Name = "Tên Lớp Học")]
            public string TenLopHoc { get; set; }


        [Required(ErrorMessage = "Năm nhập học không được để trống.")]
        public int NamNhapHoc { get; set; }

        [Required(ErrorMessage = "Năm ra trường không được để trống.")]
        public int NamRaTruong { get; set; }

        [Required(ErrorMessage = "Số lượng sinh viên không được để trống.")]
        public int SoLuongSinhVien { get; set; }
    }
}