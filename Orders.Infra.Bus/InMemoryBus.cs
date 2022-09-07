using MediatR;
using Orders.Domain.Core.Bus;
using Orders.Domain.Core.Commands;
using System.Threading.Tasks;

namespace Orders.Infra.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T Command) where T : Command
        {
            return _mediator.Send(Command);
        }
    }
}
