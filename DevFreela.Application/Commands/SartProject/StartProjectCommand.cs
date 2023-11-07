using MediatR;


namespace DevFreela.Application.Commands.SartProject
{
   public class StartProjectCommand : IRequest<Unit>
    {
        public StartProjectCommand(int id)
        {
            Id = id;
        }

        public int Id { get;  set; }
    }
}

