using CaptaTecnologia.Data.Repositories;
using CaptaTecnologia.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CaptaTecnologia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CandidateController : ControllerBase
    {
        private readonly CandidateRepository _repositoryCandidate;

        public CandidateController(CandidateRepository repositoryCandidate)
        {
            _repositoryCandidate = repositoryCandidate;
        }

        // GET: api/candidate/getAllCandidate
        [HttpGet("getAllCandidate")]
        public ActionResult<IEnumerable<Candidate>> GetAllCandidate()
        {
            try
            {
                var candidates = _repositoryCandidate.GetAll();
                return Ok(candidates);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/candidate/getById/5
        [HttpGet("getById/{id}")]
        public ActionResult<Candidate> GetById(long id)
        {
            try
            {
                var candidate = _repositoryCandidate.GetObject(x => x.Id == id);

                if (candidate == null)
                {
                    return BadRequest("Candidato não encontrado");
                }

                return Ok(candidate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/candidate/putCandidate/5
        [HttpPut("putCandidate/{id}")]
        public ActionResult<Candidate> PutCandidate(long id, Candidate candidate)
        {
            try
            {
                if (id != candidate.Id)
                {
                    return BadRequest("As informações não coincidem");
                }

                var candidateData = _repositoryCandidate.GetObject(x => x.Id == id);
                candidateData.EditCandidate(candidate);
                _repositoryCandidate.Save();

                return Ok(candidateData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/candidate/deleteCandidate/5
        [HttpDelete("deleteCandidate/{id}")]
        public ActionResult<Candidate> DeleteCandidate(long id)
        {
            try
            {
                if (id == 0)
                    return BadRequest("Candidato não localizado");

                _repositoryCandidate.Delete(x => x.Id == id);
                _repositoryCandidate.Save();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/candidate/postCandidate
        [HttpPost("postCandidate")]
        public ActionResult<Candidate> PostCandidate(Candidate candidate)
        {
            try
            {
                if (candidate == null)
                    return BadRequest("Candidato não informado");

                _repositoryCandidate.Add(candidate);
                _repositoryCandidate.Save();

                return Ok(candidate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
