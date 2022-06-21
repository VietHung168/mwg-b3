using bai3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       // public FakeData fdt1 = new FakeData();
        List<Product> loctheogia(List<Product> l, List<int> gia )
        {
            List<Product> tem = new List<Product>();
            foreach (Product pr in l)
            {
                foreach (int lo in gia)
                {
                    if (pr.PriceLimit == Program.fdt.listPriceLimit[lo])
                    {
                        tem.Add(pr);
                    }
                }
            }
            if (tem.Count == 0) return l;
            return tem;
        }
        List<Product> loctheoloai(List<Product> l, List<int> loai)
        {
            List<Product> tem = new List<Product>();
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < loai.Count; j++)
                {

                    string s = Program.fdt.listType[loai[j]] + "/" + l[i].Type;
                    Console.WriteLine(s);
                    if (Program.fdt.listType[loai[j]] == l[i].Type)
                        tem.Add(l[i]);
                }
            }

            if (tem == null) return l;
            return tem;
        }
        List<Product> loctheohang(List<Product> l, List<int> hang)
        {
            List<Product> tem = new List<Product>();
            foreach (Product pr in l)
            {
                foreach (int lo in hang)
                {
                    if (lo == pr.id_Firm)
                    {
                        tem.Add(pr);
                    }
                }
            }
            if (tem.Count==0) return l;
            return tem;
            
        }
        List<Product> loctheocanngan(List<Product> l, List<int> can)
        {
            List<Product> tem = new List<Product>();
            foreach (Product pr in l)
            {
                foreach (int lo in can)
                {
                    if (pr.weightLimit== Program.fdt.listWeight[lo])
                    {
                        tem.Add(pr);
                    }
                }
            }
            if (tem.Count==0) return l;
            return tem;
        }
        List<Product> loctheosize(List<Product> l, List<int> size)
        {
            List<Product> tem = new List<Product>();
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < size.Count; j++)
                {

                    if (Program.fdt.ListSize[size[j]] == l[i].Size)
                        tem.Add(l[i]);
                }
            }

            if (tem.Count == 0) return l;
            return tem;

        }
        List<Product> phantrang( int trang, List<Product> l)
        {
            //10*trang +i
            List<Product> tem = new List<Product>();
            for (int i = 0; i <l.Count; i++)
            {
              if(i>= 10 *(trang-1)  && i<10*(trang))
                {
                    tem.Add(l[i]);
                }
            }

           
            return tem;

        }
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View(Program.fdt);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult getProducts(List<int> Hang, List<int> gia, List<int> Loai, List<int> cannag, List<int> size, int sort, int page)
        { 
            

            List<Product> list = new List<Product>();
            list = Program.fdt.listProduct;

           //// list = loctheosize(list, size);
         //   list = loctheocanngan(list, cannag);
         // list = loctheohang(list,Hang);
          //  list = loctheogia(list, gia);
            //  list = loctheoloai(list, Loai);
            list = phantrang(page, list);
          


            string value = string.Empty;
            value = JsonConvert.SerializeObject(list, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Json(value);
        }
        public IActionResult listproduct(List<Product> list)
        {
            return View(list);
           
        }
    }
}

