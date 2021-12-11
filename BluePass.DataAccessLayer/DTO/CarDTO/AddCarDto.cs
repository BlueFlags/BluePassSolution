using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePass.DataAccessLayer.DTO.CarDTO
{
    public class AddCarDto
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public int UserId { get; set; }
    }
}
