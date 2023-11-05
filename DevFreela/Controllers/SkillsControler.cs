using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers
{ 
    [Route("api/skills")]
    public class SkillsControler : ControllerBase
    {
        private readonly ISkillService _skillService;
        public SkillsControler(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var skills = _skillService.GetAll();

            return Ok(skills);
        }
    }
}
