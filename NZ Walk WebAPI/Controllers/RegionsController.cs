using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZ_Walk_WebAPI.CustomActionFilter;
using NZ_Walk_WebAPI.Data;
using NZ_Walk_WebAPI.Models.Domain_Models;
using NZ_Walk_WebAPI.Models.DTO;
using NZ_Walk_WebAPI.Repository;

namespace NZ_Walk_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regions = await regionRepository.GetAllAsync();
            return Ok(mapper.Map<List<RegionDTO>>(regions));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var region = await regionRepository.GetByIdAsync(id);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RegionDTO>(region));
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDTO addRegionRequestDTO)
        {
                var region = await regionRepository.CreateAsync(mapper.Map<Region>(addRegionRequestDTO));
                return CreatedAtAction(nameof(GetById), new { id = region.Id }, mapper.Map<RegionDTO>(region));
        }

        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDTO updateRegionRequestDTO)
        {
            var region = await regionRepository.UpdateAsync(id, mapper.Map<Region>(updateRegionRequestDTO));
            if (region == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RegionDTO>(region));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var region = await regionRepository.DeleteAsync(id);
            if (region == null)
                return NotFound();
            return Ok(mapper.Map<RegionDTO>(region));
        }

    }
}
