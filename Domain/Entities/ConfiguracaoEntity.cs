namespace Domain.Entities
{
    public class ConfiguracaoEntity
    {
        public int? IdConfiguracao {  get; set; }
        public string NomeAplicativo { get; set; }
        public bool SetupEmail { get; set; }
        public bool SetupWeb { get; set; }
        public bool SetupSMS { get; set; }
        //public SetupEmailEntity SetupEmail { get; set; }
        //public SetupWebEntity SetupWeb { get; set; }
        //public SetupSMSEntity SetupSMS { get; set; }
    }
}
