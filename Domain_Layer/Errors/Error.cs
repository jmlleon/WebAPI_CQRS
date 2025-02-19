using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Errors
{
    public sealed record Error(string Code, string Description)
    {
        public static readonly Error None = new(string.Empty, string.Empty);
    }

    public static class StudentErrors
    {
        public static readonly Error NotFoundStudent = new Error(
            "Student.NotFoundStudent", "Student not found");

        public static Error ValidationStudentError(string message) => new Error(
            "Student.StudentValidationError", message);

        public static readonly Error StudentAddError = new Error(
         "Student.StudentAddError", "The Student has not been inserted");

        public static readonly Error StudentDeleteError = new Error(
        "Student.StudentDeleteError", "The Student has not been deleted");

        public static readonly Error StudentUpdateError = new Error(
       "Student.StudentUpdateError", "The Student has not been updated");

        public static readonly Error UnknowError = new Error(
         "Student.UnknownError", "Unknown student error");
    }

    public sealed record CustomError(string Code, string Message)
    {
        
        private static readonly string AddErrorCode = "AddError";
        private static readonly string DeleteErrorCode = "DeleteError";
        private static readonly string UpdateErrorCode = "UpdateError";
        private static readonly string ValidationErrorCode = "ValidationError";
        private static readonly string RecordNotFoundCode = "RecordNotFound";
        


        public static readonly CustomError None = new(string.Empty, string.Empty);


        public static CustomError AddError(string message) => new(AddErrorCode, message);
        public static CustomError DeleteError(string message)=> new (DeleteErrorCode, message);


        public static CustomError UpdateError(string message)
        {
            return new CustomError(UpdateErrorCode, message);
        }

        public static CustomError RecordNotFound(string message)
        {
            return new CustomError(RecordNotFoundCode, message);
        }
        public static CustomError ValidationError(string message)
        {
            return new CustomError(ValidationErrorCode, message);
        }
    }


   


}
