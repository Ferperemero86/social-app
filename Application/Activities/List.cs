using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;


namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> // Query derives from Mediatr IRequest interface
        {

        }

        public class Handler : IRequestHandler<Query, List<Activity>> // We pass the Query class here from above
        {
            private readonly DataContext _context;
            public Handler (DataContext context)
            {
                _context = context;
            }

            public DataContext Context { get; }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activities.ToListAsync();
            }
        }
    }
}