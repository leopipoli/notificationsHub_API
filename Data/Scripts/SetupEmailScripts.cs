namespace Data.Scripts
{
    public static class SetupEmailScripts
    {
        const string _selectByIdSetupEmail = @"SELECT 
	                                               IdSetupEmail, IdConfiguracao, NomeServidorSMTP, PortaEnvio, Login, Senha, NomeRemetente, EmailRemetente 
                                               FROM 
	                                               SetupEmail";

        const string _insertSetupEmail = @"INSERT INTO SetupEmail 
                                              (IdConfiguracao, NomeServidorSMTP, PortaEnvio, Login, Senha, NomeRemetente, EmailRemetente)
                                           VALUES 
                                              (@IdConfiguracao, @NomeServidorSMTP, @PortaEnvio, @Login, @Senha, @NomeRemetente, @EmailRemetente);
                                           SELECT CAST(SCOPE_IDENTITY() as int);";

        public static string SelectByIdSetupEmail() { return _selectByIdSetupEmail; }
        public static string InsertSetupEmail() { return _insertSetupEmail; }
    }
}
