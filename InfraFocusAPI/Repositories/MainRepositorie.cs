using DomainFocusAPI.Interfaces;
using InfraFocusAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfraFocusAPI.Repositories
{
    public class MainRepositorie<TEntity> : IMainRepositorie<TEntity> where TEntity : class
    {
        private readonly Context _Context;

        public MainRepositorie(Context context)
        {
            _Context = context;
        }

        public async Task Adicionar(TEntity NewRegister)
        {
            _Context.Add(NewRegister);
            await _Context.SaveChangesAsync();
        }

        public async Task Alterar(TEntity UpdatedRegister)
        {
            _Context.Update(UpdatedRegister);
            await _Context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> ListarTodos()
        {
            return await _Context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> ListarTodosExpression(Expression<Func<TEntity, bool>> Expression)
        {
            return await _Context.Set<TEntity>().Where(Expression).ToListAsync();
        }

        public async Task<TEntity> SelecionarExpression(Expression<Func<TEntity, bool>> Expression)
        {
            return await _Context.Set<TEntity>().FirstOrDefaultAsync(Expression);
        }
    }
}
