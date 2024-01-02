using AIMSService.Entity;
using AIMSService.Helper.Enum;
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
            var data = results.Select(x => new ClientDto
            {
                Id = x.Id.ToString(),
                Dob = x.Dob,
                Name = x.Name,
                Email = x.Email,
                Phone = x.Phone,
                Service = x.Service,
                ServiceName = x.Service != null ? ((AssessorServiceEnum)x.Service).ToString().Replace('_', ' ') : string.Empty,
                Status = x.Status != null ? x.Status?.ToString().Replace('_', ' ') : string.Empty,

            });

            return Ok(data);
        }

        [HttpGet]
        [Route("client/art/{id}")]
        public async Task<ActionResult<ClientARTDetailDto>> GetClientArtById(Guid id)
        {
            var result = await _dbContext.ClientARTDetails.FirstOrDefaultAsync(x => x.ClientId == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientARTDetailDto>(result));
        }

        [HttpGet]
        [Route("client/ctopp/{id}")]
        public async Task<ActionResult<ClientCTOPPDetailDto>> GetClientCTOPPById(Guid id)
        {
            var result = await _dbContext.ClientCTOPPDetails.FirstOrDefaultAsync(x => x.ClientId == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientCTOPPDetailDto>(result));
        }


        [HttpGet]
        [Route("client/goart/{id}")]
        public async Task<ActionResult<ClientGOARTDetailDto>> GetClientGOARTById(Guid id)
        {
            var result = await _dbContext.ClientGOARTDetails.FirstOrDefaultAsync(x => x.ClientId == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientGOARTDetailDto>(result));
        }

        [HttpGet]
        [Route("client/tomal/{id}")]
        public async Task<ActionResult<ClientTOMALDetailDto>> GetClientTOMALById(Guid id)
        {
            var result = await _dbContext.ClientTOMALDetails.FirstOrDefaultAsync(x => x.ClientId == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientTOMALDetailDto>(result));
        }

        [HttpGet]
        [Route("client/towre/{id}")]
        public async Task<ActionResult<ClientTOWREDetailDto>> GetClientTOWREById(Guid id)
        {
            var result = await _dbContext.ClientTOWREDetails.FirstOrDefaultAsync(x => x.ClientId == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientTOWREDetailDto>(result));
        }

        [HttpGet]
        [Route("client/wrat/{id}")]
        public async Task<ActionResult<ClientWRATDetailDto>> GetClientWRATById(Guid id)
        {
            var result = await _dbContext.ClientWRATDetails.FirstOrDefaultAsync(x => x.ClientId == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientWRATDetailDto>(result));
        }

        [HttpGet]
        [Route("client/writ/{id}")]
        public async Task<ActionResult<ClientWRITDetailDto>> GetClientWRITById(Guid id)
        {
            var result = await _dbContext.ClientWRITDetails.FirstOrDefaultAsync(x => x.ClientId == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientWRITDetailDto>(result));
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
                Service = clientDto.Service,
                Status = ClientStatusEnum.In_Progress
            };

            await _dbContext.Clients.AddAsync(client);
            var result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientDto>(client)
            });
        }


        [HttpPost]
        [Route("client/art")]
        public async Task<ActionResult> AddClientArt([FromBody] ClientARTDetailDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var clientArt = _mapper.Map<ClientARTDetail>(dto);
            _dbContext.ClientARTDetails.RemoveRange(_dbContext.ClientARTDetails.Where(x => x.ClientId == dto.ClientId));
            var result = await _dbContext.SaveChangesAsync();


            await _dbContext.ClientARTDetails.AddAsync(clientArt);
            result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientARTDetailDto>(clientArt)
            });
        }


        [HttpPost]
        [Route("client/ctopp")]
        public async Task<ActionResult> AddClientCTOPP([FromBody] ClientCTOPPDetailDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var clientArt = _mapper.Map<ClientCTOPPDetail>(dto);
            _dbContext.ClientCTOPPDetails.RemoveRange(_dbContext.ClientCTOPPDetails.Where(x=>x.ClientId == dto.ClientId));
            var result = await _dbContext.SaveChangesAsync();

            await _dbContext.ClientCTOPPDetails.AddAsync(clientArt);
            result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientCTOPPDetailDto>(clientArt)
            });
        }

        [HttpPost]
        [Route("client/goart")]
        public async Task<ActionResult> AddClientGOART([FromBody] ClientGOARTDetailDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var clientArt = _mapper.Map<ClientGOARTDetail>(dto);
            _dbContext.ClientGOARTDetails.RemoveRange(_dbContext.ClientGOARTDetails.Where(x => x.ClientId == dto.ClientId));
            var result = await _dbContext.SaveChangesAsync();

            await _dbContext.ClientGOARTDetails.AddAsync(clientArt);
            result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientGOARTDetailDto>(clientArt)
            });
        }

        [HttpPost]
        [Route("client/tomal")]
        public async Task<ActionResult> AddClientTOMAL([FromBody] ClientTOMALDetailDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var clientArt = _mapper.Map<ClientTOMALDetail>(dto);
            _dbContext.ClientTOMALDetails.RemoveRange(_dbContext.ClientTOMALDetails.Where(x => x.ClientId == dto.ClientId));
            var result = await _dbContext.SaveChangesAsync();

            await _dbContext.ClientTOMALDetails.AddAsync(clientArt);
            result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientTOMALDetailDto>(clientArt)
            });
        }

        [HttpPost]
        [Route("client/towre")]
        public async Task<ActionResult> AddClientTOWRE([FromBody] ClientTOWREDetailDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var clientArt = _mapper.Map<ClientTOWREDetail>(dto);
            _dbContext.ClientTOWREDetails.RemoveRange(_dbContext.ClientTOWREDetails.Where(x => x.ClientId == dto.ClientId));
            var result = await _dbContext.SaveChangesAsync();

            await _dbContext.ClientTOWREDetails.AddAsync(clientArt);
            result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientTOWREDetailDto>(clientArt)
            });
        }

        [HttpPost]
        [Route("client/wrat")]
        public async Task<ActionResult> AddClientWRAT([FromBody] ClientWRATDetailDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var clientArt = _mapper.Map<ClientWRATDetail>(dto);
            _dbContext.ClientWRATDetails.RemoveRange(_dbContext.ClientWRATDetails.Where(x => x.ClientId == dto.ClientId));
            var result = await _dbContext.SaveChangesAsync();

            await _dbContext.ClientWRATDetails.AddAsync(clientArt);
            result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientWRATDetailDto>(clientArt)
            });
        }

        [HttpPost]
        [Route("client/writ")]
        public async Task<ActionResult> AddClientWRIT([FromBody] ClientWRITDetailDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var clientArt = _mapper.Map<ClientWRITDetail>(dto);
            _dbContext.ClientWRITDetails.RemoveRange(_dbContext.ClientWRITDetails.Where(x => x.ClientId == dto.ClientId));
            var result = await _dbContext.SaveChangesAsync();

            await _dbContext.ClientWRITDetails.AddAsync(clientArt);
            result = await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Data = _mapper.Map<ClientWRITDetailDto>(clientArt)
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
