using Common.DTO;
using Common.Exceptions;
using Contracts.Repositories;
using Contracts.Service;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly COAContext _context;
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioService(COAContext context, IUsuarioRepository usuarioRepository)
        {
            _context = context;
            this.usuarioRepository = usuarioRepository;
        }

        public ResponseDTO GetAllUsers()
        {
            ResponseDTO result = new();
            try
            {
                result.Result = usuarioRepository.GetAllUsers();
                result.Success = true;
            }
            catch (UsuarioExceptions usuarioExceptions)
            {
                result.Success = false;
                result.Message = usuarioExceptions.Message;
            }
            catch
            {
                result.Success = false;
                result.Message = "Ha ocurrido un error, lamentamos lo sucedido.";
            }

            return result;
        }

        public ResponseDTO AddUser(UsuarioDTO usuarioDTO)
        {
            ResponseDTO result = new();
            try
            {
                usuarioRepository.AddUser(usuarioDTO);
                result.Success = true;
                _context.SaveChanges();
            }
            catch (UsuarioExceptions usuarioExceptions)
            {
                result.Success = false;
                result.Message = usuarioExceptions.Message;
            }
            catch
            {
                result.Success = false;
                result.Message = "Ha ocurrido un error, lamentamos lo sucedido.";
            }


            return result;

        }

        public ResponseDTO DeleteUser(UsuarioDTO usuarioDTO)
        {
            ResponseDTO result = new();
            try
            {
                usuarioRepository.DeleteUser(usuarioDTO);
                result.Success = true;
                _context.SaveChanges();
            }
            catch (UsuarioExceptions usuarioExceptions)
            {
                result.Success = false;
                result.Message = usuarioExceptions.Message;
            }
            catch
            {
                result.Success = false;
                result.Message = "Ha ocurrido un error, lamentamos lo sucedido.";
            }

            return result;
        }

        public ResponseDTO ModifyUser(UsuarioDTO usuarioDTO)
        {
            ResponseDTO result = new();
            try
            {
                usuarioRepository.ModifyUser(usuarioDTO);
                result.Success = true;
                _context.SaveChanges();
            }
            catch (UsuarioExceptions usuarioExceptions)
            {
                result.Success = false;
                result.Message = usuarioExceptions.Message;
            }
            catch
            {
                result.Success = false;
                result.Message = "Ha ocurrido un error, lamentamos lo sucedido.";
            }

            return result;
        }
    }
}
