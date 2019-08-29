using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steam.Controllers
{
    public class LegalInfomationController : Controller
    {
        // GET: LegalInfomation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VideoPolicy()
        {
            return View();
        }
        public ActionResult PrivacyPolicyAgreement()
        {
            return View();
        }
        public ActionResult SteamSubscriberAgreement()
        {
            return View();
        }
        public ActionResult SteamRefunds()
        {
            return View();
        }
        public ActionResult RefundList()
        {
            return View();
        }
    }
}