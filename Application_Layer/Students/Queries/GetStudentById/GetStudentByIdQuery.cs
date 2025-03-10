﻿using Application_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Queries.GetStudentById
{
    public sealed record GetStudentByIdQuery(Guid Id):IQuery<StudentResponse>
    {
    }

    public sealed record StudentResponse(Guid Id, string Name, string LastName, int Age) 
    {        
    }
}
