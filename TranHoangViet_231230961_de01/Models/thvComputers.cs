using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranHoangViet_231230961_de01.Models
{
    [Table("thvComputers")]
    public class thvComputers
    {
        [Key]
        public string thvComputersId { get; set; } 

        [Required(ErrorMessage = "Tên máy tính không được để trống")]
        public string thvComputersName { get; set; }

        [Range(100, 5000, ErrorMessage = "Giá phải trong khoảng 100 đến 5000")]
        public int thvComPrice { get; set; }

        [Required(ErrorMessage = "Ảnh không được để trống")]
        [RegularExpression(@".+\.(jpg|png|gif|tiff)$", ErrorMessage = "File ảnh phải có đuôi: .jpg, .png, .gif, .tiff")]
        public string thvComImgae { get; set; }

        public bool thvComStatus { get; set; }

    }
}
