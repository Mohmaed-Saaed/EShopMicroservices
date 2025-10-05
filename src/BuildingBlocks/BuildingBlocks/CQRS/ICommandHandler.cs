using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{

        public interface ICommandHandler<in ICommand> : ICommandHandler<ICommand>
        

    {

    }
    public interface ICommandHandler<in ICommand, TResponse> : IRequestHandler<ICommand, TResponse>
        where ICommand : ICommand<TResponse> where TResponse : notnull
    {

    }
}
