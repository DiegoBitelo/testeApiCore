using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public ProdutoRepository(WebAppDbContext context) : base(context)
        {
        }
    }
}
