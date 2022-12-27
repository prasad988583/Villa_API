using Microsoft.AspNetCore.Mvc;
using Villa_API.Model;
using Villa_API.Data;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Villa_API.Controllers
{
    [Route("api/Villa_API_")]
    [ApiController]
    public class Villa_API_Controller : ControllerBase
     
    {
        protected APIResponse _response;
        private readonly Applicaitondbcontext _db;

        private readonly IMapper _mapper;

        public Villa_API_Controller(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Villa_API_Controller(Applicaitondbcontext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            this._response = new();
        }
        //private readonly ILogger<Villa_API_Controller> logger;

        //public Villa_API_Controller(ILogger<Villa_API_Controller> logger) => this.logger = logger;

        [HttpGet]
        public async Task <ActionResult<IEnumerable<Villa_DTO>>> GetVillas()
        {
            //logger.LogInformation("Getting All Villas");
            return Ok(await _db.Villas.ToListAsync());
        }

        [HttpGet("id")]
        public async Task<ActionResult<Villa_DTO>> GetVillas(int id)
        {
            if (id == 0)
            {
              
                return BadRequest();
            }
            if (id >= 10)
            {
                return NotFound();
            }
            //logger.LogError("Getting Villas With the Id's");
            return Ok(await _db.Villas.FirstOrDefaultAsync(u => u.Id == id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Villa_DTO> CreateVilla([FromBody] Villa_DTO_Create villa_DTO)
        {
            if (villa_DTO == null)
            {
                return BadRequest(villa_DTO);
            }
            //if (villa_DTO.Id <= 0)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            //}
            if (_db.Villas.FirstOrDefault(u => u.Name.ToLower() == villa_DTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("", "Villa Already Exist");
                return BadRequest(ModelState);
            }
            Villa_DTO model = new()
            {
                Name=villa_DTO.Name,
                Description=villa_DTO.Description
            };
            _db.Villas.Add(model);

            _db.SaveChanges();

            return CreatedAtRoute("GetVilla", new { id = model.Id }, model);
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = _db.Villas.FirstOrDefault(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            _db.Villas.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpPut("id")]
        public IActionResult UpdateVilla(int Id, [FromBody] Villa_DTO_Update villaDTO)
        {
            if (Id == 0)
            {
                return BadRequest();
            }
            if (villaDTO == null)
            {
                return NotFound();
            }
            //var villa = _db.Villas.FirstOrDefault(u => u.Id == Id);
            //villa.Name = villaDTO.Name;
            //villa.Description = villaDTO.Description;
            Villa_DTO model = new ()
            {
                Id = villaDTO.Id,
                Name = villaDTO.Name,
                Description = villaDTO.Description
            };
            _db.Villas.Update(model);
            _db.SaveChanges();

            return NoContent();
        }


        [HttpPatch("id")]
        public IActionResult UpdatePartialVilla(int Id, JsonPatchDocument<Villa_DTO> patchDTO)
        {
            if (Id == 0)
            {
                return BadRequest();
            }
            if (patchDTO == null)
            {
                return NotFound();
            }
           var villa = _db.Villas.AsNoTracking().FirstOrDefault(u => u.Id == Id);

           var villa_DTO = new Villa_DTO()
            {
                Id = villa.Id,
                Name=villa.Name,
                Description=villa.Description
            };

            patchDTO.ApplyTo(villa_DTO, ModelState);

            Villa_DTO model = new()
            {
                Id = villa_DTO.Id,
                Name = villa_DTO.Name,
                Description = villa_DTO.Description
            };
            _db.Villas.Update(model);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return NoContent();
            }
    }

} 