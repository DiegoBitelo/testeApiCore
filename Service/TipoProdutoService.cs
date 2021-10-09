using Repository.Entities;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class TipoProdutoService
    {
        private TipoProdutoRepository _tipoProdutoRepository { get; set; }

        public TipoProdutoService(TipoProdutoRepository tipoProdutoRepository)
        {
            _tipoProdutoRepository = tipoProdutoRepository;
        }

        public List<TipoProduto> GetAll()
        {
            return _tipoProdutoRepository.Get().ToList();
        }
    }
}
