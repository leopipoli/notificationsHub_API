namespace Domain.Entities
{
    public class ConfiguracaoEntity
    {
        public string NomeAplicativo { get; set; }
        public bool WebPush { get; set; }
        public bool Email { get; set; }
        public bool SMS { get; set; }
    }
}
