﻿using Domain_Layer.Errors;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Interfaces
{
    public interface IQuery<TResponse>:IRequest<CustomResult<TResponse>>
    {
    }
}
