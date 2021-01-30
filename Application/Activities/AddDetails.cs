using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistance;

namespace Application.Activities
{
    public class AddDetails
    {
        public class query : IRequest<Activity>
        {
            public Guid Id { get; set; }


        };
        public class Handler : IRequestHandler<query, Activity>
        {
            private readonly DataContext context;
            public Handler(DataContext context)
            {
                this.context = context;

            }
            public async Task<Activity> Handle(query request, CancellationToken cancellationToken)
            {
                var activity = await context.Activities.FindAsync(request.Id);

                return activity;
            }
        }
    }
}