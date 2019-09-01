using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaptaTecnologia.Data.Repositories;
using CaptaTecnologia.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CaptaTecnologia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GenderController : Controller
    {
        private readonly GenderRepository _repositoryGender;

        public GenderController(GenderRepository repositoryGender)
        {
            _repositoryGender = repositoryGender;
        }

        // GET: api/gender/getAllGender
        [HttpGet("getAllGender")]
        public ActionResult<IEnumerable<Gender>> GetAllGender()
        {
            try
            {
                var genders = _repositoryGender.GetAll().ToList();
                return Ok(genders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}