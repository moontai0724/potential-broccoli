using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Weekday()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Weekday(int weekday)
        {
            if (1 <= weekday && weekday <= 7)
            {
                string[] chinese = { "一", "二", "三", "四", "五", "六", "日" };
                ViewBag.weekdayInChinese = "星期" + chinese[weekday - 1];
            }
            return View();
        }
    }
}