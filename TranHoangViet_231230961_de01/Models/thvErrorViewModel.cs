namespace TranHoangViet_231230961_de01.Models
{
    public class thvErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
