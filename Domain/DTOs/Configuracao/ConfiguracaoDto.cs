namespace Domain.DTOs.Configuracao
{
    public class ConfiguracaoDto
    {
        public int? IdConfiguracao { get; set; }
        public string NomeAplicativo { get; set; }
        public bool SetupEmail { get; set; }
        public bool SetupWeb { get; set; }
        public bool SetupSMS { get; set; }
    }
}
