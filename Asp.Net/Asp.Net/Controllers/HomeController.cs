﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net.Controllers
{
    public class HomeController : Controller
    {
        //Request Response получают данные из HttpContexta
        [Route("Cookie")] //Маршрут URL /Cookie
        public string Cookie()
        {
            if (Request.Cookies.ContainsKey("name"))
            {
                string name = Request.Cookies["name"];
                return name;
            }
            Response.Cookies.Append("name", "Rumia");
            return "Печеньки хочешь?";

        }

        [Route("Code")]
        public string StatusCode()
        {
            return "Статус кода " + Response.StatusCode + " " + "Метод запроса " + Request.Method + ";" + HttpContext.User.Identity.Name + " Авторизован = " + HttpContext.User.Identity.IsAuthenticated + " админ = " + HttpContext.User.IsInRole("admin");
        }

    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }

}
