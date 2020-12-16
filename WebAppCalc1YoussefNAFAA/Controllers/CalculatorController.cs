using ClassLibraryCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCalc1YoussefNAFAA.Models;


namespace WebAppCalc1YoussefNAFAA.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator calc, string calculate)
        {

            SimpleCalc simpleCalc = new SimpleCalc();

            if (calculate == "divide" && calc.number2 == 0)
            {
                calc.message = "Division By Zero!!!";
            }
            else
            {
                calc.total = simpleCalc.OpertorSwitch(calculate, calc.number1, calc.number2);

            }
            return View(calc);
        }

    }
}