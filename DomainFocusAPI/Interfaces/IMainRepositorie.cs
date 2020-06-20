using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainFocusAPI.Interfaces
{
    public interface IMainRepositorie<TEntity> where TEntity : class
    {
        public Task<List<TEntity>> ListarTodosExpression(Expression<Func<TEntity, bool>> Expression);
        public Task<List<TEntity>> ListarTodos();
        public Task<TEntity> SelecionarExpression(Expression<Func<TEntity, bool>> Expression);
        public Task Adicionar(TEntity NewRegister);
        public Task Alterar(TEntity UpdatedRegister);
    }
}
