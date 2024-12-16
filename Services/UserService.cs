using GestionUsuarios.Data;
using Grpc.Core;
using MassTransit;
using System.Threading.Tasks;
using UserProto;
using Microsoft.EntityFrameworkCore;
using GestionUsuarios.Models;

namespace GestionUsuarios.Services
{
    public class UserService : UserProto.UserService.UserServiceBase
    {
        private readonly UserDbContext _context;
        private readonly IBus _bus;
        public UserService(UserDbContext context,IBus bus)
        {
            _context=context;
            _bus=bus;
        }
        public override async Task<UserResponse> profile(GetByRUT request, ServerCallContext context)
        {
            var entity= await _context.Users.FirstOrDefaultAsync(u=>u.RUT==request.RUT);
            if(entity==null) throw new RpcException(new Status(StatusCode.NotFound,"Perfil no encontrado"));
            return new UserResponse
            {
                Name=entity.Name,
                FirstLastName=entity.FirstLastName,
                SecondLastName=entity.SecondLastName,
                RUT=entity.RUT,
                Email=entity.Email,
                CareerId=entity.CareerId
            };
        }

        public override async Task<Empty> updateProfile(UpdateUser request, ServerCallContext context)
        {
            var entity= await _context.Users.FirstOrDefaultAsync(u=>u.RUT==request.RUT);
            if(entity==null) throw new RpcException(new Status(StatusCode.NotFound,"Perfil no encontrado"));
            entity.Name=request.Name;
            entity.FirstLastName=request.FirstLastName;
            entity.SecondLastName=request.SecondLastName;
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
            return new Empty{};
        }

        public override async Task<ValidateResponse> UpdatePassword(ValidateRequest request,ServerCallContext context)
        {
            var entity= await _context.Users.FirstOrDefault(u=>u.Email==request.email);
            if(entity==null) return new ValidateResponse {is_valid=false};
            entity.Password=BCrypt.Net.BCrypt.HashPassword(request.password);
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
            return new ValidateResponse
            {
                is_valid=true
            };
        }

        public override async Task<Empty> CreateUser(CreateUserRequest request,ServerCallContext context)
        {
            if(request.Password!=request.ConfirmPassword||await _context.Users.FirstOrDefaultAsync(u=> u.RUT==request.RUT)!=null||await _context.Users.FirstOrDefaultAsync(u=> u.Email==request.Email)!=null)
            {
                return new Empty {};
            }
            var entity = new UserEntity
            {
                Name=request.Name,
                FirstLastName=request.FirstLastName,
                SecondLastName=request.SecondLastName,
                RUT=request.RUT,
                Email=request.Email,
                HashedPassword=BCrypt.Net.BCrypt.HashPassword(request.Password),
                CareerId=request.CareerId
            };
            _context.Users.Add(entity);
            await _context.SaveChangesAsync();
            return new Empty{};
        }

        public override async Task<Empty> GetMyProgress(Empty request,ServerCallContext context)
        {
            
        }

        public override async Task<Empty> PatchMyProgress(Empty request,ServerCallContext context)
        {
            
        }
    }
}