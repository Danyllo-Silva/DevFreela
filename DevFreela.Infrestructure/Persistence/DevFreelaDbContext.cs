using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrestructure.Persistence
{
   public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descrição de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descrição de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descrição de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Danyllo Silva", "danylloe.silva@outlook.com", new DateTime (1990, 09, 02)),
                new User("Luiz Silva", "luiz.silva@outlook.com", new DateTime (1991, 09, 02)),
                new User("Katty Silva", "katty.silva@outlook.com", new DateTime (1993, 09, 02)),
                new User("Jhany Silva", "jhany.silva@outlook.com", new DateTime (1992, 09, 02))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };

        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get;  set; }
        public List<Skill> Skills { get;  set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
