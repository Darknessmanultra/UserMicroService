using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionUsuarios.Models
{
    public class UserEntity
    {
        public string Name {get; set;}
        public string FirstLastName {get; set;}
        public string SecondLastName {get; set;}
        public string RUT {get; set;}
        public string Email {get; set;}
        public string HashedPassword {get; set;}
        public bool IsEnabled {get; set;}
        public int CareerId {get; set;}
        public int RoleId {get; set;}
    }
}