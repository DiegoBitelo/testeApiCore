using Repository.Entities;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ProdutoService
    {
        private ProdutoRepository _produtoRepository { get; set; }
        private TipoProdutoRepository _tipoProdutoRepository { get; set; }

        public ProdutoService(ProdutoRepository produtoRepository, TipoProdutoRepository tipoProdutoRepository)
        {
            _produtoRepository = produtoRepository;
            _tipoProdutoRepository = tipoProdutoRepository;
        }

        public Produto GetById(long id)
        {
            return _produtoRepository.Get(x => x.Id == id, includeProperties: "TipoProduto").FirstOrDefault();
        }

        public bool Delete(long id)
        {
            return _produtoRepository.Delete(id);
        }

        public Produto Create(Produto produto)
        {
            produto.DataInclusao = DateTime.Now;
            return _produtoRepository.Insert(produto);
        }

        public List<Produto> GetAll()
        {
            return _produtoRepository.Get(includeProperties: "TipoProduto").ToList();
        }

        public Produto Update(Produto produto)
        {
            var tmpProduto = _produtoRepository.Get(x => x.Id == produto.Id, includeProperties: "TipoProduto").FirstOrDefault();
            tmpProduto.Nome = produto.Nome;
            tmpProduto.Descricao = produto.Descricao;
            tmpProduto.ValorUnitario = produto.ValorUnitario;
            tmpProduto.Quantidade = produto.Quantidade;
            if (tmpProduto.IdTipoProduto != produto.IdTipoProduto)
            {
                tmpProduto.IdTipoProduto = produto.IdTipoProduto;
                tmpProduto.TipoProduto = _tipoProdutoRepository.GetByID(tmpProduto.IdTipoProduto);
            }
            _produtoRepository.Update(tmpProduto);
            return tmpProduto;
        }
    }
}
