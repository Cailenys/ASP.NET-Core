using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreTodo.Controllers
{
    public class    TruckController : Controller
    {
        private readonly ITruckModelService _truckModelService;
        public TruckController(ITruckModelService truckModelService)
        {
            _truckModelService = truckModelService;
        }
        public async Task<IActionResult> Index()
        {
            var items = await _truckModelService.GetIncompleteItemsAsync();
        }
    }
}