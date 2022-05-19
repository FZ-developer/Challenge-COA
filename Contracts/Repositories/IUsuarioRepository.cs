using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IUsuarioRepository
    {
        IList<UsuarioDTO> GetAllUsers();
        void AddUser(UsuarioDTO usuarioDTO);
        void DeleteUser(UsuarioDTO usuarioDTO);
        void ModifyUser(UsuarioDTO usuarioDTO);

    }
}
