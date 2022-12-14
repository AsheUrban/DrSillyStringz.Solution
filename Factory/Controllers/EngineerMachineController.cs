using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class EngineerMachineController : Controller
  {
    private readonly FactoryContext _db;

    public EngineerMachineController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "View Engineers & Machines";
      List<EngineerMachine> model = _db.EngineerMachine.ToList();
      return View(model);
    }

    [HttpPost]
    public ActionResult Create(EngineerMachine engineermachine)
    {
      if (_db.EngineerMachine.FirstOrDefault(
              EM => EM.MachineId == engineermachine.MachineId && 
                    EM.EngineerId == engineermachine.EngineerId) == null)
      {
        _db.EngineerMachine.Add(engineermachine);
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}

