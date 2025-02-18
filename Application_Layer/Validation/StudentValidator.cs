using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Validation
{
    public sealed class StudentValidator
    {

        public static ValidationResult ValidateStudent(StudentModel student)
        {
            List<string> errors = CustomValidation(student);

            return errors.Count == 0 ? ValidationResult.Success! : new ValidationResult(String.Join(",", errors));

        }

        public static ValidationResult ValidateStudentOnUpdate(Guid Id, UpdateStudentModel student)
        {
            List<string> errors = CustomValidation(new StudentModel(student.Id,student.Name, student.LastName, student.Age));

            if (student is not null && Id != student.Id) {
                errors.Add("The Student Id not Math");            
            }

            return errors.Count == 0 ? ValidationResult.Success! : new ValidationResult(String.Join(",", errors));

        }

        private static List<string> CustomValidation(StudentModel student)
        {
            List<string> errors = [];

            if (student is null)
            {
                errors.Add("The Student object is null");
            }

            if (student is not null && String.IsNullOrEmpty(student.Name))
            {
                errors.Add("The Student Name can't be empty");
            }

            return errors;
        }
    }
}
