using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Book;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace Library_Final.Controllers
{
    public class BookController : Controller
    {
        public readonly IBookServices _bookServices;


        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _bookServices.GetAllAsync());
        }

        //Create
        public IActionResult Create()
        {
            return View("SaveBook", new SaveBookViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveBookViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveBook", vm);
            }

            await _bookServices.Add(vm);
            return RedirectToRoute(new { controller = "Book", action = "Index" });

        }

        //Edit
        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveBook", await _bookServices.GetByIdAsync(id));
        }


        [HttpPost]
        public async Task<IActionResult> Edit(SaveBookViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveBook", vm);
            }

            await _bookServices.UpdateAsync(vm.Id, vm);
            return RedirectToRoute(new { controller = "Book", action = "Index" });
        }


        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _bookServices.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _bookServices.DeleteAsync(id);
            return RedirectToRoute(new { controller = "Book", action = "Index" });
        }

    }



}

