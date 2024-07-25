using System.Data;
using System.Data.SqlClient;
using Dapper;
using static Dapper.SqlMapper;

namespace Data.Repository
{
    public class BaseRepository
    {
        private readonly IDbConnection _dbConnection;

        protected BaseRepository(string connectionString)
        {
            _dbConnection = new SqlConnection(connectionString);
        }

        protected IDbConnection DbConnection => _dbConnection;

        public async Task<IEnumerable<T>> SelectAll<T>(string query)
        {
            try
            {
                return await _dbConnection.QueryAsync<T>(query);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> InsertAndGetIdAsync(string query, object parameters = null)
        {
            try
            {
                return await _dbConnection.QuerySingleAsync<int>(query, parameters);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<T> SelectById<T>(string query, object parameters = null)
        {
            try
            {
                return await _dbConnection.QuerySingleOrDefaultAsync<T>(query, parameters);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
