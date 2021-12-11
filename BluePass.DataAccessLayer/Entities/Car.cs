using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePass.DataAccessLayer.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
