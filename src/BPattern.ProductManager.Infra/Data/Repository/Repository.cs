using BPattern.ProductManager.Business.Core.Data;
using BPattern.ProductManager.Business.Core.Models;
using BPattern.ProductManager.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BPattern.ProductManager.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly PMContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository()
        {
            Db = new PMContext();
            DbSet = Db.Set<TEntity>(); //Acesso rápido a entitdade
        }
        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> Buscar(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }
        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }
        public virtual async Task Remover(Guid id)
        {
            // Para utilizar o TEntity foi necessário coloca ,new() na declaração da classe
            // Para economizar ida ao banco de dados
            Db.Entry(new TEntity { Id = id }).State = EntityState.Deleted;
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            // Se o Db possuir uma instância definida. Realizar o Dispose
            Db?.Dispose();
        }
    }
}
