using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ContohController : BaseApiController
    {
        private readonly DataContext _context;
        public ContohController(DataContext context)
        {
            _context = context;
        }

         [HttpGet] //api/activities

        public async Task<string[]> giudsgfiwdgfid()
        {
            string[] ayang = {"Ayaaang", "I", "Love", "Youuuu"}; 
            return ayang;
        }


    }
}