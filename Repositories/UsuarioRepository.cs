using Common.DTO;
using Common.Exceptions;
using Contracts.Repositories;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private COAContext _context { get; set; }
        public UsuarioRepository(COAContext context)
        {
            _context = context;
        }

        public IList<UsuarioDTO> GetAllUsers()
        {
            return _context.Usuarios.Where(x => x.Activo).Select(x => new UsuarioDTO()
            {
                Nombre = x.Nombre,
                UserName = x.UserName,
                Mail = x.Mail,
                Telefono = x.Telefono
            }).ToList();
        }

        public void AddUser(UsuarioDTO usuarioDTO)
        {

            if (_context.Usuarios.Any(x => x.UserName == usuarioDTO.UserName && x.Activo))
            {
                throw new UsuarioExceptions("El nombre de usuario que ha ingresado ya es existente.");
            }
            _context.Usuarios.Add(new DataAccess.Models.Usuario()
            {
                UserName = usuarioDTO.UserName,
                Nombre = usuarioDTO.Nombre,
                Mail = usuarioDTO.Mail,
                Telefono = usuarioDTO.Telefono,
                Activo = true
            });


        }

        public void DeleteUser(UsuarioDTO usuarioDTO)
        {

            var deleteUser = _context.Usuarios.FirstOrDefault(x => x.UserName == usuarioDTO.UserName && x.Activo)
                ?? throw new UsuarioExceptions("Nombre de usuario inexistente.");

            deleteUser.Activo = false;
            _context.Usuarios.Update(deleteUser);

        }

        public void ModifyUser(UsuarioDTO usuarioDTO)
        {

            var modifyUser = _context.Usuarios.FirstOrDefault(x => x.UserName == usuarioDTO.UserName && x.Activo)
                ?? throw new UsuarioExceptions("Nombre de usuario inexistente.");

            modifyUser.Nombre = usuarioDTO.Nombre;
            modifyUser.Mail = usuarioDTO.Mail;
            modifyUser.Telefono = usuarioDTO.Telefono;
            _context.Usuarios.Update(modifyUser);

        }





    }
}
