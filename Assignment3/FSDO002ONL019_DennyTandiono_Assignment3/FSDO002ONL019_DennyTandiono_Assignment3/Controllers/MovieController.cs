using FSDO002ONL019_DennyTandiono_Assignment3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDO002ONL019_DennyTandiono_Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public ActionResult<IEnumerable<MovieItem>> AddMovie(MovieItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.AddMovie(data);
        }

        [HttpPut("{id}", Name = "UpdateMovieById")]
        public ActionResult<IEnumerable<MovieItem>> UpdateMovie(MovieItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.UpdateMovie(data);
        }

        [HttpDelete("{id}", Name = "DeleteMovieById")]
        public ActionResult<IEnumerable<MovieItem>> DeleteEmployeeItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.DeleteMovie(id);
        }


        [HttpGet(Name = "GetMovie")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;

            return _context.GetAllMovies();
        }

        [HttpGet("{id}", Name = "GetMovieById")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;

            return _context.GetMovie(id);
        }
    }

}
