using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Demo.DataModels;
using UnitOfWork.Demo.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnitOfWork.Demo.Controllers
{
    public class WidgetController : Controller
    {
        private readonly IWidgetCommandService _widgetCommandService;

        public WidgetController(IWidgetCommandService widgetCommandService)
        {
            _widgetCommandService = widgetCommandService;
        }

        // GET: /<controller>/
        public IActionResult AddWidget(Widget widget)
        {
            //3. Endpoint called to create a widget.
            _widgetCommandService.CreateWidget(widget);

            return Ok();
        }
    }
}

