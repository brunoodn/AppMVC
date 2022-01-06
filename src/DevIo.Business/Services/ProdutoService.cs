using DevIo.Business.Interfaces;
using DevIo.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIo.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public Task Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid guid)
        {
            throw new NotImplementedException();
        }
    }

}
