using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain_Layer.Model
{
    public class StudentQueryModel : BaseModel
    {

        public string Id { get; set; }
        public string Name { get; set; } 
        public string LastName { get; set; } 
        public int Age { get; set; }

        public StudentQueryModel()
        {
            
        }

        /* public StudentQueryModel(string id, string name, string lastname, int age)
         {

             Id = id;
             Name = name;
             LastName = lastname;
             Age = age;

         }*/



        /*public StudentQueryModel()
        {
            
        }*/



    }
}
