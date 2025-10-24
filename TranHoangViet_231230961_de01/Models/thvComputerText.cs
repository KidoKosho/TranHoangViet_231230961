using Microsoft.EntityFrameworkCore;

namespace TranHoangViet_231230961_de01.Models
{
    public class thvComputerText : DbContext
    {
        public thvComputerText(DbContextOptions<thvComputerText> options) : base(options) { }
        public DbSet<thvComputers> thvComputers { get; set; }
    }
}
