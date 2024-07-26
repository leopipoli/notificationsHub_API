namespace Data.Scripts
{
    public static class SetupWebScripts
    {
        const string _selectByIdSetupWeb = @"SELECT IdSetupWeb, IdConfiguracao, NomeDoSite, EnderecoDoSite, ImagemDoIcone, TextoMensagemPermissao, TextoBotaoPermitir,
                                                    TextoBotaoNegar, TituloNotificacaoBoasVindas, TextoMensagemBoasVindas, HabilitarLinkDestino, EnderecoLinkDestino 
                                             FROM SetupWeb
                                             WHERE IdSetupWeb = @id";

        const string _insertSetupWeb = @"INSERT INTO SetupWeb (IdSetupWeb, IdConfiguracao, NomeDoSite, EnderecoDoSite, ImagemDoIcone, TextoMensagemPermissao,
                                                               TextoBotaoPermitir, TextoBotaoNegar, TituloNotificacaoBoasVindas, TextoMensagemBoasVindas, HabilitarLinkDestino, EnderecoLinkDestino) 
                                         VALUES (@IdSetupWeb, @IdConfiguracao, @NomeDoSite, @EnderecoDoSite, @ImagemDoIcone, @TextoMensagemPermissao,
                                                 @TextoBotaoPermitir, @TextoBotaoNegar, @TituloNotificacaoBoasVindas, @TextoMensagemBoasVindas,
                                                 @HabilitarLinkDestino, @EnderecoLinkDestino)";
        public static string SelectByIdSetupWeb() { return _selectByIdSetupWeb; }
        public static string InsertSetupWeb() { return _insertSetupWeb; }
    }
}
