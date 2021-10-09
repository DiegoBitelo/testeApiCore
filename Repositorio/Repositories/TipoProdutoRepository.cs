using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class TipoProdutoRepository : BaseRepository<TipoProduto>
    {
        public TipoProdutoRepository(WebAppDbContext context) : base(context)
        {
        }
    }
}
