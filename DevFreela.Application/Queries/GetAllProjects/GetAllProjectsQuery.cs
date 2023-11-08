using DevFreela.Application.InputModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetAllProjects
{
    public class GetProjectById : IRequest<List<ProjectViewModel>>
    {
        public GetProjectById(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
