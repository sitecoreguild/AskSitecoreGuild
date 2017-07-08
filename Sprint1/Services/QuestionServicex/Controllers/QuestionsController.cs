using QuestionService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestionService.Controllers
{
    public class QuestionsController : Controller
    {
        // GET: Questions
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Used to submit a piece of content for processing
        /// </summary>
        /// <param name="formCollection"></param>
        /// <returns></returns>
        public ActionResult Ask(FormCollection formCollection)
        {
            if (string.IsNullOrEmpty(formCollection["vipId"]) == false)
            {
                #region TO DO: Need to program validation for vip members for tracking

                //var jsonContactManager = new CrmJsonContactManager(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Json/Crm/"));
                //var jsonAssetManager = new CmsJsonAssetManager(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Json/Cms/"));

                // Look up the vip id
                //CrmContactManager manager = new CrmContactManager();
                //var vipContact = manager.GetContact(jsonContactManager, formCollection["vipId"], null);

                #endregion

                Contact vipContact = null;

                // FOR NOW SWITCH STATEMENT
                switch(formCollection["vipId"].ToUpperInvariant())
                {
                    case "53E8DB80-CDB4-4BCC-8736-5C6BF4579846":
                        vipContact = new Contact()
                        {
                            Id = "53E8DB80-CDB4-4BCC-8736-5C6BF4579846",
                            ContactName = "Poutine Admin",
                            FirstName = "Poutine",
                            MiddleName = "",
                            LastName = "Admin",
                        };

                        break;
                }

                if (vipContact != null)
                {
                    string answer = string.Empty;

                    switch(formCollection["question"].ToUpperInvariant())
                    {
                        case "WHAT IS SITECORE":
                            // TO DO: Look up the question so we can include answer in response.
                            answer = "Sitecore is the best Experience platform.";
                            break;
                        default:
                            answer = "Can you repeat the question another way? I am still learning.";
                            break;
                    }

                    return Content("<p>Thanks " + vipContact.ContactName + ".<br/>" + answer + "</p>", "text/html");
                }
            }

            return Content("<p>Nice to meet you email me at <a href='mailto:chris.williams@readwatchcreate.com'>chris.williams@readwatchcreate.com</a> for Official Access</p>", "text/html");
        }
    }
}