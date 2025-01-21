using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Model
{
    public sealed class UpdateStudentModel(Guid id,string name, string lastname, int age):BaseModel
    {
        public Guid Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastname;
        public int Age { get; set; } = age;
    }
}
