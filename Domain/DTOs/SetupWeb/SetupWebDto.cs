namespace Domain.DTOs.SetupWeb
{
    public class SetupWebDto
    {
        public int? IdSetupWeb { get; set; }
        public int IdConfiguracao { get; set; }
        public string NomeDoSite { get; set; }
        public string EnderecoDoSite { get; set; }
        public string ImagemDoIcone { get; set; }
        public string TextoMensagemPermissao { get; set; }
        public string TextoBotaoPermitir { get; set; }
        public string TextoBotaoNegar { get; set; }
        public string TituloNotificacaoBoasVindas { get; set; }
        public string TextoMensagemBoasVindas { get; set; }
        public bool HabilitarLinkDestino { get; set; }
        public string EnderecoLinkDestino { get; set; }
    }
}
