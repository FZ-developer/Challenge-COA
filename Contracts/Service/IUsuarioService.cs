using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Service
{
    public interface IUsuarioService
    {
        ResponseDTO GetAllUsers();
        ResponseDTO AddUser(UsuarioDTO usuarioDTO);
        ResponseDTO DeleteUser(UsuarioDTO usuarioDTO);
        ResponseDTO ModifyUser(UsuarioDTO usuarioDTO);
    }
}