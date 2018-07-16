using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoPWACanalNET.Models;

namespace DemoPWACanalNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult News()
        {
            List<News> list = new List<News>();

            for(int i = 1; i < 50; i++)
            {
                News news = new News();
                news.Title = "Título " + i.ToString();
                news.Description = "Os franceses voltam ao topo do mundo. Em um decisão com gol contra e uso do VAR inéditos em finais de Copa do Mundo, além de invasão de gramado por um grupo radical russo, a França derrotou a Croácia por 4 a 2, neste domingo, no Estádio Olímpico Lujniki, em Moscou, e conquistou o título mundial de futebol pela segunda vez na história. Mandzukic (contra), Griezmann, Pogba e Mbappé fizeram os gols da equipe azul, enquanto Perisic e Madzukic, este se aproveitando de uma falha bizarra do goleiro e capitão Lloris, descontaram para a Croácia. ";
                news.Photo = "../images/copa-do-mundo.jpg";

                list.Add(news);
            }

            return View(list);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

    }
}
