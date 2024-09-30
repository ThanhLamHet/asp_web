using System.ComponentModel.DataAnnotations;

namespace Baitap07.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Khong duoc de trong ten The Loai")]
        [Display(Name ="The Loai")]


        public string Name { get; set; }
        [Required(ErrorMessage ="Khong dung dinh dang ngay")]

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
