using DevIo.Business.Interfaces;
using DevIo.Business.Models;
using DevIo.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace DevIo.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public async Task Adicionar(Fornecedor fornecedor)
        {
           
            //Validar o estado da entidade
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor) 
                && !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco )) return;
            //se nao existir fornecedor com o mesmo documento
 
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
        }

        public Task Remover(Guid guid)
        {
            throw new NotImplementedException();
        }
    }

}
