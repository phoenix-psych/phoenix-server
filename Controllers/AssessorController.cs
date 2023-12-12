using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Entity.Context;
using Web.Entity;
using Web.Model;
using Microsoft.EntityFrameworkCore;
using Azure.Storage.Blobs;
using Azure.Core;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Dynamic;
using System.Reflection;
using Microsoft.Data.SqlClient.Server;
using System;
using AIMSService.Entity;
using AIMSService.Model;

namespace Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class AssessorController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public AssessorController(AppDbContext appDbContext, IMapper mapper, IConfiguration configuration)
        {
            _dbContext = appDbContext;
            _mapper = mapper;
            _configuration = configuration;
        }

        private string GetUserIdHeader()
        {
            var headers = Request.Headers;
            string userId = "";
            if (headers.ContainsKey("userid"))
            {
                userId = headers.FirstOrDefault(x => x.Key == "userid").Value.First();
            }

            return userId;
        }

        [HttpGet]
        [Route("assessor/profile")]
        public async Task<ActionResult<List<AssessorProfileDto>>> GetAssessor()
        {
            var results = await _dbContext.AssessorProfiles.ToListAsync();
            return Ok(_mapper.Map<List<AssessorProfileDto>>(results));
        }

        [HttpGet]
        [Route("assessor/profile/{id}")]
        public async Task<ActionResult<AssessorProfileDto>> GetAssessorById(Guid id)
        {
            var result = await _dbContext.AssessorProfiles.FirstOrDefaultAsync(x => x.UserId == id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AssessorProfileDto>(result));
        }

        [HttpGet]
        [Route("assessor/answer")]
        public async Task<ActionResult<AssessorProfileDto>> GetAssessorAnswer([FromQuery] int page, [FromHeader] string userId)
        {
            QuestionAnswersDto answer = new QuestionAnswersDto();
            var result = _dbContext.AssessorAnswers.Where(x => x.UserId == Guid.Parse(userId) && x.Page == page);
            if (result.Any())
            {
                foreach (var r in result)
                {
                    if (!string.IsNullOrEmpty(r.Answer))
                    {
                        PropertyInfo propertyInfo = answer.GetType().GetProperties().FirstOrDefault(x => x.Name == $"Answer{r.Number}");
                        if (propertyInfo != null)
                        {
                            propertyInfo.SetValue(answer, r.Answer);
                        }
                    }
                }
            }

            return Ok(answer);
        }


        [HttpGet]
        [Route("assessor/misc")]
        public async Task<ActionResult<CToppSubTest>> GetCToppScore([FromQuery] string type, [FromQuery] int score, [FromQuery] int year, [FromQuery] int month, [FromHeader] string userId)
        {
            var result = new CToppSubTest();
            List<CTOPPMaster> data = new List<CTOPPMaster>();

            switch (type)
            {
                case "EL":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.ElisionTo >= score && x.ElisionFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";

                    }
                    break;
                case "BW":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.BlendingWordsTo >= score && x.BlendingWordsFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";
                    }
                    break;
                case "PI":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.PhonemeIsolationTo >= score && x.PhonemeIsolationFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";
                    }
                    break;
                case "MD":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.MemoryForDigitsTo >= score && x.MemoryForDigitsFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";

                    }
                    break;
                case "NR":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.NonwordRepetitionTo >= score && x.NonwordRepetitionFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";

                    }
                    break;
                case "RD":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.RapidDigitNamingTo >= score && x.RapidDigitNamingFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";

                    }
                    break;
                case "RL":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.RapidLetterNamingTo >= score && x.RapidLetterNamingFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";

                    }
                    break;
                case "BN":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.BlendingNonwordsTo >= score && x.BlendingNonwordsFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";

                    }
                    break;
                case "SN":
                    data = _dbContext.CTOPPMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear) && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (x.SegmentingNonwordsTo >= score && x.SegmentingNonwordsFrom <= score)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.ScaledScore;
                        result.PercentageRank = data.FirstOrDefault()?.PercentageRankFrom != data.FirstOrDefault()?.PercentageRankTo ? $"{data.FirstOrDefault()?.PercentageRankFrom}-{data.FirstOrDefault()?.PercentageRankTo}" : $"{data.FirstOrDefault()?.PercentageRankFrom}";

                    }
                    break;
                default:
                    break;
            }


            return Ok(result);
        }


        [HttpGet]
        [Route("assessor/misc/cmp")]
        public async Task<ActionResult<CToppCoposite>> GetCToppComposite([FromQuery] double ci, [FromQuery] int paSum, [FromQuery] int pmSum, [FromQuery] int rsnSum, [FromQuery] int apaSum)
        {
            var result = new CToppCoposite();
            var descTerms = _dbContext.CTOPPDescriptiveTerms.ToList();
            if (paSum > 0)
            {
                var data = _dbContext.CTOPPCompositeMasters.Where(x => x.SumOf3 == paSum).ToList();
                if (data.Any())
                {
                    var compScore = data.FirstOrDefault().CompositeScore;
                    var div = 4 * ci;
                    result.PAScore = compScore;
                    result.PARank = data.FirstOrDefault().PercentileRank;
                    result.PACI = $"{Math.Round(compScore.Value - div)} - {Math.Round(compScore.Value + div)}";
                    result.PADesc = descTerms.FirstOrDefault(x => (x.CompositeScoreFrom == 0 || x.CompositeScoreFrom <= compScore) && (x.CompositeScoreTo == 0 || compScore <= x.CompositeScoreTo))?.DescriptiveTerm;
                }
            }

            if (paSum > 0)
            {
                var data = _dbContext.CTOPPCompositeMasters.Where(x => x.SumOf2 == pmSum).ToList();
                if (data.Any())
                {
                    var compScore = data.FirstOrDefault().CompositeScore;
                    var div = 6 * ci;
                    result.PMScore = compScore;
                    result.PMRank = data.FirstOrDefault().PercentileRank;
                    result.PMCI = $"{Math.Round(compScore.Value - div)} - {Math.Round(compScore.Value + div)}";
                    result.PMDesc = descTerms.FirstOrDefault(x => (x.CompositeScoreFrom == 0 || x.CompositeScoreFrom <= compScore) && (x.CompositeScoreTo == 0 || compScore <= x.CompositeScoreTo))?.DescriptiveTerm;
                }
            }

            if (rsnSum > 0)
            {
                var data = _dbContext.CTOPPCompositeMasters.Where(x => x.SumOf2 == rsnSum).ToList();
                if (data.Any())
                {
                    var compScore = data.FirstOrDefault().CompositeScore;
                    var div = 4 * ci;
                    result.RSNScore = compScore;
                    result.RSNRank = data.FirstOrDefault().PercentileRank;
                    result.RSNCI = $"{Math.Round(compScore.Value - div)} - {Math.Round(compScore.Value + div)}";
                    result.RSNDesc = descTerms.FirstOrDefault(x => (x.CompositeScoreFrom == 0 || x.CompositeScoreFrom <= compScore) && (x.CompositeScoreTo == 0 || compScore <= x.CompositeScoreTo))?.DescriptiveTerm;
                }
            }

            if (apaSum > 0)
            {
                var data = _dbContext.CTOPPCompositeMasters.Where(x => x.SumOf2 == apaSum).ToList();
                if (data.Any())
                {
                    var compScore = data.FirstOrDefault().CompositeScore;
                    var div = 4 * ci;
                    result.APAScore = compScore;
                    result.APARank = data.FirstOrDefault().PercentileRank;
                    result.APACI = $"{Math.Round(compScore.Value - div)} - {Math.Round(compScore.Value + div)}";
                    result.APADesc = descTerms.FirstOrDefault(x => (x.CompositeScoreFrom == 0 || x.CompositeScoreFrom <= compScore) && (x.CompositeScoreTo == 0 || compScore <= x.CompositeScoreTo))?.DescriptiveTerm;
                }
            }

            return Ok(result);
        }



        [HttpGet]
        [Route("assessor/tomal")]
        public async Task<ActionResult<TomalSubTestDto>> GetTomalScore([FromQuery] string type, [FromQuery] int score, [FromQuery] int year, [FromQuery] int month)
        {
            var result = new TomalSubTestDto();
            List<TOMALMaster> data = new List<TOMALMaster>();

            switch (type)
            {
                case "mfs":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.MFS_FROM && score <= x.MFS_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "fm":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.FM_FROM && score <= x.FM_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "wsr":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.WSR_FROM && score <= x.WSR_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "avm":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.AVM_FROM && score <= x.AVM_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "or":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.OR_FROM && score <= x.OR_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "vsm":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.VSM_FROM && score <= x.VSM_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "pr":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.PR_FROM && score <= x.PR_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "mfl":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.MFL_FROM && score <= x.MFLTO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "of":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.DF_FROM && score <= x.DF_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "vsr":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.VSR_FROM && score <= x.VSR_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "lf":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.LF_FROM && score <= x.LF_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "ml":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.MI_FROM && score <= x.MI_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "db":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.DB_FROM && score <= x.DB_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "lb":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.LB_FROM && score <= x.LB_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "mfsd":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.MFSD_FROM && score <= x.MFSD_TO)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;
                case "wsrd":
                    data = _dbContext.TOMALMasters.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                            && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                            && (score >= x.WSRD && score <= x.WSRD)).ToList();
                    if (data.Any())
                    {
                        result.ScaleScore = data.FirstOrDefault()?.Scaled_Score;
                        result.PercentageRank = data.FirstOrDefault()?.ile_Rank;

                    }
                    break;

                default:
                    break;
            }


            return Ok(result);
        }



        [HttpGet]
        [Route("assessor/writ")]
        public async Task<ActionResult<WRITSubtestDto>> GetWritScore([FromQuery] string type, [FromQuery] int score, [FromQuery] int year, [FromQuery] int month)
        {
            var result = new WRITSubtestDto();
            var data = _dbContext.WRITSubtests.FirstOrDefault(x => (year >= x.AGE_YEAR_FROM && year <= x.AGE_YEAR_TO)
                                                           && (month >= x.AGE_MONTH_FROM && month <= x.AGE_MONTH_TO)
                                                           && (score == x.Raw_Scores));
            if (data != null)
            {
                if (type == "va")
                {
                    result.StandardScore = Convert.ToInt32(data.Verbal_Analogies_Std_Scores.Value);
                }

                if (type == "vc")
                {
                    result.StandardScore = Convert.ToInt32(data.Vocabulary_Standard_Scores.Value);
                }

                if (type == "ma")
                {
                    result.StandardScore = Convert.ToInt32(data.Matrices_Standard_Scores.Value);
                }

                if (type == "di")
                {
                    result.StandardScore = Convert.ToInt32(data.Diamonds_Standard_scores.Value);
                }

            }

            return Ok(result);
        }


        [HttpGet]
        [Route("assessor/writ/iq")]
        public async Task<ActionResult<WRITIQDto>> GetWritIQ([FromQuery] string type, [FromQuery] int score, [FromQuery] int ci)
        {
            var result = new WRITIQDto();
            if (type == "verbal")
            {
                var data = _dbContext.WRITVerbals.FirstOrDefault(x => (score >= x.SUM_OF_VERBAL_STD_SCORES_FROM && score <= x.SUM_OF_VERBAL_STD_SCORES_TO));
                result.IQ = data.IQ_SCORES_TO != data.IQ_SCORES_FROM ? $"{Math.Round(data.IQ_SCORES_FROM.Value)}-{Math.Round(data.IQ_SCORES_TO.Value)}": $"{Math.Round(data.IQ_SCORES_FROM.Value)}";
                result.Percentage = data.PERCENTILES_FROM != data.PERCENTILES_TO ? $"{Math.Round(data.PERCENTILES_FROM.Value)}-{Math.Round(data.PERCENTILES_TO.Value)}": $"{Math.Round(data.PERCENTILES_FROM.Value)}";
                if (ci == 90)
                {
                    result.CI = data.CONFIDENCE_90_FROM != data.CONFIDENCE_90_TO ? $"{Math.Round(data.CONFIDENCE_90_FROM.Value)}-{Math.Round(data.CONFIDENCE_90_TO.Value)}" : $"{Math.Round(data.CONFIDENCE_90_FROM.Value)}";
                }
                else
                {
                    result.CI = data.INTERVALS_95_FROM != data.INTERVALS_95_TO ? $"{Math.Round(data.INTERVALS_95_FROM.Value)}-{Math.Round(data.INTERVALS_95_TO.Value)}" : $"{Math.Round(data.INTERVALS_95_FROM.Value)}";
                }
            }

            if (type == "visual")
            {
                var data = _dbContext.WRITVisuals.FirstOrDefault(x => (score >= x.SUM_OF_VISUAL_STD_SCORES_FROM && score <= x.SUM_OF_VISUAL_STD_SCORES_TO));
                result.IQ = data.IQ_SCORES_TO != data.IQ_SCORES_FREOM ? $"{Math.Round(data.IQ_SCORES_FREOM.Value)}-{Math.Round(data.IQ_SCORES_TO.Value)}" : $"{Math.Round(data.IQ_SCORES_FREOM.Value)}";
                result.Percentage = data.PERCENTILES_FROM != data.PERCENTILES_TO ? $"{Math.Round(data.PERCENTILES_FROM.Value)}-{Math.Round(data.PERCENTILES_TO.Value)}" : $"{Math.Round(data.PERCENTILES_FROM.Value)}";

                if (ci == 90)
                {
                    result.CI = data.CONFIDENCE_INTERVALS90_FROM != data.CONFIDENCE_INTERVALS90_TO ? $"{Math.Round(data.CONFIDENCE_INTERVALS90_FROM.Value)}-{Math.Round(data.CONFIDENCE_INTERVALS90_TO.Value)}" : $"{Math.Round(data.CONFIDENCE_INTERVALS90_FROM.Value)}";
                }
                else
                {
                    result.CI = data.CONFIDENCE_INTERVAL_95_FROM != data.CONFIDENCE_INTERVAL_95_TO ? $"{Math.Round(data.CONFIDENCE_INTERVAL_95_FROM.Value)}-{Math.Round(data.CONFIDENCE_INTERVAL_95_TO.Value)}" : $"{Math.Round(data.CONFIDENCE_INTERVAL_95_FROM.Value)}";
                }
            }

            if (type == "general")
            {
                var data = _dbContext.WRITGenerals.FirstOrDefault(x => (score >= x.SUM_OF_ALL_SUBTEST_STD_SCORE_FROM && score <= x.SUM_OF_ALL_SUBTEST_STD_SCORE_TO));
                result.IQ = data.IQ_SCORE_TO != data.IQ_SCORES_FROM ? $"{Math.Round(data.IQ_SCORES_FROM.Value)}-{Math.Round(data.IQ_SCORE_TO.Value)}" : $"{Math.Round(data.IQ_SCORES_FROM.Value)}";
                result.Percentage = data.PERCENTILES_FROM != data.PERCENTILES_TO ? $"{Math.Round(data.PERCENTILES_FROM.Value)}-{Math.Round(data.PERCENTILES_TO.Value)}" : $"{Math.Round(data.PERCENTILES_FROM.Value)}";

                if (ci == 90)
                {
                    result.CI = data.CONFIDENCE_INETRVAL_90_FROM != data.CONFIDENCE_INETRVAL_90_TO ? $"{Math.Round(data.CONFIDENCE_INETRVAL_90_FROM.Value)}-{Math.Round(data.CONFIDENCE_INETRVAL_90_TO.Value)}" : $"{Math.Round(data.CONFIDENCE_INETRVAL_90_FROM.Value)}";
                }
                else
                {
                    result.CI = data.CONFIDENCE_INETRVAL_95_FROM != data.CONFIDENCE_INETRVAL_95_TO ? $"{Math.Round(data.CONFIDENCE_INETRVAL_95_FROM.Value)}-{Math.Round(data.CONFIDENCE_INETRVAL_95_TO.Value)}" : $"{Math.Round(data.CONFIDENCE_INETRVAL_95_FROM.Value)}";
                }
            }

            result.CI = result.CI;
            return Ok(result);
        }


        [HttpGet]
        [Route("assessor/tomal/index")]
        public async Task<ActionResult<TOMALIndexDto>> GetTomalIndex([FromQuery] string smVmi, [FromQuery] string smNmi, 
                                                                        [FromQuery] string smCmi, [FromQuery] string smVdri,
                                                                        [FromQuery] string smAci, [FromQuery] string smSri,
                                                                        [FromQuery] string smFri, [FromQuery] string smAri,
                                                                        [FromQuery] string smli)
        {

            TOMALIndexDto result = new TOMALIndexDto();
            TOMALIndex? data;
            if (!string.IsNullOrEmpty(smVmi) && smVmi != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (smVmi == x.VMI));
                if (data != null)
                {
                    result.IndVmi = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.PerVmi = data.Percentile == data.Percentile_TO ? $"{data.Percentile}": $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
            if (!string.IsNullOrEmpty(smNmi) && smNmi != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (Convert.ToInt32(smNmi) >= x.NMI) && (Convert.ToInt32(smNmi) <= x.NMI_TO));
                if (data != null)
                {
                    result.IndNmi = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.PerNmi = data.Percentile == data.Percentile_TO ? $"{data.Percentile}" : $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
            if (!string.IsNullOrEmpty(smCmi) && smCmi != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (Convert.ToInt32(smCmi) >= x.CMI) && (Convert.ToInt32(smCmi) <= x.CMI_TO));
                if (data != null)
                {
                    result.IndCmi = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.PerCmi = data.Percentile == data.Percentile_TO ? $"{data.Percentile}" : $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
            if (!string.IsNullOrEmpty(smVdri) && smVdri != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (Convert.ToInt32(smVdri) >= x.VDRI) && (Convert.ToInt32(smVdri) <= x.VDRI_1));
                if (data != null)
                {
                    result.IndVdri = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.PerVdri = data.Percentile == data.Percentile_TO ? $"{data.Percentile}" : $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
            if (!string.IsNullOrEmpty(smAci) && smAci != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (Convert.ToInt32(smAci) >= x.ACI) && (Convert.ToInt32(smAci) <= x.ACI_TO));
                if (data != null)
                {
                    result.IndAci = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.PerAci = data.Percentile == data.Percentile_TO ? $"{data.Percentile}" : $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
            if (!string.IsNullOrEmpty(smSri) && smSri != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (Convert.ToInt32(smSri) >= x.SRI) && (Convert.ToInt32(smSri) <= x.SRI_TO));
                if (data != null)
                {
                    result.IndSri = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.PerSri = data.Percentile == data.Percentile_TO ? $"{data.Percentile}" : $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
            if (!string.IsNullOrEmpty(smFri) && smFri != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (Convert.ToInt32(smFri) >= x.FRI) && (Convert.ToInt32(smFri) <= x.FRI_TO));
                if (data != null)
                {
                    result.IndFri = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.PerFri = data.Percentile == data.Percentile_TO ? $"{data.Percentile}" : $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
            if (!string.IsNullOrEmpty(smAri) && smAri != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (Convert.ToInt32(smAri) >= x.ARI) && (Convert.ToInt32(smAri) <= x.ARI_TO));
                if (data != null)
                {
                    result.IndAri = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.PerAri = data.Percentile == data.Percentile_TO ? $"{data.Percentile}" : $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
            if (!string.IsNullOrEmpty(smli) && smli != "0")
            {
                data = _dbContext.TOMALIndexs.FirstOrDefault(x => (Convert.ToInt32(smli) >= x.LI) && (Convert.ToInt32(smli) <= x.LI_TO));
                if (data != null)
                {
                    result.Indli = data.Ind != null ? data.Ind.Value.ToString() : string.Empty;
                    result.Perli = data.Percentile == data.Percentile_TO ? $"{data.Percentile}" : $"{data.Percentile}-{data.Percentile_TO}";

                }
            }
           
            return Ok(result);
        }


        [HttpGet]
        [Route("assessor/art")]
        public async Task<ActionResult<ARTDto>> GetWratScore([FromQuery] string type, [FromQuery] int score)
        {
            var result = new ARTDto();
            ARTMaster data;

            if (type == "acc")
            {
                data = _dbContext.ARTMasters.FirstOrDefault(x => x.Aloud_reading_accuracy == score);
                if (data != null) 
                {
                    result.StandardScore = Convert.ToInt32(data.Standard_score_equivalent);
                    result.Centile = Convert.ToInt32(data.Centile);

                }
            }
            if (type == "compA")
            {
                data = _dbContext.ARTMasters.FirstOrDefault(x => x.Aloud_reading_comprehension == score);
                if (data != null)
                {
                    result.StandardScore = Convert.ToInt32(data.Standard_score_equivalent);
                    result.Centile = Convert.ToInt32(data.Centile);

                }
            }
            if (type == "spdA")
            {
                data = _dbContext.ARTMasters.FirstOrDefault(x => x.Aloud_reading_rate == score);
                if (data != null)
                {
                    result.StandardScore = Convert.ToInt32(data.Standard_score_equivalent);
                    result.Centile = Convert.ToInt32(data.Centile);

                }
            }
            if (type == "compS")
            {
                data = _dbContext.ARTMasters.FirstOrDefault(x => x.Silent_reading_comprehension == score);
                if (data != null)
                {
                    result.StandardScore = Convert.ToInt32(data.Standard_score_equivalent);
                    result.Centile = Convert.ToInt32(data.Centile);

                }
            }
            if (type == "spdS")
            {
                data = _dbContext.ARTMasters.FirstOrDefault(x => x.Silent_reading_rate == score);
                if (data != null)
                {
                    result.StandardScore = Convert.ToInt32(data.Standard_score_equivalent);
                    result.Centile = Convert.ToInt32(data.Centile);

                }
            }
            if (type == "wSpd")
            {
                data = _dbContext.ARTMasters.FirstOrDefault(x => x.Writing_speed == score);
                if (data != null)
                {
                    result.StandardScore = Convert.ToInt32(data.Standard_score_equivalent);
                    result.Centile = Convert.ToInt32(data.Centile);

                }
            }

            return Ok(result);
        }




        [HttpGet]
        [Route("assessor/wrat")]
        public async Task<ActionResult<WRATScoreDto>> GetArtScore([FromQuery] string color, [FromQuery] string type, [FromQuery] int score, [FromQuery] int year, [FromQuery] int month, [FromQuery] decimal ciType)
        {
            var result = new WRATScoreDto();

            if (color == "blue")
            {
                WRAT_Blue? data;

                if (type == "wr")
                {
                    data = _dbContext.WRAT_Blues.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Word_Reading_FROM && score <= x.Word_Reading_TO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Blues.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Word_Reading} - {result.StandardScore + ci.Word_Reading}";
                        }

                    }
                }
                else if (type == "sp")
                {
                    data = _dbContext.WRAT_Blues.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Spelling_FROM && score <= x.SpellingTO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Blues.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Spelling} - {result.StandardScore + ci.Spelling}";
                        }

                    }
                }
                else if (type == "mc")
                {
                    data = _dbContext.WRAT_Blues.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Math_Computation_FROM && score <= x.Math_Computation_TO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Blues.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Math_Computation} - {result.StandardScore + ci.Math_Computation}";
                        }

                    }
                }
                else if (type == "sc")
                {
                    data = _dbContext.WRAT_Blues.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Sentence_Comprehension_FROM && score <= x.Sentence_ComprehensionTO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Blues.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Sentence_Comprehension} - {result.StandardScore + ci.Sentence_Comprehension}";
                        }

                    }
                }
                else if (type == "rc")
                {
                    data = _dbContext.WRAT_Blues.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Reading_Composite_FROM && score <= x.Reading_Composite_TO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Blues.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Reading_Composite} - {result.StandardScore + ci.Reading_Composite}";
                        }

                    }
                }
            }
            else
            {
                WRAT_Green? data;
                if (type == "wr")
                {
                    data = _dbContext.WRAT_Greens.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Word_Reading_FROM && score <= x.Word_Reading_TO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Greens.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Word_Reading} - {result.StandardScore + ci.Word_Reading}";
                        }

                    }
                }
                else if (type == "sp")
                {
                    data = _dbContext.WRAT_Greens.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Spelling_FROM && score <= x.Spelling_TO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Greens.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Spelling} - {result.StandardScore + ci.Spelling}";
                        }

                    }
                }
                else if (type == "mc")
                {
                    data = _dbContext.WRAT_Greens.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Math_Computation_FROM && score <= x.Math_Computation_TO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Greens.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Math_Computation} - {result.StandardScore + ci.Math_Computation}";
                        }

                    }
                }
                else if (type == "sc")
                {
                    data = _dbContext.WRAT_Greens.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Sentence_Comprehension_FROM && score <= x.Sentence_Comprehension_TO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Greens.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Sentence_Comprehension} - {result.StandardScore + ci.Sentence_Comprehension}";
                        }

                    }
                }
                else if (type == "rc")
                {
                    data = _dbContext.WRAT_Greens.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Reading_Composite_FROM && score <= x.Reading_Composite_TO));
                    if (data != null)
                    {
                        result.StandardScore = Convert.ToInt32(data.Standard_score);
                        var ci = _dbContext.WRAT_CI_Greens.Where(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                           && (month >= x.AgeFromMonth && month <= x.AgeToMonth)).ToList().FirstOrDefault(x =>
                                                           ciType == Convert.ToDecimal(x.CI));
                        if (ci != null)
                        {
                            result.ConfidenceInterval = $"{result.StandardScore - ci.Reading_Composite} - {result.StandardScore + ci.Reading_Composite}";
                        }

                    }
                }
            }


            return Ok(result);
        }



        [HttpGet]
        [Route("assessor/towre")]
        public async Task<ActionResult<TowreScoreDto>> GetTowreScore([FromQuery] string type, [FromQuery] int score, [FromQuery] int year, [FromQuery] int month)
        {
            var result = new TowreScoreDto();

            if (type == "swe")
            {
                var data = _dbContext.TowreSwes.FirstOrDefault(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                       && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                       && (score == x.Raw_score));
                if (data != null)
                {
                    result.Scale = data.Score;

                }
            }
            if (type == "pde")
            {
                var data = _dbContext.TowrePdes.FirstOrDefault(x => (year >= x.AgeFromYear && year <= x.AgeToYear)
                                                       && (month >= x.AgeFromMonth && month <= x.AgeToMonth)
                                                       && (score == x.Raw_score));
                if (data != null)
                {
                    result.Scale = data.Score;

                }
            }

            return Ok(result);
        }



        [HttpGet]
        [Route("assessor/goart")]
        public async Task<ActionResult<GoartScoreDto>> GetGoartScore([FromQuery] string color, [FromQuery] string type, [FromQuery] int score, [FromQuery] int year, [FromQuery] int month, [FromQuery] decimal ciType)
        {
            var result = new GoartScoreDto();

            {
                WRAT_Blue? data;

                if (type == "wr")
                {
                    data = _dbContext.WRAT_Blues.FirstOrDefault(x => (year >= x.year_from && year <= x.year_to)
                                                           && (month >= x.month_from && month <= x.month_to)
                                                           && (score >= x.Word_Reading_FROM && score <= x.Word_Reading_TO));
                    if (data != null)
                    {
                        

                    }
                }
            }

            return Ok(result);
        }


        // POST

        [HttpPost]
        [Route("assessor/profile/upload")]
        public async Task<ActionResult> Upload()
        {
            if (!Request.Form.Files.Any())
                return BadRequest("No files found in the request");

            if (Request.Form.Files.Count > 1)
                return BadRequest("Cannot upload more than one file at a time");

            if (Request.Form.Files[0].Length <= 0)
                return BadRequest("Invalid file length, seems to be empty");

            var s = Request.Form.Files;
            IFormFile image = Request.Form.Files[0];
            string Connection = _configuration["ConnectionStrings:BlobConnStr"];
            string containerName = _configuration["ConnectionStrings:AssessorBlobName"];
            Stream myBlob = new MemoryStream();
            myBlob = image.OpenReadStream();
            var blobClient = new BlobContainerClient(Connection, containerName);
            var blobname = $"{Guid.NewGuid().ToString()}{Path.GetExtension(image.FileName)}";
            var blob = blobClient.GetBlobClient(blobname);
            await blob.UploadAsync(myBlob);
            return Ok(blob.Uri);
        }

        [HttpPost]
        [Route("assessor/profile")]
        public async Task<ActionResult> AddAssessor([FromBody] AssessorProfileDto assessorDto)
        {
            if (assessorDto == null)
            {
                return BadRequest();
            }

            var assessor = _mapper.Map<AssessorProfile>(assessorDto);
            assessor.UserId = Guid.Parse(GetUserIdHeader());

            if (assessor.Id == Guid.Empty)
            {
                await _dbContext.AssessorProfiles.AddAsync(assessor);
            }
            else
            {
                _dbContext.AssessorProfiles.Update(assessor);
            }

            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(new
                {
                    Data = _mapper.Map<AssessorProfileDto>(assessor)
                });
            }

            return Ok(new
            {
                Message = "Create failed!"
            });
        }


        [HttpPost]
        [Route("assessor/answer")]
        public async Task<ActionResult> AddAssessorAnswers([FromQuery] int page, [FromBody] QuestionAnswersDto formData, [FromHeader] string userId)
        {
            if (formData == null)
            {
                return BadRequest();
            }

            var current = _dbContext.AssessorAnswers.Where(x => x.Page == page && x.UserId == Guid.Parse(userId));
            _dbContext.AssessorAnswers.RemoveRange(current);

            List<AssessorAnswer> answers = new List<AssessorAnswer>();
            foreach (PropertyInfo propertyInfo in formData.GetType().GetProperties())
            {
                if (!string.IsNullOrEmpty(propertyInfo.GetValue(formData, null)?.ToString()))
                {
                    int no = Convert.ToInt32(propertyInfo.Name.ToLower().Replace("answer", ""));
                    answers.Add(new AssessorAnswer
                    {
                        Answer = propertyInfo.GetValue(formData, null)?.ToString(),
                        Description = string.Empty,
                        Page = page,
                        Number = no,
                        UserId = Guid.Parse(userId)
                    });
                }
            }

            await _dbContext.AssessorAnswers.AddRangeAsync(answers);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return Ok();
            }

            return Ok(new
            {
                Message = "Create failed!"
            });
        }
    }
}
