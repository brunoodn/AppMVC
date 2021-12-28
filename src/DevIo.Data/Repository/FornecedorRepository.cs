using DevIo.Business.Models;
using DevIo.Business.Interfaces;
using System;
using System.Threading.Tasks;
using DevIo.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIo.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        
        public FornecedorRepository(MeuDbContext context) : base(context) {  }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(e => e.Produtos)
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
