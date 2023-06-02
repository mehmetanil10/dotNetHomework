using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        Context db = new Context();
        public ActionResult Index()
        {
            List<Skill> skillList=db.Skills.ToList();
            return View(skillList);
        }
    }
}