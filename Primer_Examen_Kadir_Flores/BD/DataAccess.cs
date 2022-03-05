using Dapper;
using Dapper.Mapper;
using Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DataAccess : IDataAccess
    {
        private readonly IConfiguration configuration;

        public DataAccess(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public SqlConnection DbConnetion => new SqlConnection(
            new SqlConnectionStringBuilder(configuration.GetConnectionString("Conec")).ConnectionString
            );

        public async Task<IEnumerable<K>> QueryAsync<K>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryAsync<K>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<dynamic>> QueryAsync(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryAsync(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<K>> QueryAsync<K, A>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryAsync<K, A>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<K>> QueryAsync<K, A, B>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryAsync<K, A, B>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<K>> QueryAsync<K, A, B, C>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryAsync<K, A, B, C>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<K>> QueryAsync<K, A, B, C, D>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryAsync<K, A, B, C, D>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<K>> QueryAsync<K, A, B, C, D, E>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryAsync<K, A, B, C, D, E>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<K>> QueryAsync<K, A, B, C, D, E, F>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryAsync<K, A, B, C, D, E, F>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout, splitOn: split);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<K> QueryFirstAsync<K>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = exec.QueryFirstOrDefaultAsync<K>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    return await result;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DBEntity> ExecuteAsync(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnetion)
                {
                    await exec.OpenAsync();

                    var result = await exec.ExecuteReaderAsync(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure, commandTimeout: Timeout);

                    await result.ReadAsync();

                    return new()
                    {
                        CodError = result.GetInt32(0),
                        MsgError = result.GetString(1)
                    };
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
