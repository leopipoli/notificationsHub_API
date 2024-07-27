namespace Domain.DTOs.SetupSMS
{
    public class SetupSMSDto
    {
        public int? IdSetupSMS { get; set; }
        public int IdConfiguracao { get; set; }
        public string ProvedorSMS { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
