using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranHoangViet_231230961_de01.Models
{
    [Table("thvComputers")]
    public class thvComputers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string thvComputersId { get; set; }
        public string thvComputersName { get; set; }
        public int thvComPrice { get; set; }
        public string thvComImgae { get; set; }
        public bool thvComStatus { get; set; }
        
    }
}
