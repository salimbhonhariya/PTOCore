using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTOCore.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace PTOCore.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    //[Authorize]// which means that this controller is accessed by only authenticate users
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="userManager">The user manager.</param>
        public HomeController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //[Authorize(Roles = "Administrator")]  //which represents that what role can access this action method. 
        [HttpGet("Index")]
        public IActionResult Index()
        {

            string userName = userManager.GetUserName(User);
            return View("Index", userName);
            //return View();
        }

        /// <summary>
        /// Gets the user identity.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserIdentity")]
        public string GetUserIdentity()
        {
            return User.Identity.Name;
        }


        /// <summary>
        /// Abouts this instance.
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet("About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Contacts this instance.
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Errors this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}