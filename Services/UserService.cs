using GestionUsuarios.Data;
using Grpc.Core;
using MassTransit;
using System.Threading.Tasks;
using UserProto;
using Microsoft.EntityFrameworkCore;

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
            var entity= await _context.Users.FirstOrDefaultAsync();
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
            var entity= await _context.Users.FirstOrDefault();d
        }
    }
}