using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public interface IDataAccess
    {
        Task<DBEntity> ExecuteAsync(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<dynamic>> QueryAsync(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<K>> QueryAsync<K, A, B, C, D, E, F>(string sp, string split, object Param = null, int? Timeout = null);
        Task<IEnumerable<K>> QueryAsync<K, A, B, C, D, E>(string sp, string split, object Param = null, int? Timeout = null);
        Task<IEnumerable<K>> QueryAsync<K, A, B, C, D>(string sp, string split, object Param = null, int? Timeout = null);
        Task<IEnumerable<K>> QueryAsync<K, A, B, C>(string sp, string split, object Param = null, int? Timeout = null);
        Task<IEnumerable<K>> QueryAsync<K, A, B>(string sp, string split, object Param = null, int? Timeout = null);
        Task<IEnumerable<K>> QueryAsync<K, A>(string sp, string split, object Param = null, int? Timeout = null);
        Task<IEnumerable<K>> QueryAsync<K>(string sp, object Param = null, int? Timeout = null);
        Task<K> QueryFirstAsync<K>(string sp, object Param = null, int? Timeout = null);
    }
}
