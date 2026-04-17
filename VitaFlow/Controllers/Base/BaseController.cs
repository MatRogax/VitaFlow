using Microsoft.AspNetCore.Mvc;
using projeto_carlos.Common.Entities;
using VitaFlow.Common.Interfaces;

namespace VitaFlow.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<TEntity> : ControllerBase
        where TEntity : BaseEntity
    {
        protected readonly IServiceBase<TEntity> _service;

        protected BaseController(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<ActionResult<List<TEntity>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> GetById(Guid id)
        {
            var result = await _service.GetByIdAsync(id);

            if (result == null)
                return NotFound(new { success = false, mensagem = "Registro não encontrado." });

            return Ok(result);
        }

        [HttpPost]
        public virtual async Task<ActionResult<TEntity>> Create([FromBody] TEntity entity)
        {
            var result = await _service.CreateAsync(entity);

            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update([FromBody] TEntity entity)
        {
            var updated = await _service.UpdateAsync(entity);

            if (!updated)
                return NotFound(new { success = false, mensagem = "Registro não encontrado." });

            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _service.DeleteAsync(id);

            if (!deleted)
                return NotFound(new { success = false, mensagem = "Registro não encontrado." });

            return NoContent();
        }
    }
}