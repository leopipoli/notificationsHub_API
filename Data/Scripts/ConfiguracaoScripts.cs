namespace Data.Scripts
{
    public static class ConfiguracaoScripts
    {
        const string _selectAll = @"SELECT IdConfiguracao, NomeAplicativo, SetupWeb, SetupEmail, SetupSMS 
                                    FROM CONFIGURACAO";        
        
        const string _selectByIdConfiguracao = @"SELECT IdConfiguracao, NomeAplicativo, SetupWeb, SetupEmail, SetupSMS 
                                              FROM CONFIGURACAO
                                              WHERE IdConfiguracao = @id";

        const string _insertConfiguracao = @"INSERT INTO Configuracao (NomeAplicativo, SetupWeb, SetupEmail, SetupSMS) 
                                           VALUES (@NomeAplicativo, @SetupWeb, @SetupEmail, @SetupSMS);
                                           SELECT CAST(SCOPE_IDENTITY() as int);";

        public static string SelectAll() { return _selectAll; }
        public static string SelectByIdConfiguracao() { return _selectByIdConfiguracao; }
        public static string InsertConfiguracao() { return _insertConfiguracao; }
    }
}
