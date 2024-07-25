using System;
using Domain.Interfaces.Repository;

public class ConfiguracaoRepository : IConfiguracaoRepository
{
    public ConfiguracaoRepository()
    {
        public async Task<int> InsertAsync(ConfiguracaoEntity entity)
        {
            var sql = @"
            INSERT INTO YourTableName (Name) 
            VALUES (@Name);
            SELECT CAST(SCOPE_IDENTITY() as int);";

            var parameters = new { Name = entity.Name };

            // Executa a consulta e retorna o ID gerado
            return await _dbConnection.QuerySingleAsync<int>(sql, parameters);
        }
    }
}
