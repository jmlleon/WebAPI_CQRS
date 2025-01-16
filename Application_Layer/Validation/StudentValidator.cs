using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Validation
{
    internal sealed class StudentValidator
    {

        public static ValidationResult ValidateStudent(Student student) {

            List<string> errors = [];

            if (student == null) { 
                errors.Add("The Student object is null");
            }

            if (student!=null && String.IsNullOrEmpty(student.Name)) {            
                errors.Add("The Student Name can't be empty");            
            }

            return errors.Count == 0 ? ValidationResult.Success! : new ValidationResult(String.Join(",", errors)); 
        
        }

    }
}
