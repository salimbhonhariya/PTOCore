using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PTOCore.Repositories.PTO;
using PTOCore.ViewModels;

namespace PTOCore.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [ApiExplorerSettings(IgnoreApi = false)]

    //[Produces("application/json")]
    //[Route("api/Employee")]
    public class PTOApiController : Controller
    {
        private IPTORepository _iPTORepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PTOApiController" /> class.
        /// </summary>
        /// <param name="iPTORepository">The i pto repository.</param>
        public PTOApiController(IPTORepository iPTORepository)
        {
            _iPTORepository = iPTORepository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PTOApiController"/> class.
        /// </summary>
        protected PTOApiController()
        {
        }

        // GET: api/PTO
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
       [HttpGet("GetAllEmployeesPTOHoursByDateRange")]
        public IActionResult GetAllEmployeesPTOHoursByDateRange(DateTime fromDate, DateTime toDate)
        {
            // get the data back from DB
            ICollection<PTORepository> employeePTOHours = _iPTORepository.GetAllEmployeesPTOHoursByDateRange(fromDate, toDate);
            // fill view model from it
            IList<EmployeesPTOHoursByDateRangeViewModel> lstemployeesPTOHoursByDateRangeViewModels = new List<EmployeesPTOHoursByDateRangeViewModel>();

            foreach (var item in employeePTOHours)
            {
                var EmployeesPTOHoursByDateRangeViewModel = new EmployeesPTOHoursByDateRangeViewModel
                {
                    //Id = item.Id,
                    //items = GetItemViewModelAttributes(item),
                    //first = item.paging.first,
                    //next = item.paging.next,
                    //last = item.paging.last,
                    //previous = item.paging.previous
                };
                lstemployeesPTOHoursByDateRangeViewModels.Add(EmployeesPTOHoursByDateRangeViewModel);
            }
            return View(lstemployeesPTOHoursByDateRangeViewModels);
        }

        // GET: api/PTO/5
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("id")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PTO
        /// <summary>
        /// Posts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        [HttpPost("post")]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PTO/5
        /// <summary>
        /// Puts the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="value">The value.</param>
        [HttpPut("id")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete("id")]
        public void Delete(int id)
        {
        }


    }
}
