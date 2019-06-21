using Periodicals.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Periodicals.Web.Controllers
{
    public class PeriodicalController : Controller
    {
        private IPeriodicalRepository _repository;
        public PeriodicalController(IPeriodicalRepository repo)
        {
            _repository = repo;
        }

        // GET: Periodical
        public ActionResult Index()
        {            
            return View(_repository.Periodicals);
        }

    }
}