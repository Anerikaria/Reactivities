using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Delete
    {
        public class Comamnd : IRequest
        {
            public Guid Id {get; set;}
        }

        public class Handler : IRequestHandler<Comamnd>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task Handle(Comamnd request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Id);

                 _context.Remove(activity);

                await _context.SaveChangesAsync();
            }
        }
    }
}