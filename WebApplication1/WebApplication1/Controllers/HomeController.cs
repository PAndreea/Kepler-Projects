using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int n = 3)
        {
            if (n <= 0) return "Numar invalid"; 
            int l = 0;
            for (int i = n + 1; i >= 2; i--)
                l = l + i;
            l = l + 2;
            int c = 2 * n + 1;//linii coloane

            int[,] a = new int[l + 1, c + 1];
            for (int i = 1; i <= l; i++)
                for (int j = 1; j <= c; j++)
                    a[i, j] = 0;//initializare matrice

            Bradapp.Brad br = new Bradapp.Brad();
            for (int i = 1; i <= n; i++)
                a = br.MatriceBrad2(i, a, n);
            a[l - 1, n + 1] = 1; a[l, n + 1] = 1;//trunchi


            string s = "";
            for (int i = 1; i <= l; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    if (a[i, j] == 1)
                        s = s + "*";
                    else s = s + " ";

                }
                s = s + "\n";
            }
            return s;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
