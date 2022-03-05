using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IInstitucionService
    {
        Task<DBEntity> CREATE(Institucion entity);
        Task<DBEntity> DELETE(Institucion entity);
        Task<IEnumerable<Institucion>> GET();
        Task<Institucion> GETBYID(Institucion entity);
        Task<DBEntity> UPDATE(Institucion entity);
    }

    public class InstitucionService : IInstitucionService
    {
        private readonly IDataAccess sql;

        public InstitucionService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCRUD

        //Metodo Get
        public async Task<IEnumerable<Institucion>> GET()
        {
            try
            {
                var result = sql.QueryAsync<Institucion>("dbo.InstitucionObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //MetodoGetById

        public async Task<Institucion> GETBYID(Institucion entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<Institucion>("dbo.InstitucionObtener", new { entity.Id_Intitucion });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Metodo Create

        public async Task<DBEntity> CREATE(Institucion entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.InstitucionInsertar", new { entity.Id_Intitucion, entity.Codigo, entity.Nombre, entity.Telefono, entity.Estado });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Metodo Update

        public async Task<DBEntity> UPDATE(Institucion entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.InstitucionActualizar ", new { entity.Id_Intitucion, entity.Codigo, entity.Nombre, entity.Telefono, entity.Estado });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Metodo Delete

        public async Task<DBEntity> DELETE(Institucion entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.InstitucionActualizar ", new { entity.Id_Intitucion });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
