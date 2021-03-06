using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC.Calc.API;

namespace POC.Calc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        private EntryRepository _repository;

        public EntryController()
        {
            _repository = new EntryRepository();
        }
        // GET: api/Entry
        [HttpGet]
        public IEnumerable<DatabaseModel> GetDatabaseModel()
        {
            return _repository.GetAllEntry();
        }
        
        [HttpPost]
        public void AddDatabaseModel(DatabaseModel dbModel)
        {
            _repository.AddEntry(dbModel);
        }
    }
}
