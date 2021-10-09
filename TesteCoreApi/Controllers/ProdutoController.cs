using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TesteCoreApi.Models;

namespace TesteCoreApi.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoService _produtoService;
        private readonly TipoProdutoService _tipoProdutoService;

        public ProdutoController(ProdutoService produtoService, TipoProdutoService tipoProdutoService)
        {
            _produtoService = produtoService;
            _tipoProdutoService = tipoProdutoService;
        }


        public IActionResult GetAll()
        {
            return Ok(_produtoService.GetAll());
        }


        public IActionResult GetById(long id)
        {
            return Ok(_produtoService.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Produto produto)
        {
            return Ok(_produtoService.Create(produto));
        }

        [HttpPost]
        public IActionResult Update([FromBody] Produto produto)
        {
            return Ok(_produtoService.Update(produto));
        }

        public IActionResult Delete(long id)
        {
           return Ok(_produtoService.Delete(id));
        }

        public IActionResult GetAllTipoProdutos()
        {
            return Ok(_tipoProdutoService.GetAll());
        }

    }
}
