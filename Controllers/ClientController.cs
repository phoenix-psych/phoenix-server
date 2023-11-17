using AIMSService.Entity;
using AIMSService.Model;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Entity;
using Web.Entity.Context;
using Web.Helper;
using Web.Helper.Enum;
using Web.Model;

namespace Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public ClientController(AppDbContext appDbContext, IMapper mapper)
        {
            _dbContext = appDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("client")]
        public async Task<ActionResult<List<ClientDto>>> GetClient()
        {
            var results = await _dbContext.Clients.ToListAsync();
            return Ok(_mapper.Map<List<ClientDto>>(results));
        }

        [HttpGet]
        [Route("client/{id}")]
        public async Task<ActionResult<ClientDto>> GetClientById(Guid id)
        {
            var result = await _dbContext.Clients.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientDto>(result));
        }

        [HttpPost]
        [Route("client")]
        public async Task<ActionResult> AddClient([FromBody] ClientDto clientDto)
        {
            if (clientDto == null)
            {
                return BadRequest();
            }

            var client = new Client()
            {
                Name = clientDto.Name,
                Dob = clientDto.Dob.Value,
                Email = clientDto.Email,
                Phone = clientDto.Phone,
                Status = ClientStatusEnum.In_Progress
            };

            await _dbContext.Clients.AddAsync(client);
            var result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientDto>(client)
            });
        }


        [HttpPut]
        [Route("client")]
        public async Task<ActionResult> ModifyClient([FromBody] ClientDto ClientDto)
        {
            if (ClientDto == null)
            {
                return BadRequest();
            }

            var client = _mapper.Map<Client>(ClientDto);
            _dbContext.Clients.Update(client);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(new
                {
                    Data = _mapper.Map<ClientDto>(client)
                });
            }

            return Ok(new
            {
                Message = "Update failed!"
            });
        }


        [HttpDelete]
        [Route("client")]
        public async Task<ActionResult> DeleteClient(Guid ClientId)
        {
            var deletedClient = _dbContext.Clients.FirstOrDefault(x => x.Id == ClientId);
            if (deletedClient == null)
            {
                return Ok(new
                {
                    Message = "Client not exist!"
                });
            }
            _dbContext.Clients.Remove(deletedClient);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(new
                {
                    Message = "Delete success!"
                });
            }

            return Ok(new
            {
                Message = "Delete failed!"
            });
        }

    }
}
