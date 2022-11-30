using FiapSmartCity.Models;
using Microsoft.AspNetCore.Mvc;

namespace FiapSmartCity.Controllers
{
    public class TipoProdutoController : Controller
    {
        // GET: TipoProduto
        [HttpGet] // Anotação para usar o verbo GET
        public IActionResult Index()
        {
            // Criando uma lista para os tipos
            IList<TipoProduto> listaTipos = new List<TipoProduto>();

            // Adicionando na lista o TipoProduto da Tinta
            listaTipos.Add(new TipoProduto()
            {
                IdTypeProduct = 1,
                DescriptionTypeProduct = "Tinta",
                Marketed = true
            });

            listaTipos.Add(new TipoProduto()
            {
                IdTypeProduct = 2,
                DescriptionTypeProduct = "Filtro de água",
                Marketed = true
            });

            listaTipos.Add(new TipoProduto()
            {
                IdTypeProduct = 3,
                DescriptionTypeProduct = "Captador de energia",
                Marketed = false
            });

            // Retornando a lista de tipos criada para a View usar os dados no model.
            return View(listaTipos);
        }

        // GET e POST: Cadastrar - mesmo nome de função mudando apenas a anotação do method.
        [HttpGet]
        public IActionResult Cadastrar()
        {
            // Mock - simula a gravação em um banco de dados
            System.Diagnostics.Debug.Print("Executou a Action Cadastrar() com anotação GET");

            // Retorna um objeto instaciado o tipo do produto em branco para ser usado pela View.
            return View(new TipoProduto());
        }

        // Usando o method POST na Action Cadastrar()
        [HttpPost]
        public IActionResult Cadastrar(TipoProduto tipoProduto)
        {
            // Imprimi os valores no modelo
            System.Diagnostics.Debug.Print("Descrição: " + tipoProduto.DescriptionTypeProduct);
            System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Marketed);

            // Simula que os conteúdos foram gravados no banco
            System.Diagnostics.Debug.Print("Gravando o tipo do produto");


            // Subtitui o return View() por um redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }

    }
}
