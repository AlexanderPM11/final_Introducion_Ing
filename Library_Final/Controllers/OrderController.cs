using Example.Core.Application.Interfaces.Repositories;
using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Applicantion.ViewModels.OrderDatail;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Library_Final.Controllers
{
    public class OrderController : Controller
    {

        private readonly IDetailOrderServices _detailOrderServices;
        public OrderController(IDetailOrderServices detailOrderServices)
        {
            _detailOrderServices = detailOrderServices; 
        }


        public async Task<IActionResult> Index()
        {            
            return View(await _detailOrderServices.GetAllAsync());

        }



        [HttpGet]
        public  PartialViewResult PartialViewCreate( int id)
        {
            return PartialView(new SaveOrderDetailViewModel() { BookId= id });
        }

        [HttpPost]
        public async Task<JsonResult> Create(SaveOrderDetailViewModel vm)
        {            

           var result= await _detailOrderServices.Add(vm);
            return Json(new { Status=result.Status,Message=result.Message });

        }
    }
}
