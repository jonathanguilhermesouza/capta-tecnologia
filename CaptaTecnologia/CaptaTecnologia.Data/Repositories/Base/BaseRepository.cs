using CaptaTecnologia.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CaptaTecnologia.Data.Repositories.Base
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        protected CaptaTecnologiaContext _context;

        public BaseRepository(CaptaTecnologiaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Busca o objeto pela chave.
        /// Obs: o array de paramentros deve seguir a sequência de criação da tabela.
        /// </summary>
        /// <param name="key">Array de parametros</param>
        /// <returns></returns>
        public TEntity FindByKey(params object[] key)
        {
            return _context.Set<TEntity>().Find(key);
        }

        /// <summary>
        /// Retorna um único objeto (firstOrDefault) baseado na condição
        /// </summary>
        /// <param name="predicateWhere"></param>
        /// <returns></returns>
        public TEntity GetObject(Expression<Func<TEntity, bool>> predicateWhere)
        {
            return _context.Set<TEntity>().FirstOrDefault(predicateWhere);
        }

        /// <summary>
        /// Retorna um Querable da lista do objeto "TEntry" informado.
        /// </summary>
        /// <param name="predicateOrderBy">Lambda dos filros para ordenação.</param>
        /// <param name="predicateWhere">Lambda dos filros para busca na base.</param>
        /// <param name="pSkip"></param>
        /// <param name="pTake"></param>
        /// <returns></returns>
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicateWhere = null)
        {

            if (predicateWhere != null)
                return _context.Set<TEntity>().Where(predicateWhere).AsQueryable();
            else
                return _context.Set<TEntity>().AsQueryable();
        }

        /// <summary>
        /// Inclui um novo objeto no contexto
        /// </summary>
        /// <param name="obj"></param>
        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
        }

        /// <summary>
        /// Exclui o objeto do contexto
        /// </summary>
        /// <param name="predicate"></param>
        public void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            _context.Set<TEntity>()
                 .Where(predicate).ToList()
                 .ForEach(del => _context.Set<TEntity>().Remove(del));
        }

        /// <summary>
        /// Atualiza o objeto do contexto
        /// </summary>
        /// <param name="obj"></param>
        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        /// <summary>
        /// Deve ser chamado depois de cada chamada aos métodos de Add(), Update() e Delete() 
        /// para efetivação das alterações na base.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context = new CaptaTecnologiaContext(new DbContextOptions<CaptaTecnologiaContext>());
                throw ex;
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
