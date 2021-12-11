using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePass.DataAccessLayer.DTO.UserDTO
{
    public class ListUserDto
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
        public int Pin { get; set; }
        public int UserId { get; set; }
    }
}
