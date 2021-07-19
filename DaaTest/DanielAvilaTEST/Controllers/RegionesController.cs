using Repositories.Interface.Regiones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DanielAvilaTEST.Controllers
{
    public class RegionesController : Controller
    {
        public readonly IRegions _regions;
        public RegionesController(IRegions regions)
        {
            _regions = regions;
        }

        // GET: Regiones
        public ActionResult Index(string id)
        {

            var region = _regions.GetRegions();

            var reg = new List<SelectListItem>();
            foreach (var item in region.data)
            {
                reg.Add(new SelectListItem() { Text = item.name, Value = item.iso });
            }
            ViewBag.ddlRegionsValues = reg;


            if (id == null)
            {
                //var regiones = _regions.GetRegionsDto().data.OrderByDescending(x => x.confirmed).Take(10);
                var regiones = _regions.GetCasesRegions(null);
                return View(regiones);
            }
            else
            {
                var regiones = _regions.GetCasesRegions(id);
                return View(regiones);
            }
        }
    }
}