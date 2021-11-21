using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Linq;

namespace ClimaTempoSimples.Controllers
{
    using ClimaTempoSimples.Abstractions.Services;
    using ClimaTempoSimples.Models;

    public class HomeController : Controller
    {
        private readonly ICidadeService cidadeService;
        private readonly IPrevisaoClimaService previsaoClimaService;
        private IEnumerable<Cidade> cidades;
        
        public HomeController(ICidadeService cidadeService, IPrevisaoClimaService previsaoClimaService)
        {
            this.cidadeService = cidadeService ?? throw new ArgumentNullException(nameof(cidadeService));
            this.previsaoClimaService = previsaoClimaService ?? throw new ArgumentNullException(nameof(previsaoClimaService));
        }
        public async Task<ActionResult> Index()
        {
            cidades = await cidadeService.ListarTodasAsync();
            List<SelectListItem> items = (from item in cidades
                                          select new SelectListItem() 
                                           { 
                                               Value = item.Id.ToString(), 
                                               Text = item.Nome 
                                           }
                                         ).ToList();
            ViewBag.Cidades = items;

            ViewBag.CidadesMaisQuentes = await previsaoClimaService.ObterTresCidadesMaisQuentes();

            ViewBag.CidadesMaisFrias = await previsaoClimaService.ObterTresCidadesMaisFrias();

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ObeterPrevisaoSemanal(string idCidade)
        {
            var previsoes = await previsaoClimaService.ObterPrevisaoSemanalParaUmaCidade(Convert.ToInt32(idCidade));
            return Json(from item in previsoes
                            select new
                            {
                                DiaSemana = item.DataPrevisao.DayOfWeek.ToString(),
                                item.Clima,
                                item.TemperaturaMaxima,
                                item.TemperaturaMinima
                            }
                       );
        }
        public ActionResult About()
        {
            ViewBag.Message = "Desenvolvido por:";

            return View();
        }
    }
}