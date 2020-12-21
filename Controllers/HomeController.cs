using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClashCreative.Models;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ClashCreative.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private ClashContext context;
        public HomeController(ClashContext c, IHttpClientFactory f)
        {
            context = c;
            _clientFactory = f;
        }

        public IActionResult Index()
        {
            //creates an instance of the model because the constructor holds crucial formatting variables
            HomePageModel model = new HomePageModel();

            return View(model);
        }


    }
}


//saving in case I want later
//string myPlayerTag = "#29PGJURQL";
//string myClanTag = "#8CYPL8R";
//string sorenClanTag = "#L2JUGRVR";
//string aPlayerTag = "#9QGPC82Y0";
//string dangerFrog = "#8UUQVLP0";

//await GetClanMembersData(sorenClanTag);
//await GetClanMembersData(myClanTag);

//var me = await GetPlayerData(myPlayerTag);
//var frog = await GetPlayerData(dangerFrog);
//var rando = await GetPlayerData(aPlayerTag);

