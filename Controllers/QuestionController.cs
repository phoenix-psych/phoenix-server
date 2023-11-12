using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Entity.Context;
using Web.Entity;
using Web.Helper.Enum;
using Web.Model;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Serialization;

namespace Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public QuestionController(AppDbContext appDbContext, IMapper mapper)
        {
            _dbContext = appDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("question")]
        public async Task<ActionResult<List<QuestionDto>>> GetQuestion()
        {
            var results = await _dbContext.Questions.ToListAsync();
            var result = _mapper.Map<List<QuestionDto>>(results);
            foreach (var item in result)
            {
                item.QuestionType = item.Type.ToString();
                item.QuestionGroup = item.Group.ToString();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("question/{questionId}")]
        public async Task<ActionResult<QuestionDto>> GetQuestionById(Guid questionId)
        {
            var result = await _dbContext.Questions.FirstOrDefaultAsync(x => x.Id == questionId);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<QuestionDto>(result));
        }

        [HttpPost]
        [Route("question")]
        public async Task<ActionResult> AddQuestion([FromBody] QuestionDto questionDto)
        {
            if (questionDto == null)
            {
                return BadRequest();
            }

            questionDto.Group = (QuestionGroupEnum)Convert.ToByte(questionDto.QuestionGroup);
            questionDto.Type = (QuestionTypeEnum)Convert.ToByte(questionDto.QuestionType);
            var question = _mapper.Map<Questions>(questionDto);
            await _dbContext.Questions.AddAsync(question);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(new
                {
                    Data = _mapper.Map<QuestionDto>(question)
                });
            }

            return Ok(new
            {
                Message = "Create failed!"
            });
        }

        [HttpPut]
        [Route("question")]
        public async Task<ActionResult> ModifyQuestion([FromBody] QuestionDto questionDto)
        {
            if (questionDto == null)
            {
                return BadRequest();
            }

            var question = _mapper.Map<Questions>(questionDto);
            _dbContext.Questions.Update(question);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(new
                {
                    Data = _mapper.Map<QuestionDto>(question)
                });
            }

            return Ok(new
            {
                Message = "Update failed!"
            });
        }


        [HttpDelete]
        [Route("question")]
        public async Task<ActionResult> DeleteQuestion(Guid questionId)
        {
            var deletedQuestion = _dbContext.Questions.FirstOrDefault(x => x.Id == questionId);
            if (deletedQuestion == null)
            {
                return Ok(new
                {
                    Message = "Question not exist!"
                });
            }
            _dbContext.Questions.Remove(deletedQuestion);
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

        [HttpGet]
        [Route("questionanswer")]
        public async Task<ActionResult> GetQuestionJson()
        {
            string allText = System.IO.File.ReadAllText(@"E:\Phoenix Repo\phoenix-server\Model\data.json");
            return Ok(allText);
        }

        private string GetData()
        {
            var formFields = new List<NgFormFieldDto>()
            {
                new NgFormFieldDto()
                {
                    ControlType = "label",
                    Order = 1,
                    Text = "First Name:"
                },
                new NgFormFieldDto()
                {
                    ControlType = "textinput",
                    Key = "firstName",
                    Required = true,
                    Order = 2
                },
                new NgFormFieldDto()
                {
                    ControlType = "label",
                    Order = 3,
                    Text = "Last Name:"
                },
                new NgFormFieldDto()
                {
                    ControlType = "textinput",
                    Key = "lastName",
                    Required = true,
                    Order = 4
                },
                new NgFormFieldDto()
                {
                    ControlType = "label",
                    Order = 5,
                    Text = "Email address:"
                },
                new NgFormFieldDto()
                {
                    ControlType = "textinput",
                    Key = "emailAddress",
                    Label = "Email",
                    Order = 6
                },
                new NgFormFieldDto()
                {
                    ControlType = "label",
                    Order = 7,
                    Text = "Country:"
                },
                new NgFormFieldDto()
                {
                    ControlType = "dropdown",
                    Key = "country",
                    Order = 8,
                    Options = new List<NgOptionDto>()
                    {
                        new NgOptionDto() { Key = "IN", Value = "India" },
                        new NgOptionDto() { Key = "USA", Value = "United States of America" },
                        new NgOptionDto() { Key = "UK", Value = "United Kingdom" }
                    }
                },
                new NgFormFieldDto()
                {
                    ControlType = "checkbox",
                    Key = "resident",
                    Label = "I'm a resident",
                    Order = 9
                }
            };

            var newJsonObject = JsonConvert.SerializeObject(formFields, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

            return newJsonObject;
        }

        [HttpGet]
        [Route("questionjson")]
        public async Task<ActionResult> GetAnswer()
        {
            var allText = GetData();
            return Ok(allText);
        }
    }
}
