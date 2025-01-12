using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTO
{
    public class StudentDTO:BaseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }

    }
}
