using EducationalResourceAPI.Models;
using EducationalResourceAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace EducationalResourceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationalResourceController : ControllerBase
    {
        private readonly IEducationalResourceService _service;

        public EducationalResourceController(IEducationalResourceService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllResources([FromQuery] int page = 1,
    [FromQuery] int pageSize = 3)
        {
            var resources = await _service.GetAllResourcesAsync(page, pageSize);
            return Ok(resources);
        }


        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetResourceById(string id)
        {
            var resource = await _service.GetResourceByIdAsync(id);
            if (resource == null) return NotFound();
            return Ok(resource);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateResource([FromBody] EducationalResource resource)
        {
            await _service.CreateResourceAsync(resource);
            return CreatedAtAction(nameof(GetResourceById), new { id = resource.Id }, resource);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateResource(string id, [FromBody] EducationalResource resource)
        {
            var existingResource = await _service.GetResourceByIdAsync(id);
            if (existingResource == null) return NotFound();

            await _service.UpdateResourceAsync(id, resource);
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResource(string id)
        {
            var existingResource = await _service.GetResourceByIdAsync(id);
            if (existingResource == null) return NotFound();

            await _service.DeleteResourceAsync(id);
            return NoContent();
        }
    }
}
