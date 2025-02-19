using Domain_Layer.Errors;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Interfaces
{
    public interface ICommandHandler<TCommand>:IRequestHandler<TCommand,Result> where TCommand : ICommand
    {
    }
    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, CustomResult<TResponse>> where TCommand : ICommand<TResponse>
    {
    }
}

