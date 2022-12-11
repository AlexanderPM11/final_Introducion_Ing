using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Book;
using Library_Final.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Library.Controller.UnitTest
{
    public class BookControllerTest
    {

        private readonly Mock<IBookServices> _bookServices;
        private readonly BookController _bookController;

        public BookControllerTest()
        {
            _bookServices = new ();
            _bookController = new BookController(_bookServices.Object);
        }

        /// <summary>
        /// Debería de hacer redirecionamiento cuando se creee un nuevo libro de manera sactisfactoria
        /// y este cumpla con los críterios.
        /// </summary>
    
        [Fact]
        public async Task AddBookUnitTest_ShouldReturn_Redirect_WhenModelIsValid()
        {

            //Arrange
            var book = new SaveBookViewModel()
            {
                Id = 1,
                AuthorId = 2,
                PublicationYear = 2022,
                ISBNCode = "2-32323-239232-2",
                Price = 300.00,
                PageNumber = 200
            };


            //Act
            var result = await _bookController.Create(book);

            //Assert
            var redirectToResult = Assert.IsType<RedirectToRouteResult>(result);

        }

       
        /// <summary>
        ///  Se espera que retorne un listado de libros a la vista Index.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Index_ShouldReturnAViewResultWithAListOfBooks()
        {
            //Arrange
              _bookServices.Setup(bservice => bservice.GetAllAsync())
                           .ReturnsAsync(GetAllBookDTOsTestResource());

            //Act
            var result = await _bookController.Index();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<BookViewModel>>(viewResult.ViewData.Model);
            Assert.True(model.Count() > 0);

        }


        private List<BookViewModel> GetAllBookDTOsTestResource()
        {
            List<BookViewModel> books = new();

            books.Add(new BookViewModel()
            {
                Id = 1,
                Title = "Tu no te vas",
                IsOnlineAvailable = true,
                GenderId = 1,
                Price = 300.00,
                PageNumber = 200
            });

            books.Add(new BookViewModel()
            {
                Id = 2,
                Title = "Po po pop",
                IsOnlineAvailable = true,
                GenderId = 7,
                Price = 500.00,
                PageNumber = 10,
                AuthorId = 2, 
                ISBNCode = "2-93383-280280-2"
            });


            return books;
        }


    }
}
