namespace Data.Scripts
{
    public static class SetupSMSScripts
    {
        const string _selectByIdConfiguracao = @"SELECT IdSetupSMS, IdConfiguracao, ProvedorSMS, Login, Senha
                                                 FROM SetupSMS
                                                 WHERE IdConfiguracao = @idConfiguracao";

        const string _insertSetupSms = @"INSERT INTO SetupSMS (IdConfiguracao, ProvedorSMS, Login, Senha)
                                         VALUES (@IdConfiguracao, @ProvedorSMS, @Login, @Senha);
                                         SELECT CAST(SCOPE_IDENTITY() as int);";

        public static string SelectByIdConfiguracao() { return _selectByIdConfiguracao; }
        public static string InsertSetupSMS() { return _insertSetupSms; }
    }
}
