namespace Domain.DTOs
{
    public class ConfiguracaoDto
    {
        public string NomeAplicativo { get; set; }
        public bool WebPush { get; set; }
        public bool Email { get; set; }
        public bool SMS { get; set; }
    }
}
