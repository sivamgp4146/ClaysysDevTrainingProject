using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaysysDevTrainingProject.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// This action is used to show the login page view with internal style sheet.
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginForm()
        {
            return View();
        }
        /// <summary>
        /// This action is used to show the login page view with external style sheet.
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginFormExtCSS()
        {
            return View();
        }
        /// <summary>
        /// This action is used to show the Student registration page view with internal style sheet.
        /// </summary>
        /// <returns></returns>
        public ActionResult StudentRegistration()
        {
            return View();
        }
        /// <summary>
        /// This action is used to show the Student registration page view with external style sheet.
        /// </summary>
        /// <returns></returns>
        public ActionResult StudentRegistrationExtCSS()
        {
            return View();
        }
        /// <summary>
        /// This action is used to show the Student mark entry page view with external style sheet.
        /// </summary>
        /// <returns></returns>
        public ActionResult StudentMarkEntry()
        {
            return View();
        }
    }
}