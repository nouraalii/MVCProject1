using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using MVCProject1.Models;

namespace MVCProject1.Controllers
{
    //MVC Controller
    public class MovieController : Controller
    {
        //Actions : Public non-static method
        //Actions : Have Special Return Types
        //ActionResult

        //public string GetMovie(int id)
        //{
        //    return $"Get Movie with Id : {id}";
        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie with Id : {id}";
        //}



        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie with Id : {id}",
        //        ContentType = "text/html",
        //        StatusCode = 200
        //    };
        //    return contentResult;
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie with Id : {id}",
        //        ContentType = "object/pdf",
        //        StatusCode = 200
        //    };
        //    return contentResult;
        //}

        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectResult = new RedirectResult("https://www.google.com/");

        //    return redirectResult;
        //}

        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie", "Movie", new {id=133});

        //    return redirectToActionResult;
        //}

        //[ActionName("GetMovie")]
        //public IActionResult GetMovieByIdByCategoryDramaAndPoster(int id)
        //{
        //    if (id == 1)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie with Id : {id}", ContentType = "text/html" };
        //        return Content($"Get Movie with Id : {id}", "text/html");
        //    }
        //    else if (id == 2)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie with Id : {id}", ContentType = "object/pdf" };
        //        return Content($"Get Movie with Id : {id}", "object/pdf");
        //    }
        //    else if (id == 3)
        //    {
        //        //return new RedirectResult("https://www.google.com/");
        //        return Redirect("https://www.google.com/");
        //    }
        //    else
        //    {
        //        //return new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });
        //        return RedirectToAction("AddMovie", "Movie", new { id = 133 });
        //    }
        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie with Id : {id}";
        //}


        //Actions Parameter Binding
        //1.Form
        //2.Segment
        //3.Query params
        //4.Files

        public IActionResult GetMovie(Movie movie)
        {
            return Content($"Get Movie with Id : {movie.Id} , Name : {movie.Name} ", "text/html");
        }

    }
}
