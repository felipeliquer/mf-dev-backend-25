namespace mf_dev_backend_25.Models
{
    public class ErrorViewModel
    {
        private string requestId;

        public string? RequestId { get => requestId; set => requestId = value; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
