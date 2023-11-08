using DevFreela.Application.Commands.UpdateProject;
using DevFreela.Infrestructure.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommandHandler : IRequestHandler<FinishProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        public FinishProjectCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(FinishProjectCommand request, CancellationToken cancellationToke)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);

            project.Finish();
           await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
