using Common.DTO;
using Contracts.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeCOA.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("UsersList")]
        public ResponseDTO GetAllUsers()
        {
            return _usuarioService.GetAllUsers();
        }

        [HttpPost("Add")]
        public ResponseDTO AddUser([FromBody] UsuarioDTO newUser)
        {
            return _usuarioService.AddUser(newUser);
        }

        [HttpDelete("Delete/{userName}")]
        public ResponseDTO DeleteUser(string userName)
        {
            var deleteUser = new UsuarioDTO();
            deleteUser.UserName = userName;
            return _usuarioService.DeleteUser(deleteUser);
        }

        [HttpPut("Modify")]
        public ResponseDTO ModifyUser([FromBody] UsuarioDTO modifyUser)
        {
            return _usuarioService.ModifyUser(modifyUser);
        }
    }
}
