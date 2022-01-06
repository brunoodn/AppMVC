using DevIo.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Business.Interfaces
{
    public interface IFornecedorService
    {
        Task Adicionar(Fornecedor fornecedor);

        Task Atualizar(Fornecedor fornecedor);

        Task Remover(Guid guid);

        Task AtualizarEndereco(Endereco enderedo);
    }
}
