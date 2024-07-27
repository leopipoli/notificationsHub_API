namespace Domain.Entities
{
    public class SetupEmailEntity
    {
        public int IdSetupEmail { get; set; }
        public int IdConfiguracao { get; set; }
        public string NomeServidorSMTP { get; set; }
        public string PortaEnvio { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string NomeRemetente { get; set; }
        public string EmailRemetente { get; set; }
        public List<string> Templates { get; set; } // Lista de caminhos ou URLs dos arquivos 
    }
}
