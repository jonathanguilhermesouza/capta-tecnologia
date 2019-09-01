﻿using CaptaTecnologia.Data.Repositories;
using CaptaTecnologia.WebApi.Utils;
using CaptaTecnologia.WebApi.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace CaptaTecnologia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly UserRepository _repositoryUser;
        private readonly IConfiguration _configuration;

        public AccountController(UserRepository repositoryUser, IConfiguration configuration)
        {
            _configuration = configuration;
            _repositoryUser = repositoryUser;
        }

        //POST : /api/account/login
        [HttpPost]
        [Route("login")]
        public ActionResult Login(LoginViewModel model)
        {
            try
            {
                var user = _repositoryUser.GetObject(x => x.Username == model.Username);
                if (user != null && user.CheckPasswordAsync(model.Username, model.Password))
                {
                    string token = new AuthenticationToken().GenerateToken(user, _configuration);
                    return Ok(new { token });
                }
                else
                    return BadRequest(new { message = "Usuário ou senha incorretos" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}