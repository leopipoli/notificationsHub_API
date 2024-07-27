namespace Data.Scripts
{
    public static class SetupWebScripts
    {
        const string _selectByIdSetupWeb = @"SELECT IdSetupWeb, IdConfiguracao, NomeDoSite, EnderecoDoSite, ImagemDoIcone, TextoMensagemPermissao, TextoBotaoPermitir,
                                                    TextoBotaoNegar, TituloNotificacaoBoasVindas, TextoMensagemBoasVindas, HabilitarLinkDestino, EnderecoLinkDestino 
                                             FROM SetupWeb
                                             WHERE IdConfiguracao = @idConfiguracao";

        const string _insertSetupWeb = @"INSERT INTO SetupWeb (IdConfiguracao, NomeDoSite, EnderecoDoSite, ImagemDoIcone, TextoMensagemPermissao,
                                                               TextoBotaoPermitir, TextoBotaoNegar, TituloNotificacaoBoasVindas, TextoMensagemBoasVindas, HabilitarLinkDestino, EnderecoLinkDestino) 
                                         VALUES (@IdConfiguracao, @NomeDoSite, @EnderecoDoSite, @ImagemDoIcone, @TextoMensagemPermissao,
                                                 @TextoBotaoPermitir, @TextoBotaoNegar, @TituloNotificacaoBoasVindas, @TextoMensagemBoasVindas,
                                                 @HabilitarLinkDestino, @EnderecoLinkDestino);
                                         SELECT CAST(SCOPE_IDENTITY() as int);";

        public static string SelectByIdSetupWeb() { return _selectByIdSetupWeb; }
        public static string InsertSetupWeb() { return _insertSetupWeb; }
    }
}
