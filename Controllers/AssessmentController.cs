﻿using AIMSService.Entity;
using AIMSService.Model;
using AutoMapper;
using Azure;
using Azure.Storage.Blobs;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using Web.Entity.Context;
using static System.Net.Mime.MediaTypeNames;

namespace AIMSService.Controllers
{

    [Route("api")]
    [ApiController]
    public class AssessmentController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public AssessmentController(AppDbContext appDbContext, IMapper mapper, IConfiguration configuration)
        {
            _dbContext = appDbContext;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("individual/{studentId}/doc")]
        public async Task<ActionResult> GetStudentDocuments([FromRoute] string studentId)
        {

            if (string.IsNullOrEmpty(studentId))
            {
                return BadRequest();
            }

            var userId = _dbContext.Clients.FirstOrDefault(x=>x.Id == Guid.Parse(studentId))?.UserId;
            if (userId == null) 
            {
                return BadRequest();
            }

            var docs = _dbContext.StudentDocuments.Where(x => x.StudentId == userId);
            List<StudentDocumentDto> studentDocuments = _mapper.Map<List<StudentDocumentDto>>(docs);
            return Ok(studentDocuments);
        }

        [HttpGet("individual/{studentId}/doc/{id}")]
        public async Task<IActionResult> DownloadBlob([FromRoute] string studentId, [FromRoute] string id)
        {
            string Connection = _configuration["ConnectionStrings:BlobConnStr"];
            string containerName = _configuration["ConnectionStrings:IndividualBlobName"];
            var blobContainerClient = new BlobContainerClient(Connection, containerName);

            var file = _dbContext.StudentDocuments.FirstOrDefault(x => x.Id == Guid.Parse(id));
            if (file != null)
            {
                var fileName = System.IO.Path.GetFileName(file.Url);
                var blobClient = blobContainerClient.GetBlobClient(fileName);
                var response = await blobClient.OpenReadAsync();
                return File(response, "application/octet-stream", file.Name);
            }

            return BadRequest();
        }


        [HttpGet("individual/{studentId}/word")]
        public async Task<IActionResult> DownloadDocx([FromRoute] string studentId)
        {
            #region variables

            string WRITVA69 = " ";
            string WRITVA70to79 = " ";
            string WRITVA80to84 = " ";
            string WRITVA85to89 = " ";
            string WRITVA90to109 = " ";
            string WRITVA110to115 = " ";
            string WRITVA116to120 = " ";
            string WRITVA121to130 = " ";
            string WRITVA130 = " ";
            // string WRITVA95CI = " ";
            string WRITVC69 = " ";
            string WRITVC70to79 = " ";
            string WRITVC80to84 = " ";
            string WRITVC85to89 = " ";
            string WRITVC90to109 = " ";
            string WRITVC110to115 = " ";
            string WRITVC116to120 = " ";
            string WRITVC121to130 = " ";
            string WRITVC130 = " ";
            // string WRITVC95CI = " ";
            string WRITVB69 = " ";
            string WRITVB70to79 = " ";
            string WRITVB80to84 = " ";
            string WRITVB85to89 = " ";
            string WRITVB90to109 = " ";
            string WRITVB110to115 = " ";
            string WRITVB116to120 = " ";
            string WRITVB121to130 = " ";
            string WRITVB130 = " ";
            string WRITVB95CI = " ";
            string WRITMT69 = " ";
            string WRITMT70to79 = " ";
            string WRITMT80to84 = " ";
            string WRITMT85to89 = " ";
            string WRITMT90to109 = " ";
            string WRITMT110to115 = " ";
            string WRITMT116to120 = " ";
            string WRITMT121to130 = " ";
            string WRITMT130 = " ";
            // string WRITMT95CI = " ";
            string TOMAL2DF69 = " ";
            string TOMAL2DF70to79 = " ";
            string TOMAL2DF80to84 = " ";
            string TOMAL2DF85to89 = " ";
            string TOMAL2DF90to109 = " ";
            string TOMAL2DF110to115 = " ";
            string TOMAL2DF116to120 = " ";
            string TOMAL2DF121to130 = " ";
            string TOMAL2DF130 = " ";
            // string TOMAL2DF95CI = " ";
            string TOMAL2LF69 = " ";
            string TOMAL2LF70to79 = " ";
            string TOMAL2LF80to84 = " ";
            string TOMAL2LF85to89 = " ";
            string TOMAL2LF90to109 = " ";
            string TOMAL2LF110to115 = " ";
            string TOMAL2LF116to120 = " ";
            string TOMAL2LF121to130 = " ";
            string TOMAL2LF130 = " ";
            // string TOMAL2LF95CI = " ";
            string TOMAL2DB69 = " ";
            string TOMAL2DB70to79 = " ";
            string TOMAL2DB80to84 = " ";
            string TOMAL2DB85to89 = " ";
            string TOMAL2DB90to109 = " ";
            string TOMAL2DB110to115 = " ";
            string TOMAL2DB116to120 = " ";
            string TOMAL2DB121to130 = " ";
            string TOMAL2DB130 = " ";
            // string TOMAL2DB95CI = " ";
            string TOMAL2LB69 = " ";
            string TOMAL2LB70to79 = " ";
            string TOMAL2LB80to84 = " ";
            string TOMAL2LB85to89 = " ";
            string TOMAL2LB90to109 = " ";
            string TOMAL2LB110to115 = " ";
            string TOMAL2LB116to120 = " ";
            string TOMAL2LB121to130 = " ";
            string TOMAL2LB130 = " ";
            // string TOMAL2LB95CI = " ";
            string TOMAL2ACI69 = " ";
            string TOMAL2ACI70to79 = " ";
            string TOMAL2ACI80to84 = " ";
            string TOMAL2ACI85to89 = " ";
            string TOMAL2ACI90to109 = " ";
            string TOMAL2ACI110to115 = " ";
            string TOMAL2ACI116to120 = " ";
            string TOMAL2ACI121to130 = " ";
            string TOMAL2ACI130 = " ";
            string TOMAL2ACI95CI = " ";
            string CTOPP2MD69 = " ";
            string CTOPP2MD70to79 = " ";
            string CTOPP2MD80to84 = " ";
            string CTOPP2MD85to89 = " ";
            string CTOPP2MD90to109 = " ";
            string CTOPP2MD110to115 = " ";
            string CTOPP2MD116to120 = " ";
            string CTOPP2MD121to130 = " ";
            string CTOPP2MD130 = " ";
            // string CTOPP2MD95CI = " ";
            string CTOPP2NWR69 = " ";
            string CTOPP2NWR70to79 = " ";
            string CTOPP2NWR80to84 = " ";
            string CTOPP2NWR85to89 = " ";
            string CTOPP2NWR90to109 = " ";
            string CTOPP2NWR110to115 = " ";
            string CTOPP2NWR116to120 = " ";
            string CTOPP2NWR121to130 = " ";
            string CTOPP2NWR130 = " ";
            // string CTOPP2NWR95CI = " ";
            string CTOPP2PM69 = " ";
            string CTOPP2PM70to79 = " ";
            string CTOPP2PM80to84 = " ";
            string CTOPP2PM85to89 = " ";
            string CTOPP2PM90to109 = " ";
            string CTOPP2PM110to115 = " ";
            string CTOPP2PM116to120 = " ";
            string CTOPP2PM121to130 = " ";
            string CTOPP2PM130 = " ";
            string CTOPP2PM95CI = " ";
            string CTOPP2EL69 = " ";
            string CTOPP2EL70to79 = " ";
            string CTOPP2EL80to84 = " ";
            string CTOPP2EL85to89 = " ";
            string CTOPP2EL90to109 = " ";
            string CTOPP2EL110to115 = " ";
            string CTOPP2EL116to120 = " ";
            string CTOPP2EL121to130 = " ";
            string CTOPP2EL130 = " ";
            // string CTOPP2EL95CI = " ";
            string CTOPP2BW69 = " ";
            string CTOPP2BW70to79 = " ";
            string CTOPP2BW80to84 = " ";
            string CTOPP2BW85to89 = " ";
            string CTOPP2BW90to109 = " ";
            string CTOPP2BW110to115 = " ";
            string CTOPP2BW116to120 = " ";
            string CTOPP2BW121to130 = " ";
            string CTOPP2BW130 = " ";
            // string CTOPP2BW95CI = " ";
            string CTOPP2PI69 = " ";
            string CTOPP2PI70to79 = " ";
            string CTOPP2PI80to84 = " ";
            string CTOPP2PI85to89 = " ";
            string CTOPP2PI90to109 = " ";
            string CTOPP2PI110to115 = " ";
            string CTOPP2PI116to120 = " ";
            string CTOPP2PI121to130 = " ";
            string CTOPP2PI130 = " ";
            // string CTOPP2PI95CI = " ";
            string CTOPP2PAC69 = " ";
            string CTOPP2PAC70to79 = " ";
            string CTOPP2PAC80to84 = " ";
            string CTOPP2PAC85to89 = " ";
            string CTOPP2PAC90to109 = " ";
            string CTOPP2PAC110to115 = " ";
            string CTOPP2PAC116to120 = " ";
            string CTOPP2PAC121to130 = " ";
            string CTOPP2PAC130 = " ";
            string CTOPP2PAC95CI = " ";
            string CTOPP2BNW69 = " ";
            string CTOPP2BNW70to79 = " ";
            string CTOPP2BNW80to84 = " ";
            string CTOPP2BNW85to89 = " ";
            string CTOPP2BNW90to109 = " ";
            string CTOPP2BNW110to115 = " ";
            string CTOPP2BNW116to120 = " ";
            string CTOPP2BNW121to130 = " ";
            string CTOPP2BNW130 = " ";
            // string CTOPP2BNW95CI = " ";
            string CTOPP2SNW69 = " ";
            string CTOPP2SNW70to79 = " ";
            string CTOPP2SNW80to84 = " ";
            string CTOPP2SNW85to89 = " ";
            string CTOPP2SNW90to109 = " ";
            string CTOPP2SNW110to115 = " ";
            string CTOPP2SNW116to120 = " ";
            string CTOPP2SNW121to130 = " ";
            string CTOPP2SNW130 = " ";
            // string CTOPP2SNW95CI = " ";
            string CTOPP2APC69 = " ";
            string CTOPP2APC70to79 = " ";
            string CTOPP2APC80to84 = " ";
            string CTOPP2APC85to89 = " ";
            string CTOPP2APC90to109 = " ";
            string CTOPP2APC110to115 = " ";
            string CTOPP2APC116to120 = " ";
            string CTOPP2APC121to130 = " ";
            string CTOPP2APC130 = " ";
            string CTOPP2APC95CI = " ";
            string CTOPP2RDN69 = " ";
            string CTOPP2RDN70to79 = " ";
            string CTOPP2RDN80to84 = " ";
            string CTOPP2RDN85to89 = " ";
            string CTOPP2RDN90to109 = " ";
            string CTOPP2RDN110to115 = " ";
            string CTOPP2RDN116to120 = " ";
            string CTOPP2RDN121to130 = " ";
            string CTOPP2RDN130 = " ";
            // string CTOPP2RDN95CI = " ";
            string CTOPP2RLN69 = " ";
            string CTOPP2RLN70to79 = " ";
            string CTOPP2RLN80to84 = " ";
            string CTOPP2RLN85to89 = " ";
            string CTOPP2RLN90to109 = " ";
            string CTOPP2RLN110to115 = " ";
            string CTOPP2RLN116to120 = " ";
            string CTOPP2RLN121to130 = " ";
            string CTOPP2RLN130 = " ";
            // string CTOPP2RLN95CI = " ";
            string CTOPP2RSN69 = " ";
            string CTOPP2RSN70to79 = " ";
            string CTOPP2RSN80to84 = " ";
            string CTOPP2RSN85to89 = " ";
            string CTOPP2RSN90to109 = " ";
            string CTOPP2RSN110to115 = " ";
            string CTOPP2RSN116to120 = " ";
            string CTOPP2RSN121to130 = " ";
            string CTOPP2RSN130 = " ";
            string CTOPP2RSN95CI = " ";
            string WRAT5WR69 = " ";
            string WRAT5WR70to79 = " ";
            string WRAT5WR80to84 = " ";
            string WRAT5WR85to89 = " ";
            string WRAT5WR90to109 = " ";
            string WRAT5WR110to115 = " ";
            string WRAT5WR116to120 = " ";
            string WRAT5WR121to130 = " ";
            string WRAT5WR130 = " ";
            string WRAT5WR95CI = " ";
            string WRAT5SP69 = " ";
            string WRAT5SP70to79 = " ";
            string WRAT5SP80to84 = " ";
            string WRAT5SP85to89 = " ";
            string WRAT5SP90to109 = " ";
            string WRAT5SP110to115 = " ";
            string WRAT5SP116to120 = " ";
            string WRAT5SP121to130 = " ";
            string WRAT5SP130 = " ";
            string WRAT5SP95CI = " ";
            string TOWRE2SWE69 = " ";
            string TOWRE2SWE70to79 = " ";
            string TOWRE2SWE80to84 = " ";
            string TOWRE2SWE85to89 = " ";
            string TOWRE2SWE90to109 = " ";
            string TOWRE2SWE110to115 = " ";
            string TOWRE2SWE116to120 = " ";
            string TOWRE2SWE121to130 = " ";
            string TOWRE2SWE130 = " ";
            // string TOWRE2SWE95CI = " ";
            string TOWRE2PDE69 = " ";
            string TOWRE2PDE70to79 = " ";
            string TOWRE2PDE80to84 = " ";
            string TOWRE2PDE85to89 = " ";
            string TOWRE2PDE90to109 = " ";
            string TOWRE2PDE110to115 = " ";
            string TOWRE2PDE116to120 = " ";
            string TOWRE2PDE121to130 = " ";
            string TOWRE2PDE130 = " ";
            // string TOWRE2PDE95CI = " ";
            string TOWRE2IND69 = " ";
            string TOWRE2IND70to79 = " ";
            string TOWRE2IND80to84 = " ";
            string TOWRE2IND85to89 = " ";
            string TOWRE2IND90to109 = " ";
            string TOWRE2IND110to115 = " ";
            string TOWRE2IND116to120 = " ";
            string TOWRE2IND121to130 = " ";
            string TOWRE2IND130 = " ";
            string TOWRE2IND95CI = " ";
            string ART2SC69 = " ";
            string ART2SC70to79 = " ";
            string ART2SC80to84 = " ";
            string ART2SC85to89 = " ";
            string ART2SC90to109 = " ";
            string ART2SC110to115 = " ";
            string ART2SC116to120 = " ";
            string ART2SC121to130 = " ";
            string ART2SC130 = " ";
            // string ART2SC95CI = " ";
            string ART2RA = " ";
            string ART2SR = " ";
            string ART2HW = " ";
            string ART2TY = " ";


           string Art2Chart = "";
           string Art2ChartVal = "";
           string Towre2Chart = "";
           string Towre2ChartVal = "";
           string Wrat5SChart = "";
           string Wrat5SChartVal = "";
           string Wrat5RChart = "";
           string Wrat5RChartVal = "";
           string Ctopp2RSNChart = "";
           string Ctopp2RSNChartVal = "";
           string Ctopp2PAChart = "";
           string Ctopp2PAChartVal = "";
           string Ctopp2PMChart = "";
           string Ctopp2PMChartVal = "";
           string WMChart = "";
           string WMChartVal = "";
           string NVRChart = "";
           string NVRChartVal = "";
           string VRVChart = "";
           string VRVChartVal = "";
           string VRVAChart = "";
           string VRVAChartVal = "";

        #endregion

            var client = _dbContext.Clients.FirstOrDefault(x => x.Id == Guid.Parse(studentId));
            if (client != null)
            {
                var today = DateTime.Today;
                var age = today.Year - client.Dob.Year;
                if (client.Dob.Date > today.AddYears(-age)) age--;

                string templatePath = $"samples\\Report Format NOv 2023_Functional Version.docx";
                string outputPath = $"samples\\{client.Name}_edited.docx";

                if (System.IO.File.Exists(outputPath))
                {
                    System.IO.File.Delete(outputPath);
                }

                System.IO.File.Copy(templatePath, outputPath);

                Dictionary<string, string> placeholders = new Dictionary<string, string>()
                {
                    { "[NAME]", client.Name },
                    { "[DATE]", DateTime.Now.ToString("yyyy-MM-dd") },
                    { "[DOB]", client.Dob.ToString("yyyy-MM-dd") },
                    { "[ASDATE]",DateTime.Now.ToString("yyyy-MM-dd") },
                    { "[AGE]", age.ToString() },
                    { "[ADDRESS]", client.Address },
                    { "[UNIVERSITY]", client.University },
                    { "[COURSE]", client.Course },
                    { "[CYEAR]", client.CourseYear },

                };

                var testResult = GetClientTests(client.Id);

                #region text result binding

                if (!string.IsNullOrEmpty(testResult.WRITVA))
                {
                    WRITVA69 = " ";
                    WRITVA70to79 = " ";
                    WRITVA80to84 = " ";
                    WRITVA85to89 = " ";
                    WRITVA90to109 = " ";
                    WRITVA110to115 = " ";
                    WRITVA116to120 = " ";
                    WRITVA121to130 = " ";
                    WRITVA130 = " ";
                    if (Convert.ToInt32(testResult.WRITVA) < 70)
                    {
                        WRITVA69 = testResult.WRITVA;
                    }
                    else if (Convert.ToInt32(testResult.WRITVA) >= 70 && Convert.ToInt32(testResult.WRITVA) <= 79)
                    {
                        WRITVA70to79 = testResult.WRITVA;
                    }
                    else if (Convert.ToInt32(testResult.WRITVA) >= 80 && Convert.ToInt32(testResult.WRITVA) <= 84)
                    {
                        WRITVA80to84 = testResult.WRITVA;
                    }
                    else if (Convert.ToInt32(testResult.WRITVA) >= 85 && Convert.ToInt32(testResult.WRITVA) <= 89)
                    {
                        WRITVA85to89 = testResult.WRITVA;
                    }
                    else if (Convert.ToInt32(testResult.WRITVA) >= 90 && Convert.ToInt32(testResult.WRITVA) <= 109)
                    {
                        WRITVA90to109 = testResult.WRITVA;
                    }
                    else if (Convert.ToInt32(testResult.WRITVA) >= 110 && Convert.ToInt32(testResult.WRITVA) <= 115)
                    {
                        WRITVA110to115 = testResult.WRITVA;
                    }
                    else if (Convert.ToInt32(testResult.WRITVA) >= 116 && Convert.ToInt32(testResult.WRITVA) <= 120)
                    {
                        WRITVA116to120 = testResult.WRITVA;
                    }
                    else if (Convert.ToInt32(testResult.WRITVA) >= 121 && Convert.ToInt32(testResult.WRITVA) <= 130)
                    {
                        WRITVA121to130 = testResult.WRITVA;
                    }
                    if (Convert.ToInt32(testResult.WRITVA) > 130)
                    {
                        WRITVA130 = testResult.WRITVA;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.WRITVC))
                {
                    WRITVC69 = " ";
                    WRITVC70to79 = " ";
                    WRITVC80to84 = " ";
                    WRITVC85to89 = " ";
                    WRITVC90to109 = " ";
                    WRITVC110to115 = " ";
                    WRITVC116to120 = " ";
                    WRITVC121to130 = " ";
                    WRITVC130 = " ";
                    if (Convert.ToInt32(testResult.WRITVC) < 70)
                    {
                        WRITVC69 = testResult.WRITVC;
                    }
                    else if (Convert.ToInt32(testResult.WRITVC) >= 70 && Convert.ToInt32(testResult.WRITVC) <= 79)
                    {
                        WRITVC70to79 = testResult.WRITVC;
                    }
                    else if (Convert.ToInt32(testResult.WRITVC) >= 80 && Convert.ToInt32(testResult.WRITVC) <= 84)
                    {
                        WRITVC80to84 = testResult.WRITVC;
                    }
                    else if (Convert.ToInt32(testResult.WRITVC) >= 85 && Convert.ToInt32(testResult.WRITVC) <= 89)
                    {
                        WRITVC85to89 = testResult.WRITVC;
                    }
                    else if (Convert.ToInt32(testResult.WRITVC) >= 90 && Convert.ToInt32(testResult.WRITVC) <= 109)
                    {
                        WRITVC90to109 = testResult.WRITVC;
                    }
                    else if (Convert.ToInt32(testResult.WRITVC) >= 110 && Convert.ToInt32(testResult.WRITVC) <= 115)
                    {
                        WRITVC110to115 = testResult.WRITVC;
                    }
                    else if (Convert.ToInt32(testResult.WRITVC) >= 116 && Convert.ToInt32(testResult.WRITVC) <= 120)
                    {
                        WRITVC116to120 = testResult.WRITVC;
                    }
                    else if (Convert.ToInt32(testResult.WRITVC) >= 121 && Convert.ToInt32(testResult.WRITVC) <= 130)
                    {
                        WRITVC121to130 = testResult.WRITVC;
                    }
                    if (Convert.ToInt32(testResult.WRITVC) > 130)
                    {
                        WRITVC130 = testResult.WRITVC;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.WRITVB))
                {
                    WRITVB69 = " ";
                    WRITVB70to79 = " ";
                    WRITVB80to84 = " ";
                    WRITVB85to89 = " ";
                    WRITVB90to109 = " ";
                    WRITVB110to115 = " ";
                    WRITVB116to120 = " ";
                    WRITVB121to130 = " ";
                    WRITVB130 = " ";
                    WRITVB95CI = " ";
                    if (Convert.ToInt32(testResult.WRITVB) < 70)
                    {
                        WRITVB69 = testResult.WRITVB;
                    }
                    else if (Convert.ToInt32(testResult.WRITVB) >= 70 && Convert.ToInt32(testResult.WRITVB) <= 79)
                    {
                        WRITVB70to79 = testResult.WRITVB;
                    }
                    else if (Convert.ToInt32(testResult.WRITVB) >= 80 && Convert.ToInt32(testResult.WRITVB) <= 84)
                    {
                        WRITVB80to84 = testResult.WRITVB;
                    }
                    else if (Convert.ToInt32(testResult.WRITVB) >= 85 && Convert.ToInt32(testResult.WRITVB) <= 89)
                    {
                        WRITVB85to89 = testResult.WRITVB;
                    }
                    else if (Convert.ToInt32(testResult.WRITVB) >= 90 && Convert.ToInt32(testResult.WRITVB) <= 109)
                    {
                        WRITVB90to109 = testResult.WRITVB;
                    }
                    else if (Convert.ToInt32(testResult.WRITVB) >= 110 && Convert.ToInt32(testResult.WRITVB) <= 115)
                    {
                        WRITVB110to115 = testResult.WRITVB;
                    }
                    else if (Convert.ToInt32(testResult.WRITVB) >= 116 && Convert.ToInt32(testResult.WRITVB) <= 120)
                    {
                        WRITVB116to120 = testResult.WRITVB;
                    }
                    else if (Convert.ToInt32(testResult.WRITVB) >= 121 && Convert.ToInt32(testResult.WRITVB) <= 130)
                    {
                        WRITVB121to130 = testResult.WRITVB;
                    }
                    if (Convert.ToInt32(testResult.WRITVB) > 130)
                    {
                        WRITVB130 = testResult.WRITVB;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.WRITMAT))
                {
                    WRITMT69 = " ";
                    WRITMT70to79 = " ";
                    WRITMT80to84 = " ";
                    WRITMT85to89 = " ";
                    WRITMT90to109 = " ";
                    WRITMT110to115 = " ";
                    WRITMT116to120 = " ";
                    WRITMT121to130 = " ";
                    WRITMT130 = " ";
                    if (Convert.ToInt32(testResult.WRITMAT) < 70)
                    {
                        WRITMT69 = testResult.WRITMAT;
                    }
                    else if (Convert.ToInt32(testResult.WRITMAT) >= 70 && Convert.ToInt32(testResult.WRITMAT) <= 79)
                    {
                        WRITMT70to79 = testResult.WRITMAT;
                    }
                    else if (Convert.ToInt32(testResult.WRITMAT) >= 80 && Convert.ToInt32(testResult.WRITMAT) <= 84)
                    {
                        WRITMT80to84 = testResult.WRITMAT;
                    }
                    else if (Convert.ToInt32(testResult.WRITMAT) >= 85 && Convert.ToInt32(testResult.WRITMAT) <= 89)
                    {
                        WRITMT85to89 = testResult.WRITMAT;
                    }
                    else if (Convert.ToInt32(testResult.WRITMAT) >= 90 && Convert.ToInt32(testResult.WRITMAT) <= 109)
                    {
                        WRITMT90to109 = testResult.WRITMAT;
                    }
                    else if (Convert.ToInt32(testResult.WRITMAT) >= 110 && Convert.ToInt32(testResult.WRITMAT) <= 115)
                    {
                        WRITMT110to115 = testResult.WRITMAT;
                    }
                    else if (Convert.ToInt32(testResult.WRITMAT) >= 116 && Convert.ToInt32(testResult.WRITMAT) <= 120)
                    {
                        WRITMT116to120 = testResult.WRITMAT;
                    }
                    else if (Convert.ToInt32(testResult.WRITMAT) >= 121 && Convert.ToInt32(testResult.WRITMAT) <= 130)
                    {
                        WRITMT121to130 = testResult.WRITMAT;
                    }
                    if (Convert.ToInt32(testResult.WRITMAT) > 130)
                    {
                        WRITMT130 = testResult.WRITMAT;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.TOMAL2DF))
                {
                    TOMAL2DF69 = " ";
                    TOMAL2DF70to79 = " ";
                    TOMAL2DF80to84 = " ";
                    TOMAL2DF85to89 = " ";
                    TOMAL2DF90to109 = " ";
                    TOMAL2DF110to115 = " ";
                    TOMAL2DF116to120 = " ";
                    TOMAL2DF121to130 = " ";
                    TOMAL2DF130 = " ";
                    if (Convert.ToInt32(testResult.TOMAL2DF) < 70)
                    {
                        TOMAL2DF69 = testResult.TOMAL2DF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DF) >= 70 && Convert.ToInt32(testResult.TOMAL2DF) <= 79)
                    {
                        TOMAL2DF70to79 = testResult.TOMAL2DF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DF) >= 80 && Convert.ToInt32(testResult.TOMAL2DF) <= 84)
                    {
                        TOMAL2DF80to84 = testResult.TOMAL2DF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DF) >= 85 && Convert.ToInt32(testResult.TOMAL2DF) <= 89)
                    {
                        TOMAL2DF85to89 = testResult.TOMAL2DF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DF) >= 90 && Convert.ToInt32(testResult.TOMAL2DF) <= 109)
                    {
                        TOMAL2DF90to109 = testResult.TOMAL2DF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DF) >= 110 && Convert.ToInt32(testResult.TOMAL2DF) <= 115)
                    {
                        TOMAL2DF110to115 = testResult.TOMAL2DF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DF) >= 116 && Convert.ToInt32(testResult.TOMAL2DF) <= 120)
                    {
                        TOMAL2DF116to120 = testResult.TOMAL2DF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DF) >= 121 && Convert.ToInt32(testResult.TOMAL2DF) <= 130)
                    {
                        TOMAL2DF121to130 = testResult.TOMAL2DF;
                    }
                    if (Convert.ToInt32(testResult.TOMAL2DF) > 130)
                    {
                        TOMAL2DF130 = testResult.TOMAL2DF;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.TOMAL2LF))
                {
                    TOMAL2LF69 = " ";
                    TOMAL2LF70to79 = " ";
                    TOMAL2LF80to84 = " ";
                    TOMAL2LF85to89 = " ";
                    TOMAL2LF90to109 = " ";
                    TOMAL2LF110to115 = " ";
                    TOMAL2LF116to120 = " ";
                    TOMAL2LF121to130 = " ";
                    TOMAL2LF130 = " ";
                    if (Convert.ToInt32(testResult.TOMAL2LF) < 70)
                    {
                        TOMAL2LF69 = testResult.TOMAL2LF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LF) >= 70 && Convert.ToInt32(testResult.TOMAL2LF) <= 79)
                    {
                        TOMAL2LF70to79 = testResult.TOMAL2LF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LF) >= 80 && Convert.ToInt32(testResult.TOMAL2LF) <= 84)
                    {
                        TOMAL2LF80to84 = testResult.TOMAL2LF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LF) >= 85 && Convert.ToInt32(testResult.TOMAL2LF) <= 89)
                    {
                        TOMAL2LF85to89 = testResult.TOMAL2LF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LF) >= 90 && Convert.ToInt32(testResult.TOMAL2LF) <= 109)
                    {
                        TOMAL2LF90to109 = testResult.TOMAL2LF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LF) >= 110 && Convert.ToInt32(testResult.TOMAL2LF) <= 115)
                    {
                        TOMAL2LF110to115 = testResult.TOMAL2LF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LF) >= 116 && Convert.ToInt32(testResult.TOMAL2LF) <= 120)
                    {
                        TOMAL2LF116to120 = testResult.TOMAL2LF;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LF) >= 121 && Convert.ToInt32(testResult.TOMAL2LF) <= 130)
                    {
                        TOMAL2LF121to130 = testResult.TOMAL2LF;
                    }
                    if (Convert.ToInt32(testResult.TOMAL2LF) > 130)
                    {
                        TOMAL2LF130 = testResult.TOMAL2LF;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.TOMAL2DB))
                {
                    TOMAL2DB69 = " ";
                    TOMAL2DB70to79 = " ";
                    TOMAL2DB80to84 = " ";
                    TOMAL2DB85to89 = " ";
                    TOMAL2DB90to109 = " ";
                    TOMAL2DB110to115 = " ";
                    TOMAL2DB116to120 = " ";
                    TOMAL2DB121to130 = " ";
                    TOMAL2DB130 = " ";
                    if (Convert.ToInt32(testResult.TOMAL2DB) < 70)
                    {
                        TOMAL2DB69 = testResult.TOMAL2DB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DB) >= 70 && Convert.ToInt32(testResult.TOMAL2DB) <= 79)
                    {
                        TOMAL2DB70to79 = testResult.TOMAL2DB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DB) >= 80 && Convert.ToInt32(testResult.TOMAL2DB) <= 84)
                    {
                        TOMAL2DB80to84 = testResult.TOMAL2DB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DB) >= 85 && Convert.ToInt32(testResult.TOMAL2DB) <= 89)
                    {
                        TOMAL2DB85to89 = testResult.TOMAL2DB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DB) >= 90 && Convert.ToInt32(testResult.TOMAL2DB) <= 109)
                    {
                        TOMAL2DB90to109 = testResult.TOMAL2DB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DB) >= 110 && Convert.ToInt32(testResult.TOMAL2DB) <= 115)
                    {
                        TOMAL2DB110to115 = testResult.TOMAL2DB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DB) >= 116 && Convert.ToInt32(testResult.TOMAL2DB) <= 120)
                    {
                        TOMAL2DB116to120 = testResult.TOMAL2DB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2DB) >= 121 && Convert.ToInt32(testResult.TOMAL2DB) <= 130)
                    {
                        TOMAL2DB121to130 = testResult.TOMAL2DB;
                    }
                    if (Convert.ToInt32(testResult.TOMAL2DB) > 130)
                    {
                        TOMAL2DB130 = testResult.TOMAL2DB;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.TOMAL2LB))
                {
                    TOMAL2LB69 = " ";
                    TOMAL2LB70to79 = " ";
                    TOMAL2LB80to84 = " ";
                    TOMAL2LB85to89 = " ";
                    TOMAL2LB90to109 = " ";
                    TOMAL2LB110to115 = " ";
                    TOMAL2LB116to120 = " ";
                    TOMAL2LB121to130 = " ";
                    TOMAL2LB130 = " ";
                    if (Convert.ToInt32(testResult.TOMAL2LB) < 70)
                    {
                        TOMAL2LB69 = testResult.TOMAL2LB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LB) >= 70 && Convert.ToInt32(testResult.TOMAL2LB) <= 79)
                    {
                        TOMAL2LB70to79 = testResult.TOMAL2LB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LB) >= 80 && Convert.ToInt32(testResult.TOMAL2LB) <= 84)
                    {
                        TOMAL2LB80to84 = testResult.TOMAL2LB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LB) >= 85 && Convert.ToInt32(testResult.TOMAL2LB) <= 89)
                    {
                        TOMAL2LB85to89 = testResult.TOMAL2LB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LB) >= 90 && Convert.ToInt32(testResult.TOMAL2LB) <= 109)
                    {
                        TOMAL2LB90to109 = testResult.TOMAL2LB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LB) >= 110 && Convert.ToInt32(testResult.TOMAL2LB) <= 115)
                    {
                        TOMAL2LB110to115 = testResult.TOMAL2LB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LB) >= 116 && Convert.ToInt32(testResult.TOMAL2LB) <= 120)
                    {
                        TOMAL2LB116to120 = testResult.TOMAL2LB;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2LB) >= 121 && Convert.ToInt32(testResult.TOMAL2LB) <= 130)
                    {
                        TOMAL2LB121to130 = testResult.TOMAL2LB;
                    }
                    if (Convert.ToInt32(testResult.TOMAL2LB) > 130)
                    {
                        TOMAL2LB130 = testResult.TOMAL2LB;
                    }
                }


                if (!string.IsNullOrEmpty(testResult.TOMAL2ACI))
                {
                    TOMAL2ACI69 = " ";
                    TOMAL2ACI70to79 = " ";
                    TOMAL2ACI80to84 = " ";
                    TOMAL2ACI85to89 = " ";
                    TOMAL2ACI90to109 = " ";
                    TOMAL2ACI110to115 = " ";
                    TOMAL2ACI116to120 = " ";
                    TOMAL2ACI121to130 = " ";
                    TOMAL2ACI130 = " ";
                    TOMAL2ACI95CI = " ";
                    if (Convert.ToInt32(testResult.TOMAL2ACI) < 70)
                    {
                        TOMAL2ACI69 = testResult.TOMAL2ACI;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2ACI) >= 70 && Convert.ToInt32(testResult.TOMAL2ACI) <= 79)
                    {
                        TOMAL2ACI70to79 = testResult.TOMAL2ACI;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2ACI) >= 80 && Convert.ToInt32(testResult.TOMAL2ACI) <= 84)
                    {
                        TOMAL2ACI80to84 = testResult.TOMAL2ACI;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2ACI) >= 85 && Convert.ToInt32(testResult.TOMAL2ACI) <= 89)
                    {
                        TOMAL2ACI85to89 = testResult.TOMAL2ACI;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2ACI) >= 90 && Convert.ToInt32(testResult.TOMAL2ACI) <= 109)
                    {
                        TOMAL2ACI90to109 = testResult.TOMAL2ACI;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2ACI) >= 110 && Convert.ToInt32(testResult.TOMAL2ACI) <= 115)
                    {
                        TOMAL2ACI110to115 = testResult.TOMAL2ACI;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2ACI) >= 116 && Convert.ToInt32(testResult.TOMAL2ACI) <= 120)
                    {
                        TOMAL2ACI116to120 = testResult.TOMAL2ACI;
                    }
                    else if (Convert.ToInt32(testResult.TOMAL2ACI) >= 121 && Convert.ToInt32(testResult.TOMAL2ACI) <= 130)
                    {
                        TOMAL2ACI121to130 = testResult.TOMAL2ACI;
                    }
                    if (Convert.ToInt32(testResult.TOMAL2ACI) > 130)
                    {
                        TOMAL2ACI130 = testResult.TOMAL2ACI;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2MD))
                {
                    CTOPP2MD69 = " ";
                    CTOPP2MD70to79 = " ";
                    CTOPP2MD80to84 = " ";
                    CTOPP2MD85to89 = " ";
                    CTOPP2MD90to109 = " ";
                    CTOPP2MD110to115 = " ";
                    CTOPP2MD116to120 = " ";
                    CTOPP2MD121to130 = " ";
                    CTOPP2MD130 = " ";
                    if (Convert.ToInt32(testResult.CTOPP2MD) < 70)
                    {
                        CTOPP2MD69 = testResult.CTOPP2MD;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2MD) >= 70 && Convert.ToInt32(testResult.CTOPP2MD) <= 79)
                    {
                        CTOPP2MD70to79 = testResult.CTOPP2MD;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2MD) >= 80 && Convert.ToInt32(testResult.CTOPP2MD) <= 84)
                    {
                        CTOPP2MD80to84 = testResult.CTOPP2MD;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2MD) >= 85 && Convert.ToInt32(testResult.CTOPP2MD) <= 89)
                    {
                        CTOPP2MD85to89 = testResult.CTOPP2MD;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2MD) >= 90 && Convert.ToInt32(testResult.CTOPP2MD) <= 109)
                    {
                        CTOPP2MD90to109 = testResult.CTOPP2MD;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2MD) >= 110 && Convert.ToInt32(testResult.CTOPP2MD) <= 115)
                    {
                        CTOPP2MD110to115 = testResult.CTOPP2MD;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2MD) >= 116 && Convert.ToInt32(testResult.CTOPP2MD) <= 120)
                    {
                        CTOPP2MD116to120 = testResult.CTOPP2MD;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2MD) >= 121 && Convert.ToInt32(testResult.CTOPP2MD) <= 130)
                    {
                        CTOPP2MD121to130 = testResult.CTOPP2MD;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2MD) > 130)
                    {
                        CTOPP2MD130 = testResult.CTOPP2MD;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2NWR))
                {
                    CTOPP2NWR69 = " ";
                    CTOPP2NWR70to79 = " ";
                    CTOPP2NWR80to84 = " ";
                    CTOPP2NWR85to89 = " ";
                    CTOPP2NWR90to109 = " ";
                    CTOPP2NWR110to115 = " ";
                    CTOPP2NWR116to120 = " ";
                    CTOPP2NWR121to130 = " ";
                    CTOPP2NWR130 = " ";
                    if (Convert.ToInt32(testResult.CTOPP2NWR) < 70)
                    {
                        CTOPP2NWR69 = testResult.CTOPP2NWR;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2NWR) >= 70 && Convert.ToInt32(testResult.CTOPP2NWR) <= 79)
                    {
                        CTOPP2NWR70to79 = testResult.CTOPP2NWR;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2NWR) >= 80 && Convert.ToInt32(testResult.CTOPP2NWR) <= 84)
                    {
                        CTOPP2NWR80to84 = testResult.CTOPP2NWR;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2NWR) >= 85 && Convert.ToInt32(testResult.CTOPP2NWR) <= 89)
                    {
                        CTOPP2NWR85to89 = testResult.CTOPP2NWR;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2NWR) >= 90 && Convert.ToInt32(testResult.CTOPP2NWR) <= 109)
                    {
                        CTOPP2NWR90to109 = testResult.CTOPP2NWR;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2NWR) >= 110 && Convert.ToInt32(testResult.CTOPP2NWR) <= 115)
                    {
                        CTOPP2NWR110to115 = testResult.CTOPP2NWR;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2NWR) >= 116 && Convert.ToInt32(testResult.CTOPP2NWR) <= 120)
                    {
                        CTOPP2NWR116to120 = testResult.CTOPP2NWR;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2NWR) >= 121 && Convert.ToInt32(testResult.CTOPP2NWR) <= 130)
                    {
                        CTOPP2NWR121to130 = testResult.CTOPP2NWR;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2NWR) > 130)
                    {
                        CTOPP2NWR130 = testResult.CTOPP2NWR;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2PM))
                {
                    CTOPP2PM69 = " ";
                    CTOPP2PM70to79 = " ";
                    CTOPP2PM80to84 = " ";
                    CTOPP2PM85to89 = " ";
                    CTOPP2PM90to109 = " ";
                    CTOPP2PM110to115 = " ";
                    CTOPP2PM116to120 = " ";
                    CTOPP2PM121to130 = " ";
                    CTOPP2PM130 = " ";
                    CTOPP2PM95CI = " ";
                    if (Convert.ToInt32(testResult.CTOPP2PM) < 70)
                    {
                        CTOPP2PM69 = testResult.CTOPP2PM;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PM) >= 70 && Convert.ToInt32(testResult.CTOPP2PM) <= 79)
                    {
                        CTOPP2PM70to79 = testResult.CTOPP2PM;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PM) >= 80 && Convert.ToInt32(testResult.CTOPP2PM) <= 84)
                    {
                        CTOPP2PM80to84 = testResult.CTOPP2PM;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PM) >= 85 && Convert.ToInt32(testResult.CTOPP2PM) <= 89)
                    {
                        CTOPP2PM85to89 = testResult.CTOPP2PM;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PM) >= 90 && Convert.ToInt32(testResult.CTOPP2PM) <= 109)
                    {
                        CTOPP2PM90to109 = testResult.CTOPP2PM;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PM) >= 110 && Convert.ToInt32(testResult.CTOPP2PM) <= 115)
                    {
                        CTOPP2PM110to115 = testResult.CTOPP2PM;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PM) >= 116 && Convert.ToInt32(testResult.CTOPP2PM) <= 120)
                    {
                        CTOPP2PM116to120 = testResult.CTOPP2PM;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PM) >= 121 && Convert.ToInt32(testResult.CTOPP2PM) <= 130)
                    {
                        CTOPP2PM121to130 = testResult.CTOPP2PM;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2PM) > 130)
                    {
                        CTOPP2PM130 = testResult.CTOPP2PM;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2EL))
                {
                    CTOPP2EL69 = " ";
                    CTOPP2EL70to79 = " ";
                    CTOPP2EL80to84 = " ";
                    CTOPP2EL85to89 = " ";
                    CTOPP2EL90to109 = " ";
                    CTOPP2EL110to115 = " ";
                    CTOPP2EL116to120 = " ";
                    CTOPP2EL121to130 = " ";
                    CTOPP2EL130 = " ";
                    if (Convert.ToInt32(testResult.CTOPP2EL) < 70)
                    {
                        CTOPP2EL69 = testResult.CTOPP2EL;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2EL) >= 70 && Convert.ToInt32(testResult.CTOPP2EL) <= 79)
                    {
                        CTOPP2EL70to79 = testResult.CTOPP2EL;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2EL) >= 80 && Convert.ToInt32(testResult.CTOPP2EL) <= 84)
                    {
                        CTOPP2EL80to84 = testResult.CTOPP2EL;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2EL) >= 85 && Convert.ToInt32(testResult.CTOPP2EL) <= 89)
                    {
                        CTOPP2EL85to89 = testResult.CTOPP2EL;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2EL) >= 90 && Convert.ToInt32(testResult.CTOPP2EL) <= 109)
                    {
                        CTOPP2EL90to109 = testResult.CTOPP2EL;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2EL) >= 110 && Convert.ToInt32(testResult.CTOPP2EL) <= 115)
                    {
                        CTOPP2EL110to115 = testResult.CTOPP2EL;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2EL) >= 116 && Convert.ToInt32(testResult.CTOPP2EL) <= 120)
                    {
                        CTOPP2EL116to120 = testResult.CTOPP2EL;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2EL) >= 121 && Convert.ToInt32(testResult.CTOPP2EL) <= 130)
                    {
                        CTOPP2EL121to130 = testResult.CTOPP2EL;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2EL) > 130)
                    {
                        CTOPP2EL130 = testResult.CTOPP2EL;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2BW))
                {
                    CTOPP2BW69 = " ";
                    CTOPP2BW70to79 = " ";
                    CTOPP2BW80to84 = " ";
                    CTOPP2BW85to89 = " ";
                    CTOPP2BW90to109 = " ";
                    CTOPP2BW110to115 = " ";
                    CTOPP2BW116to120 = " ";
                    CTOPP2BW121to130 = " ";
                    CTOPP2BW130 = " ";
                    if (Convert.ToInt32(testResult.CTOPP2BW) < 70)
                    {
                        CTOPP2BW69 = testResult.CTOPP2BW;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2BW) >= 70 && Convert.ToInt32(testResult.CTOPP2BW) <= 79)
                    {
                        CTOPP2BW70to79 = testResult.CTOPP2BW;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2BW) >= 80 && Convert.ToInt32(testResult.CTOPP2BW) <= 84)
                    {
                        CTOPP2BW80to84 = testResult.CTOPP2BW;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2BW) >= 85 && Convert.ToInt32(testResult.CTOPP2BW) <= 89)
                    {
                        CTOPP2BW85to89 = testResult.CTOPP2BW;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2BW) >= 90 && Convert.ToInt32(testResult.CTOPP2BW) <= 109)
                    {
                        CTOPP2BW90to109 = testResult.CTOPP2BW;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2BW) >= 110 && Convert.ToInt32(testResult.CTOPP2BW) <= 115)
                    {
                        CTOPP2BW110to115 = testResult.CTOPP2BW;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2BW) >= 116 && Convert.ToInt32(testResult.CTOPP2BW) <= 120)
                    {
                        CTOPP2BW116to120 = testResult.CTOPP2BW;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2BW) >= 121 && Convert.ToInt32(testResult.CTOPP2BW) <= 130)
                    {
                        CTOPP2BW121to130 = testResult.CTOPP2BW;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2BW) > 130)
                    {
                        CTOPP2BW130 = testResult.CTOPP2BW;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2PI))
                {
                    CTOPP2PI69 = " ";
                    CTOPP2PI70to79 = " ";
                    CTOPP2PI80to84 = " ";
                    CTOPP2PI85to89 = " ";
                    CTOPP2PI90to109 = " ";
                    CTOPP2PI110to115 = " ";
                    CTOPP2PI116to120 = " ";
                    CTOPP2PI121to130 = " ";
                    CTOPP2PI130 = " ";
                    if (Convert.ToInt32(testResult.CTOPP2PI) < 70)
                    {
                        CTOPP2PI69 = testResult.CTOPP2PI;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PI) >= 70 && Convert.ToInt32(testResult.CTOPP2PI) <= 79)
                    {
                        CTOPP2PI70to79 = testResult.CTOPP2PI;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PI) >= 80 && Convert.ToInt32(testResult.CTOPP2PI) <= 84)
                    {
                        CTOPP2PI80to84 = testResult.CTOPP2PI;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PI) >= 85 && Convert.ToInt32(testResult.CTOPP2PI) <= 89)
                    {
                        CTOPP2PI85to89 = testResult.CTOPP2PI;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PI) >= 90 && Convert.ToInt32(testResult.CTOPP2PI) <= 109)
                    {
                        CTOPP2PI90to109 = testResult.CTOPP2PI;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PI) >= 110 && Convert.ToInt32(testResult.CTOPP2PI) <= 115)
                    {
                        CTOPP2PI110to115 = testResult.CTOPP2PI;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PI) >= 116 && Convert.ToInt32(testResult.CTOPP2PI) <= 120)
                    {
                        CTOPP2PI116to120 = testResult.CTOPP2PI;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PI) >= 121 && Convert.ToInt32(testResult.CTOPP2PI) <= 130)
                    {
                        CTOPP2PI121to130 = testResult.CTOPP2PI;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2PI) > 130)
                    {
                        CTOPP2PI130 = testResult.CTOPP2PI;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2PAC))
                {
                    CTOPP2PAC69 = " ";
                    CTOPP2PAC70to79 = " ";
                    CTOPP2PAC80to84 = " ";
                    CTOPP2PAC85to89 = " ";
                    CTOPP2PAC90to109 = " ";
                    CTOPP2PAC110to115 = " ";
                    CTOPP2PAC116to120 = " ";
                    CTOPP2PAC121to130 = " ";
                    CTOPP2PAC130 = " ";
                    CTOPP2PAC95CI = " ";
                    if (Convert.ToInt32(testResult.CTOPP2PAC) < 70)
                    {
                        CTOPP2PAC69 = testResult.CTOPP2PAC;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PAC) >= 70 && Convert.ToInt32(testResult.CTOPP2PAC) <= 79)
                    {
                        CTOPP2PAC70to79 = testResult.CTOPP2PAC;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PAC) >= 80 && Convert.ToInt32(testResult.CTOPP2PAC) <= 84)
                    {
                        CTOPP2PAC80to84 = testResult.CTOPP2PAC;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PAC) >= 85 && Convert.ToInt32(testResult.CTOPP2PAC) <= 89)
                    {
                        CTOPP2PAC85to89 = testResult.CTOPP2PAC;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PAC) >= 90 && Convert.ToInt32(testResult.CTOPP2PAC) <= 109)
                    {
                        CTOPP2PAC90to109 = testResult.CTOPP2PAC;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PAC) >= 110 && Convert.ToInt32(testResult.CTOPP2PAC) <= 115)
                    {
                        CTOPP2PAC110to115 = testResult.CTOPP2PAC;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PAC) >= 116 && Convert.ToInt32(testResult.CTOPP2PAC) <= 120)
                    {
                        CTOPP2PAC116to120 = testResult.CTOPP2PAC;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2PAC) >= 121 && Convert.ToInt32(testResult.CTOPP2PAC) <= 130)
                    {
                        CTOPP2PAC121to130 = testResult.CTOPP2PAC;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2PAC) > 130)
                    {
                        CTOPP2PAC130 = testResult.CTOPP2PAC;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2RDN))
                {
                    CTOPP2RDN69 = " ";
                    CTOPP2RDN70to79 = " ";
                    CTOPP2RDN80to84 = " ";
                    CTOPP2RDN85to89 = " ";
                    CTOPP2RDN90to109 = " ";
                    CTOPP2RDN110to115 = " ";
                    CTOPP2RDN116to120 = " ";
                    CTOPP2RDN121to130 = " ";
                    CTOPP2RDN130 = " ";
                    if (Convert.ToInt32(testResult.CTOPP2RDN) < 70)
                    {
                        CTOPP2RDN69 = testResult.CTOPP2RDN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RDN) >= 70 && Convert.ToInt32(testResult.CTOPP2RDN) <= 79)
                    {
                        CTOPP2RDN70to79 = testResult.CTOPP2RDN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RDN) >= 80 && Convert.ToInt32(testResult.CTOPP2RDN) <= 84)
                    {
                        CTOPP2RDN80to84 = testResult.CTOPP2RDN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RDN) >= 85 && Convert.ToInt32(testResult.CTOPP2RDN) <= 89)
                    {
                        CTOPP2RDN85to89 = testResult.CTOPP2RDN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RDN) >= 90 && Convert.ToInt32(testResult.CTOPP2RDN) <= 109)
                    {
                        CTOPP2RDN90to109 = testResult.CTOPP2RDN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RDN) >= 110 && Convert.ToInt32(testResult.CTOPP2RDN) <= 115)
                    {
                        CTOPP2RDN110to115 = testResult.CTOPP2RDN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RDN) >= 116 && Convert.ToInt32(testResult.CTOPP2RDN) <= 120)
                    {
                        CTOPP2RDN116to120 = testResult.CTOPP2RDN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RDN) >= 121 && Convert.ToInt32(testResult.CTOPP2RDN) <= 130)
                    {
                        CTOPP2RDN121to130 = testResult.CTOPP2RDN;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2RDN) > 130)
                    {
                        CTOPP2RDN130 = testResult.CTOPP2RDN;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2RLN))
                {
                    CTOPP2RLN69 = " ";
                    CTOPP2RLN70to79 = " ";
                    CTOPP2RLN80to84 = " ";
                    CTOPP2RLN85to89 = " ";
                    CTOPP2RLN90to109 = " ";
                    CTOPP2RLN110to115 = " ";
                    CTOPP2RLN116to120 = " ";
                    CTOPP2RLN121to130 = " ";
                    CTOPP2RLN130 = " ";
                    if (Convert.ToInt32(testResult.CTOPP2RLN) < 70)
                    {
                        CTOPP2RLN69 = testResult.CTOPP2RLN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RLN) >= 70 && Convert.ToInt32(testResult.CTOPP2RLN) <= 79)
                    {
                        CTOPP2RLN70to79 = testResult.CTOPP2RLN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RLN) >= 80 && Convert.ToInt32(testResult.CTOPP2RLN) <= 84)
                    {
                        CTOPP2RLN80to84 = testResult.CTOPP2RLN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RLN) >= 85 && Convert.ToInt32(testResult.CTOPP2RLN) <= 89)
                    {
                        CTOPP2RLN85to89 = testResult.CTOPP2RLN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RLN) >= 90 && Convert.ToInt32(testResult.CTOPP2RLN) <= 109)
                    {
                        CTOPP2RLN90to109 = testResult.CTOPP2RLN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RLN) >= 110 && Convert.ToInt32(testResult.CTOPP2RLN) <= 115)
                    {
                        CTOPP2RLN110to115 = testResult.CTOPP2RLN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RLN) >= 116 && Convert.ToInt32(testResult.CTOPP2RLN) <= 120)
                    {
                        CTOPP2RLN116to120 = testResult.CTOPP2RLN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RLN) >= 121 && Convert.ToInt32(testResult.CTOPP2RLN) <= 130)
                    {
                        CTOPP2RLN121to130 = testResult.CTOPP2RLN;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2RLN) > 130)
                    {
                        CTOPP2RLN130 = testResult.CTOPP2RLN;
                    }
                }

                if (!string.IsNullOrEmpty(testResult.CTOPP2RSN))
                {
                    CTOPP2RSN69 = " ";
                    CTOPP2RSN70to79 = " ";
                    CTOPP2RSN80to84 = " ";
                    CTOPP2RSN85to89 = " ";
                    CTOPP2RSN90to109 = " ";
                    CTOPP2RSN110to115 = " ";
                    CTOPP2RSN116to120 = " ";
                    CTOPP2RSN121to130 = " ";
                    CTOPP2RSN130 = " ";
                    CTOPP2RSN95CI = " ";
                    if (Convert.ToInt32(testResult.CTOPP2RSN) < 70)
                    {
                        CTOPP2RSN69 = testResult.CTOPP2RSN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RSN) >= 70 && Convert.ToInt32(testResult.CTOPP2RSN) <= 79)
                    {
                        CTOPP2RSN70to79 = testResult.CTOPP2RSN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RSN) >= 80 && Convert.ToInt32(testResult.CTOPP2RSN) <= 84)
                    {
                        CTOPP2RSN80to84 = testResult.CTOPP2RSN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RSN) >= 85 && Convert.ToInt32(testResult.CTOPP2RSN) <= 89)
                    {
                        CTOPP2RSN85to89 = testResult.CTOPP2RSN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RSN) >= 90 && Convert.ToInt32(testResult.CTOPP2RSN) <= 109)
                    {
                        CTOPP2RSN90to109 = testResult.CTOPP2RSN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RSN) >= 110 && Convert.ToInt32(testResult.CTOPP2RSN) <= 115)
                    {
                        CTOPP2RSN110to115 = testResult.CTOPP2RSN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RSN) >= 116 && Convert.ToInt32(testResult.CTOPP2RSN) <= 120)
                    {
                        CTOPP2RSN116to120 = testResult.CTOPP2RSN;
                    }
                    else if (Convert.ToInt32(testResult.CTOPP2RSN) >= 121 && Convert.ToInt32(testResult.CTOPP2RSN) <= 130)
                    {
                        CTOPP2RSN121to130 = testResult.CTOPP2RSN;
                    }
                    if (Convert.ToInt32(testResult.CTOPP2RSN) > 130)
                    {
                        CTOPP2RSN130 = testResult.CTOPP2RSN;
                    }
                }


                if (testResult.WRAT5WR != "")
                {
                    WRAT5WR69 = " ";
                    WRAT5WR70to79 = " ";
                    WRAT5WR80to84 = " ";
                    WRAT5WR85to89 = " ";
                    WRAT5WR90to109 = " ";
                    WRAT5WR110to115 = " ";
                    WRAT5WR116to120 = " ";
                    WRAT5WR121to130 = " ";
                    WRAT5WR130 = " ";
                    WRAT5WR95CI = " ";
                    if (Convert.ToInt32(testResult.WRAT5WR) < 70)
                    {
                        WRAT5WR69 = testResult.WRAT5WR;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5WR) >= 70 && Convert.ToInt32(testResult.WRAT5WR) <= 79)
                    {
                        WRAT5WR70to79 = testResult.WRAT5WR;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5WR) >= 80 && Convert.ToInt32(testResult.WRAT5WR) <= 84)
                    {
                        WRAT5WR80to84 = testResult.WRAT5WR;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5WR) >= 85 && Convert.ToInt32(testResult.WRAT5WR) <= 89)
                    {
                        WRAT5WR85to89 = testResult.WRAT5WR;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5WR) >= 90 && Convert.ToInt32(testResult.WRAT5WR) <= 109)
                    {
                        WRAT5WR90to109 = testResult.WRAT5WR;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5WR) >= 110 && Convert.ToInt32(testResult.WRAT5WR) <= 115)
                    {
                        WRAT5WR110to115 = testResult.WRAT5WR;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5WR) >= 116 && Convert.ToInt32(testResult.WRAT5WR) <= 120)
                    {
                        WRAT5WR116to120 = testResult.WRAT5WR;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5WR) >= 121 && Convert.ToInt32(testResult.WRAT5WR) <= 130)
                    {
                        WRAT5WR121to130 = testResult.WRAT5WR;
                    }
                    if (Convert.ToInt32(testResult.WRAT5WR) > 130)
                    {
                        WRAT5WR130 = testResult.WRAT5WR;
                    }
                }
                if (testResult.WRAT5SP != "")
                {
                    WRAT5SP69 = " ";
                    WRAT5SP70to79 = " ";
                    WRAT5SP80to84 = " ";
                    WRAT5SP85to89 = " ";
                    WRAT5SP90to109 = " ";
                    WRAT5SP110to115 = " ";
                    WRAT5SP116to120 = " ";
                    WRAT5SP121to130 = " ";
                    WRAT5SP130 = " ";
                    WRAT5SP95CI = " ";
                    if (Convert.ToInt32(testResult.WRAT5SP) < 70)
                    {
                        WRAT5SP69 = testResult.WRAT5SP;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5SP) >= 70 && Convert.ToInt32(testResult.WRAT5SP) <= 79)
                    {
                        WRAT5SP70to79 = testResult.WRAT5SP;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5SP) >= 80 && Convert.ToInt32(testResult.WRAT5SP) <= 84)
                    {
                        WRAT5SP80to84 = testResult.WRAT5SP;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5SP) >= 85 && Convert.ToInt32(testResult.WRAT5SP) <= 89)
                    {
                        WRAT5SP85to89 = testResult.WRAT5SP;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5SP) >= 90 && Convert.ToInt32(testResult.WRAT5SP) <= 109)
                    {
                        WRAT5SP90to109 = testResult.WRAT5SP;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5SP) >= 110 && Convert.ToInt32(testResult.WRAT5SP) <= 115)
                    {
                        WRAT5SP110to115 = testResult.WRAT5SP;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5SP) >= 116 && Convert.ToInt32(testResult.WRAT5SP) <= 120)
                    {
                        WRAT5SP116to120 = testResult.WRAT5SP;
                    }
                    else if (Convert.ToInt32(testResult.WRAT5SP) >= 121 && Convert.ToInt32(testResult.WRAT5SP) <= 130)
                    {
                        WRAT5SP121to130 = testResult.WRAT5SP;
                    }
                    if (Convert.ToInt32(testResult.WRAT5SP) > 130)
                    {
                        WRAT5SP130 = testResult.WRAT5SP;
                    }
                }
                if (testResult.TOWRE2SWE != "")
                {
                    TOWRE2SWE69 = " ";
                    TOWRE2SWE70to79 = " ";
                    TOWRE2SWE80to84 = " ";
                    TOWRE2SWE85to89 = " ";
                    TOWRE2SWE90to109 = " ";
                    TOWRE2SWE110to115 = " ";
                    TOWRE2SWE116to120 = " ";
                    TOWRE2SWE121to130 = " ";
                    TOWRE2SWE130 = " ";
                    if (Convert.ToInt32(testResult.TOWRE2SWE) < 70)
                    {
                        TOWRE2SWE69 = testResult.TOWRE2SWE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2SWE) >= 70 && Convert.ToInt32(testResult.TOWRE2SWE) <= 79)
                    {
                        TOWRE2SWE70to79 = testResult.TOWRE2SWE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2SWE) >= 80 && Convert.ToInt32(testResult.TOWRE2SWE) <= 84)
                    {
                        TOWRE2SWE80to84 = testResult.TOWRE2SWE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2SWE) >= 85 && Convert.ToInt32(testResult.TOWRE2SWE) <= 89)
                    {
                        TOWRE2SWE85to89 = testResult.TOWRE2SWE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2SWE) >= 90 && Convert.ToInt32(testResult.TOWRE2SWE) <= 109)
                    {
                        TOWRE2SWE90to109 = testResult.TOWRE2SWE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2SWE) >= 110 && Convert.ToInt32(testResult.TOWRE2SWE) <= 115)
                    {
                        TOWRE2SWE110to115 = testResult.TOWRE2SWE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2SWE) >= 116 && Convert.ToInt32(testResult.TOWRE2SWE) <= 120)
                    {
                        TOWRE2SWE116to120 = testResult.TOWRE2SWE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2SWE) >= 121 && Convert.ToInt32(testResult.TOWRE2SWE) <= 130)
                    {
                        TOWRE2SWE121to130 = testResult.TOWRE2SWE;
                    }
                    if (Convert.ToInt32(testResult.TOWRE2SWE) > 130)
                    {
                        TOWRE2SWE130 = testResult.TOWRE2SWE;
                    }
                }
                if (testResult.TOWRE2PDE != "")
                {
                    TOWRE2PDE69 = " ";
                    TOWRE2PDE70to79 = " ";
                    TOWRE2PDE80to84 = " ";
                    TOWRE2PDE85to89 = " ";
                    TOWRE2PDE90to109 = " ";
                    TOWRE2PDE110to115 = " ";
                    TOWRE2PDE116to120 = " ";
                    TOWRE2PDE121to130 = " ";
                    TOWRE2PDE130 = " ";
                    if (Convert.ToInt32(testResult.TOWRE2PDE) < 70)
                    {
                        TOWRE2PDE69 = testResult.TOWRE2PDE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2PDE) >= 70 && Convert.ToInt32(testResult.TOWRE2PDE) <= 79)
                    {
                        TOWRE2PDE70to79 = testResult.TOWRE2PDE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2PDE) >= 80 && Convert.ToInt32(testResult.TOWRE2PDE) <= 84)
                    {
                        TOWRE2PDE80to84 = testResult.TOWRE2PDE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2PDE) >= 85 && Convert.ToInt32(testResult.TOWRE2PDE) <= 89)
                    {
                        TOWRE2PDE85to89 = testResult.TOWRE2PDE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2PDE) >= 90 && Convert.ToInt32(testResult.TOWRE2PDE) <= 109)
                    {
                        TOWRE2PDE90to109 = testResult.TOWRE2PDE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2PDE) >= 110 && Convert.ToInt32(testResult.TOWRE2PDE) <= 115)
                    {
                        TOWRE2PDE110to115 = testResult.TOWRE2PDE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2PDE) >= 116 && Convert.ToInt32(testResult.TOWRE2PDE) <= 120)
                    {
                        TOWRE2PDE116to120 = testResult.TOWRE2PDE;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2PDE) >= 121 && Convert.ToInt32(testResult.TOWRE2PDE) <= 130)
                    {
                        TOWRE2PDE121to130 = testResult.TOWRE2PDE;
                    }
                    if (Convert.ToInt32(testResult.TOWRE2PDE) > 130)
                    {
                        TOWRE2PDE130 = testResult.TOWRE2PDE;
                    }
                }
                if (testResult.TOWRE2IND != "")
                {
                    TOWRE2IND69 = " ";
                    TOWRE2IND70to79 = " ";
                    TOWRE2IND80to84 = " ";
                    TOWRE2IND85to89 = " ";
                    TOWRE2IND90to109 = " ";
                    TOWRE2IND110to115 = " ";
                    TOWRE2IND116to120 = " ";
                    TOWRE2IND121to130 = " ";
                    TOWRE2IND130 = " ";
                    TOWRE2IND95CI = " ";
                    if (Convert.ToInt32(testResult.TOWRE2IND) < 70)
                    {
                        TOWRE2IND69 = testResult.TOWRE2IND;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2IND) >= 70 && Convert.ToInt32(testResult.TOWRE2IND) <= 79)
                    {
                        TOWRE2IND70to79 = testResult.TOWRE2IND;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2IND) >= 80 && Convert.ToInt32(testResult.TOWRE2IND) <= 84)
                    {
                        TOWRE2IND80to84 = testResult.TOWRE2IND;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2IND) >= 85 && Convert.ToInt32(testResult.TOWRE2IND) <= 89)
                    {
                        TOWRE2IND85to89 = testResult.TOWRE2IND;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2IND) >= 90 && Convert.ToInt32(testResult.TOWRE2IND) <= 109)
                    {
                        TOWRE2IND90to109 = testResult.TOWRE2IND;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2IND) >= 110 && Convert.ToInt32(testResult.TOWRE2IND) <= 115)
                    {
                        TOWRE2IND110to115 = testResult.TOWRE2IND;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2IND) >= 116 && Convert.ToInt32(testResult.TOWRE2IND) <= 120)
                    {
                        TOWRE2IND116to120 = testResult.TOWRE2IND;
                    }
                    else if (Convert.ToInt32(testResult.TOWRE2IND) >= 121 && Convert.ToInt32(testResult.TOWRE2IND) <= 130)
                    {
                        TOWRE2IND121to130 = testResult.TOWRE2IND;
                    }
                    if (Convert.ToInt32(testResult.TOWRE2IND) > 130)
                    {
                        TOWRE2IND130 = testResult.TOWRE2IND;
                    }
                }
                if (testResult.ART2SC != "")
                {
                    ART2SC69 = " ";
                    ART2SC70to79 = " ";
                    ART2SC80to84 = " ";
                    ART2SC85to89 = " ";
                    ART2SC90to109 = " ";
                    ART2SC110to115 = " ";
                    ART2SC116to120 = " ";
                    ART2SC121to130 = " ";
                    ART2SC130 = " ";
                    if (Convert.ToInt32(testResult.ART2SC) < 70)
                    {
                        ART2SC69 = testResult.ART2SC;
                    }
                    else if (Convert.ToInt32(testResult.ART2SC) >= 70 && Convert.ToInt32(testResult.ART2SC) <= 79)
                    {
                        ART2SC70to79 = testResult.ART2SC;
                    }
                    else if (Convert.ToInt32(testResult.ART2SC) >= 80 && Convert.ToInt32(testResult.ART2SC) <= 84)
                    {
                        ART2SC80to84 = testResult.ART2SC;
                    }
                    else if (Convert.ToInt32(testResult.ART2SC) >= 85 && Convert.ToInt32(testResult.ART2SC) <= 89)
                    {
                        ART2SC85to89 = testResult.ART2SC;
                    }
                    else if (Convert.ToInt32(testResult.ART2SC) >= 90 && Convert.ToInt32(testResult.ART2SC) <= 109)
                    {
                        ART2SC90to109 = testResult.ART2SC;
                    }
                    else if (Convert.ToInt32(testResult.ART2SC) >= 110 && Convert.ToInt32(testResult.ART2SC) <= 115)
                    {
                        ART2SC110to115 = testResult.ART2SC;
                    }
                    else if (Convert.ToInt32(testResult.ART2SC) >= 116 && Convert.ToInt32(testResult.ART2SC) <= 120)
                    {
                        ART2SC116to120 = testResult.ART2SC;
                    }
                    else if (Convert.ToInt32(testResult.ART2SC) >= 121 && Convert.ToInt32(testResult.ART2SC) <= 130)
                    {
                        ART2SC121to130 = testResult.ART2SC;
                    }
                    if (Convert.ToInt32(testResult.ART2SC) > 130)
                    {
                        ART2SC130 = testResult.ART2SC;
                    }
                }
                ART2RA = testResult.ART2RA;
                ART2SR = testResult.ART2SR;
                ART2HW = testResult.HandWriting;
                ART2TY = testResult.Typing;

                Art2Chart = GetPercentage(testResult.ART2SR);
                Art2ChartVal = testResult.ART2SR;
                Towre2Chart = GetPercentage(testResult.TOWRE2SWE);
                Towre2ChartVal = testResult.TOWRE2SWE;
                Wrat5SChart = GetPercentage(testResult.WRAT5SP);
                Wrat5SChartVal = testResult.WRAT5SP;
                Wrat5RChart = GetPercentage(testResult.WRAT5WR);
                Wrat5RChartVal = testResult.WRAT5WR;
                Ctopp2RSNChart = GetPercentage(testResult.CTOPP2RSN);
                Ctopp2RSNChartVal = testResult.CTOPP2RSN;
                Ctopp2PAChart = GetPercentage(testResult.CTOPP2PAC);
                Ctopp2PAChartVal = testResult.CTOPP2PAC;
                Ctopp2PMChart = GetPercentage(testResult.CTOPP2PM);
                Ctopp2PMChartVal = testResult.CTOPP2PM;
                WMChart = GetPercentage(testResult.WRITMAT);
                WMChartVal = testResult.WRITMAT;
                NVRChart = GetPercentage(testResult.WRITVB);
                NVRChartVal = testResult.WRITVB;
                VRVChart = GetPercentage(testResult.WRITVC);
                VRVChartVal = testResult.WRITVC;
                VRVAChart = GetPercentage(testResult.WRITVA);
                VRVAChartVal = testResult.WRITVA;


                #endregion


                #region placeholders

                placeholders.Add("[WRITVA69]", WRITVA69);
                placeholders.Add("[WRITVA70to79]", WRITVA70to79);
                placeholders.Add("[WRITVA80to84]", WRITVA80to84);
                placeholders.Add("[WRITVA85to89]", WRITVA85to89);
                placeholders.Add("[WRITVA90to109]", WRITVA90to109);
                placeholders.Add("[WRITVA110to115]", WRITVA110to115);
                placeholders.Add("[WRITVA116to120]", WRITVA116to120);
                placeholders.Add("[WRITVA121to130]", WRITVA121to130);
                placeholders.Add("[WRITVA130]", WRITVA130);
                //
                placeholders.Add("[WRITVC69]", WRITVC69);
                placeholders.Add("[WRITVC70to79]", WRITVC70to79);
                placeholders.Add("[WRITVC80to84]", WRITVC80to84);
                placeholders.Add("[WRITVC85to89]", WRITVC85to89);
                placeholders.Add("[WRITVC90to109]", WRITVC90to109);
                placeholders.Add("[WRITVC110to115]", WRITVC110to115);
                placeholders.Add("[WRITVC116to120]", WRITVC116to120);
                placeholders.Add("[WRITVC121to130]", WRITVC121to130);
                placeholders.Add("[WRITVC130]", WRITVC130);
                // 
                placeholders.Add("[WRITVB69]", WRITVB69);
                placeholders.Add("[WRITVB70to79]", WRITVB70to79);
                placeholders.Add("[WRITVB80to84]", WRITVB80to84);
                placeholders.Add("[WRITVB85to89]", WRITVB85to89);
                placeholders.Add("[WRITVB90to109]", WRITVB90to109);
                placeholders.Add("[WRITVB110to115]", WRITVB110to115);
                placeholders.Add("[WRITVB116to120]", WRITVB116to120);
                placeholders.Add("[WRITVB121to130]", WRITVB121to130);
                placeholders.Add("[WRITVB130]", WRITVB130);
                placeholders.Add("[WRITVB95CI]", WRITVB95CI);
                placeholders.Add("[WRITMT69]", WRITMT69);
                placeholders.Add("[WRITMT70to79]", WRITMT70to79);
                placeholders.Add("[WRITMT80to84]", WRITMT80to84);
                placeholders.Add("[WRITMT85to89]", WRITMT85to89);
                placeholders.Add("[WRITMT90to109]", WRITMT90to109);
                placeholders.Add("[WRITMT110to115]", WRITMT110to115);
                placeholders.Add("[WRITMT116to120]", WRITMT116to120);
                placeholders.Add("[WRITMT121to130]", WRITMT121to130);
                placeholders.Add("[WRITMT130]", WRITMT130);
                // 
                placeholders.Add("[TOMAL2DF69]", TOMAL2DF69);
                placeholders.Add("[TOMAL2DF70to79]", TOMAL2DF70to79);
                placeholders.Add("[TOMAL2DF80to84]", TOMAL2DF80to84);
                placeholders.Add("[TOMAL2DF85to89]", TOMAL2DF85to89);
                placeholders.Add("[TOMAL2DF90to109]", TOMAL2DF90to109);
                placeholders.Add("[TOMAL2DF110to115]", TOMAL2DF110to115);
                placeholders.Add("[TOMAL2DF116to120]", TOMAL2DF116to120);
                placeholders.Add("[TOMAL2DF121to130]", TOMAL2DF121to130);
                placeholders.Add("[TOMAL2DF130]", TOMAL2DF130);
                // 
                placeholders.Add("[TOMAL2LF69]", TOMAL2LF69);
                placeholders.Add("[TOMAL2LF70to79]", TOMAL2LF70to79);
                placeholders.Add("[TOMAL2LF80to84]", TOMAL2LF80to84);
                placeholders.Add("[TOMAL2LF85to89]", TOMAL2LF85to89);
                placeholders.Add("[TOMAL2LF90to109]", TOMAL2LF90to109);
                placeholders.Add("[TOMAL2LF110to115]", TOMAL2LF110to115);
                placeholders.Add("[TOMAL2LF116to120]", TOMAL2LF116to120);
                placeholders.Add("[TOMAL2LF121to130]", TOMAL2LF121to130);
                placeholders.Add("[TOMAL2LF130]", TOMAL2LF130);
                // 
                placeholders.Add("[TOMAL2DB69]", TOMAL2DB69);
                placeholders.Add("[TOMAL2DB70to79]", TOMAL2DB70to79);
                placeholders.Add("[TOMAL2DB80to84]", TOMAL2DB80to84);
                placeholders.Add("[TOMAL2DB85to89]", TOMAL2DB85to89);
                placeholders.Add("[TOMAL2DB90to109]", TOMAL2DB90to109);
                placeholders.Add("[TOMAL2DB110to115]", TOMAL2DB110to115);
                placeholders.Add("[TOMAL2DB116to120]", TOMAL2DB116to120);
                placeholders.Add("[TOMAL2DB121to130]", TOMAL2DB121to130);
                placeholders.Add("[TOMAL2DB130]", TOMAL2DB130);
                // 
                placeholders.Add("[TOMAL2LB69]", TOMAL2LB69);
                placeholders.Add("[TOMAL2LB70to79]", TOMAL2LB70to79);
                placeholders.Add("[TOMAL2LB80to84]", TOMAL2LB80to84);
                placeholders.Add("[TOMAL2LB85to89]", TOMAL2LB85to89);
                placeholders.Add("[TOMAL2LB90to109]", TOMAL2LB90to109);
                placeholders.Add("[TOMAL2LB110to115]", TOMAL2LB110to115);
                placeholders.Add("[TOMAL2LB116to120]", TOMAL2LB116to120);
                placeholders.Add("[TOMAL2LB121to130]", TOMAL2LB121to130);
                placeholders.Add("[TOMAL2LB130]", TOMAL2LB130);
                // 
                placeholders.Add("[TOMAL2ACI69]", TOMAL2ACI69);
                placeholders.Add("[TOMAL2ACI70to79]", TOMAL2ACI70to79);
                placeholders.Add("[TOMAL2ACI80to84]", TOMAL2ACI80to84);
                placeholders.Add("[TOMAL2ACI85to89]", TOMAL2ACI85to89);
                placeholders.Add("[TOMAL2ACI90to109]", TOMAL2ACI90to109);
                placeholders.Add("[TOMAL2ACI110to115]", TOMAL2ACI110to115);
                placeholders.Add("[TOMAL2ACI116to120]", TOMAL2ACI116to120);
                placeholders.Add("[TOMAL2ACI121to130]", TOMAL2ACI121to130);
                placeholders.Add("[TOMAL2ACI130]", TOMAL2ACI130);
                placeholders.Add("[TOMAL2ACI95CI]", TOMAL2ACI95CI);
                placeholders.Add("[CTOPP2MD69]", CTOPP2MD69);
                placeholders.Add("[CTOPP2MD70to79]", CTOPP2MD70to79);
                placeholders.Add("[CTOPP2MD80to84]", CTOPP2MD80to84);
                placeholders.Add("[CTOPP2MD85to89]", CTOPP2MD85to89);
                placeholders.Add("[CTOPP2MD90to109]", CTOPP2MD90to109);
                placeholders.Add("[CTOPP2MD110to115]", CTOPP2MD110to115);
                placeholders.Add("[CTOPP2MD116to120]", CTOPP2MD116to120);
                placeholders.Add("[CTOPP2MD121to130]", CTOPP2MD121to130);
                placeholders.Add("[CTOPP2MD130]", CTOPP2MD130);
                // 
                placeholders.Add("[CTOPP2NWR69]", CTOPP2NWR69);
                placeholders.Add("[CTOPP2NWR70to79]", CTOPP2NWR70to79);
                placeholders.Add("[CTOPP2NWR80to84]", CTOPP2NWR80to84);
                placeholders.Add("[CTOPP2NWR85to89]", CTOPP2NWR85to89);
                placeholders.Add("[CTOPP2NWR90to109]", CTOPP2NWR90to109);
                placeholders.Add("[CTOPP2NWR110to115]", CTOPP2NWR110to115);
                placeholders.Add("[CTOPP2NWR116to120]", CTOPP2NWR116to120);
                placeholders.Add("[CTOPP2NWR121to130]", CTOPP2NWR121to130);
                placeholders.Add("[CTOPP2NWR130]", CTOPP2NWR130);
                // 
                placeholders.Add("[CTOPP2PM69]", CTOPP2PM69);
                placeholders.Add("[CTOPP2PM70to79]", CTOPP2PM70to79);
                placeholders.Add("[CTOPP2PM80to84]", CTOPP2PM80to84);
                placeholders.Add("[CTOPP2PM85to89]", CTOPP2PM85to89);
                placeholders.Add("[CTOPP2PM90to109]", CTOPP2PM90to109);
                placeholders.Add("[CTOPP2PM110to115]", CTOPP2PM110to115);
                placeholders.Add("[CTOPP2PM116to120]", CTOPP2PM116to120);
                placeholders.Add("[CTOPP2PM121to130]", CTOPP2PM121to130);
                placeholders.Add("[CTOPP2PM130]", CTOPP2PM130);
                placeholders.Add("[CTOPP2PM95CI]", CTOPP2PM95CI);
                placeholders.Add("[CTOPP2EL69]", CTOPP2EL69);
                placeholders.Add("[CTOPP2EL70to79]", CTOPP2EL70to79);
                placeholders.Add("[CTOPP2EL80to84]", CTOPP2EL80to84);
                placeholders.Add("[CTOPP2EL85to89]", CTOPP2EL85to89);
                placeholders.Add("[CTOPP2EL90to109]", CTOPP2EL90to109);
                placeholders.Add("[CTOPP2EL110to115]", CTOPP2EL110to115);
                placeholders.Add("[CTOPP2EL116to120]", CTOPP2EL116to120);
                placeholders.Add("[CTOPP2EL121to130]", CTOPP2EL121to130);
                placeholders.Add("[CTOPP2EL130]", CTOPP2EL130);
                // 
                placeholders.Add("[CTOPP2BW69]", CTOPP2BW69);
                placeholders.Add("[CTOPP2BW70to79]", CTOPP2BW70to79);
                placeholders.Add("[CTOPP2BW80to84]", CTOPP2BW80to84);
                placeholders.Add("[CTOPP2BW85to89]", CTOPP2BW85to89);
                placeholders.Add("[CTOPP2BW90to109]", CTOPP2BW90to109);
                placeholders.Add("[CTOPP2BW110to115]", CTOPP2BW110to115);
                placeholders.Add("[CTOPP2BW116to120]", CTOPP2BW116to120);
                placeholders.Add("[CTOPP2BW121to130]", CTOPP2BW121to130);
                placeholders.Add("[CTOPP2BW130]", CTOPP2BW130);
                // 
                placeholders.Add("[CTOPP2PI69]", CTOPP2PI69);
                placeholders.Add("[CTOPP2PI70to79]", CTOPP2PI70to79);
                placeholders.Add("[CTOPP2PI80to84]", CTOPP2PI80to84);
                placeholders.Add("[CTOPP2PI85to89]", CTOPP2PI85to89);
                placeholders.Add("[CTOPP2PI90to109]", CTOPP2PI90to109);
                placeholders.Add("[CTOPP2PI110to115]", CTOPP2PI110to115);
                placeholders.Add("[CTOPP2PI116to120]", CTOPP2PI116to120);
                placeholders.Add("[CTOPP2PI121to130]", CTOPP2PI121to130);
                placeholders.Add("[CTOPP2PI130]", CTOPP2PI130);
                // 
                placeholders.Add("[CTOPP2PAC69]", CTOPP2PAC69);
                placeholders.Add("[CTOPP2PAC70to79]", CTOPP2PAC70to79);
                placeholders.Add("[CTOPP2PAC80to84]", CTOPP2PAC80to84);
                placeholders.Add("[CTOPP2PAC85to89]", CTOPP2PAC85to89);
                placeholders.Add("[CTOPP2PAC90to109]", CTOPP2PAC90to109);
                placeholders.Add("[CTOPP2PAC110to115]", CTOPP2PAC110to115);
                placeholders.Add("[CTOPP2PAC116to120]", CTOPP2PAC116to120);
                placeholders.Add("[CTOPP2PAC121to130]", CTOPP2PAC121to130);
                placeholders.Add("[CTOPP2PAC130]", CTOPP2PAC130);
                placeholders.Add("[CTOPP2PAC95CI]", CTOPP2PAC95CI);
                placeholders.Add("[CTOPP2BNW69]", CTOPP2BNW69);
                placeholders.Add("[CTOPP2BNW70to79]", CTOPP2BNW70to79);
                placeholders.Add("[CTOPP2BNW80to84]", CTOPP2BNW80to84);
                placeholders.Add("[CTOPP2BNW85to89]", CTOPP2BNW85to89);
                placeholders.Add("[CTOPP2BNW90to109]", CTOPP2BNW90to109);
                placeholders.Add("[CTOPP2BNW110to115]", CTOPP2BNW110to115);
                placeholders.Add("[CTOPP2BNW116to120]", CTOPP2BNW116to120);
                placeholders.Add("[CTOPP2BNW121to130]", CTOPP2BNW121to130);
                placeholders.Add("[CTOPP2BNW130]", CTOPP2BNW130);
                // 
                placeholders.Add("[CTOPP2SNW69]", CTOPP2SNW69);
                placeholders.Add("[CTOPP2SNW70to79]", CTOPP2SNW70to79);
                placeholders.Add("[CTOPP2SNW80to84]", CTOPP2SNW80to84);
                placeholders.Add("[CTOPP2SNW85to89]", CTOPP2SNW85to89);
                placeholders.Add("[CTOPP2SNW90to109]", CTOPP2SNW90to109);
                placeholders.Add("[CTOPP2SNW110to115]", CTOPP2SNW110to115);
                placeholders.Add("[CTOPP2SNW116to120]", CTOPP2SNW116to120);
                placeholders.Add("[CTOPP2SNW121to130]", CTOPP2SNW121to130);
                placeholders.Add("[CTOPP2SNW130]", CTOPP2SNW130);
                // 
                placeholders.Add("[CTOPP2APC69]", CTOPP2APC69);
                placeholders.Add("[CTOPP2APC70to79]", CTOPP2APC70to79);
                placeholders.Add("[CTOPP2APC80to84]", CTOPP2APC80to84);
                placeholders.Add("[CTOPP2APC85to89]", CTOPP2APC85to89);
                placeholders.Add("[CTOPP2APC90to109]", CTOPP2APC90to109);
                placeholders.Add("[CTOPP2APC110to115]", CTOPP2APC110to115);
                placeholders.Add("[CTOPP2APC116to120]", CTOPP2APC116to120);
                placeholders.Add("[CTOPP2APC121to130]", CTOPP2APC121to130);
                placeholders.Add("[CTOPP2APC130]", CTOPP2APC130);
                placeholders.Add("[CTOPP2APC95CI]", CTOPP2APC95CI);
                placeholders.Add("[CTOPP2RDN69]", CTOPP2RDN69);
                placeholders.Add("[CTOPP2RDN70to79]", CTOPP2RDN70to79);
                placeholders.Add("[CTOPP2RDN80to84]", CTOPP2RDN80to84);
                placeholders.Add("[CTOPP2RDN85to89]", CTOPP2RDN85to89);
                placeholders.Add("[CTOPP2RDN90to109]", CTOPP2RDN90to109);
                placeholders.Add("[CTOPP2RDN110to115]", CTOPP2RDN110to115);
                placeholders.Add("[CTOPP2RDN116to120]", CTOPP2RDN116to120);
                placeholders.Add("[CTOPP2RDN121to130]", CTOPP2RDN121to130);
                placeholders.Add("[CTOPP2RDN130]", CTOPP2RDN130);
                // 
                placeholders.Add("[CTOPP2RLN69]", CTOPP2RLN69);
                placeholders.Add("[CTOPP2RLN70to79]", CTOPP2RLN70to79);
                placeholders.Add("[CTOPP2RLN80to84]", CTOPP2RLN80to84);
                placeholders.Add("[CTOPP2RLN85to89]", CTOPP2RLN85to89);
                placeholders.Add("[CTOPP2RLN90to109]", CTOPP2RLN90to109);
                placeholders.Add("[CTOPP2RLN110to115]", CTOPP2RLN110to115);
                placeholders.Add("[CTOPP2RLN116to120]", CTOPP2RLN116to120);
                placeholders.Add("[CTOPP2RLN121to130]", CTOPP2RLN121to130);
                placeholders.Add("[CTOPP2RLN130]", CTOPP2RLN130);
                // 
                placeholders.Add("[CTOPP2RSN69]", CTOPP2RSN69);
                placeholders.Add("[CTOPP2RSN70to79]", CTOPP2RSN70to79);
                placeholders.Add("[CTOPP2RSN80to84]", CTOPP2RSN80to84);
                placeholders.Add("[CTOPP2RSN85to89]", CTOPP2RSN85to89);
                placeholders.Add("[CTOPP2RSN90to109]", CTOPP2RSN90to109);
                placeholders.Add("[CTOPP2RSN110to115]", CTOPP2RSN110to115);
                placeholders.Add("[CTOPP2RSN116to120]", CTOPP2RSN116to120);
                placeholders.Add("[CTOPP2RSN121to130]", CTOPP2RSN121to130);
                placeholders.Add("[CTOPP2RSN130]", CTOPP2RSN130);
                placeholders.Add("[CTOPP2RSN95CI]", CTOPP2RSN95CI);
                placeholders.Add("[WRAT5WR69]", WRAT5WR69);
                placeholders.Add("[WRAT5WR70to79]", WRAT5WR70to79);
                placeholders.Add("[WRAT5WR80to84]", WRAT5WR80to84);
                placeholders.Add("[WRAT5WR85to89]", WRAT5WR85to89);
                placeholders.Add("[WRAT5WR90to109]", WRAT5WR90to109);
                placeholders.Add("[WRAT5WR110to115]", WRAT5WR110to115);
                placeholders.Add("[WRAT5WR116to120]", WRAT5WR116to120);
                placeholders.Add("[WRAT5WR121to130]", WRAT5WR121to130);
                placeholders.Add("[WRAT5WR130]", WRAT5WR130);
                placeholders.Add("[WRAT5WR95CI]", WRAT5WR95CI);
                placeholders.Add("[WRAT5SP69]", WRAT5SP69);
                placeholders.Add("[WRAT5SP70to79]", WRAT5SP70to79);
                placeholders.Add("[WRAT5SP80to84]", WRAT5SP80to84);
                placeholders.Add("[WRAT5SP85to89]", WRAT5SP85to89);
                placeholders.Add("[WRAT5SP90to109]", WRAT5SP90to109);
                placeholders.Add("[WRAT5SP110to115]", WRAT5SP110to115);
                placeholders.Add("[WRAT5SP116to120]", WRAT5SP116to120);
                placeholders.Add("[WRAT5SP121to130]", WRAT5SP121to130);
                placeholders.Add("[WRAT5SP130]", WRAT5SP130);
                placeholders.Add("[WRAT5SP95CI]", WRAT5SP95CI);
                placeholders.Add("[TOWRE2SWE69]", TOWRE2SWE69);
                placeholders.Add("[TOWRE2SWE70to79]", TOWRE2SWE70to79);
                placeholders.Add("[TOWRE2SWE80to84]", TOWRE2SWE80to84);
                placeholders.Add("[TOWRE2SWE85to89]", TOWRE2SWE85to89);
                placeholders.Add("[TOWRE2SWE90to109]", TOWRE2SWE90to109);
                placeholders.Add("[TOWRE2SWE110to115]", TOWRE2SWE110to115);
                placeholders.Add("[TOWRE2SWE116to120]", TOWRE2SWE116to120);
                placeholders.Add("[TOWRE2SWE121to130]", TOWRE2SWE121to130);
                placeholders.Add("[TOWRE2SWE130]", TOWRE2SWE130);
                // 
                placeholders.Add("[TOWRE2PDE69]", TOWRE2PDE69);
                placeholders.Add("[TOWRE2PDE70to79]", TOWRE2PDE70to79);
                placeholders.Add("[TOWRE2PDE80to84]", TOWRE2PDE80to84);
                placeholders.Add("[TOWRE2PDE85to89]", TOWRE2PDE85to89);
                placeholders.Add("[TOWRE2PDE90to109]", TOWRE2PDE90to109);
                placeholders.Add("[TOWRE2PDE110to115]", TOWRE2PDE110to115);
                placeholders.Add("[TOWRE2PDE116to120]", TOWRE2PDE116to120);
                placeholders.Add("[TOWRE2PDE121to130]", TOWRE2PDE121to130);
                placeholders.Add("[TOWRE2PDE130]", TOWRE2PDE130);
                // 
                placeholders.Add("[TOWRE2IND69]", TOWRE2IND69);
                placeholders.Add("[TOWRE2IND70to79]", TOWRE2IND70to79);
                placeholders.Add("[TOWRE2IND80to84]", TOWRE2IND80to84);
                placeholders.Add("[TOWRE2IND85to89]", TOWRE2IND85to89);
                placeholders.Add("[TOWRE2IND90to109]", TOWRE2IND90to109);
                placeholders.Add("[TOWRE2IND110to115]", TOWRE2IND110to115);
                placeholders.Add("[TOWRE2IND116to120]", TOWRE2IND116to120);
                placeholders.Add("[TOWRE2IND121to130]", TOWRE2IND121to130);
                placeholders.Add("[TOWRE2IND130]", TOWRE2IND130);
                placeholders.Add("[TOWRE2IND95CI]", TOWRE2IND95CI);
                placeholders.Add("[ART2SC69]", ART2SC69);
                placeholders.Add("[ART2SC70to79]", ART2SC70to79);
                placeholders.Add("[ART2SC80to84]", ART2SC80to84);
                placeholders.Add("[ART2SC85to89]", ART2SC85to89);
                placeholders.Add("[ART2SC90to109]", ART2SC90to109);
                placeholders.Add("[ART2SC110to115]", ART2SC110to115);
                placeholders.Add("[ART2SC116to120]", ART2SC116to120);
                placeholders.Add("[ART2SC121to130]", ART2SC121to130);
                placeholders.Add("[ART2SC130]", ART2SC130);
                // 
                placeholders.Add("[ART2RA]", ART2RA);
                placeholders.Add("[ART2SR]", ART2SR);
                placeholders.Add("[ART2HW]", ART2HW);
                placeholders.Add("[ART2TY]", ART2TY);

                #endregion


                using (WordprocessingDocument doc = WordprocessingDocument.Open(outputPath, true))
                {

                    MainDocumentPart mainPart = doc.MainDocumentPart;

                    foreach (DocumentFormat.OpenXml.Wordprocessing.Text text in mainPart.Document.Body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Text>())
                    {

                        foreach (var placeholder in placeholders.Keys)
                        {
                            if (text.Text.Contains(placeholder))
                            {
                                text.Text = text.Text.Replace(placeholder, placeholders[placeholder]);
                            }
                        }
                    }

                    // ss
                    var chartParts = mainPart.ChartParts;
                    int i=0, j=85;

                    int[] chartData = new int[] { 
                        Convert.ToInt32(Art2ChartVal) ,
                        Convert.ToInt32(Towre2ChartVal) ,
                        Convert.ToInt32(Wrat5SChartVal) ,
                        Convert.ToInt32(Wrat5RChartVal) ,
                        Convert.ToInt32(Ctopp2RSNChartVal) ,
                        Convert.ToInt32(Ctopp2PAChartVal) ,
                        Convert.ToInt32(Ctopp2PMChartVal) ,
                        Convert.ToInt32(WMChartVal) ,
                        Convert.ToInt32(NVRChartVal) ,
                        Convert.ToInt32(VRVChartVal) ,
                        Convert.ToInt32(VRVAChartVal) ,

                    };
                    

                    foreach (var chartPart in chartParts)
                    {
                        var chart = chartPart.ChartSpace.Elements<DocumentFormat.OpenXml.Drawing.Charts.Chart>().FirstOrDefault();
                        if (chart != null)
                        {
                            var plotArea = chart.Descendants<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>().FirstOrDefault();
                            if (plotArea != null)
                            {
                                var seriesDatas = plotArea.Descendants<DocumentFormat.OpenXml.Drawing.Charts.Values>();
                                foreach (var seriesData in seriesDatas)
                                {
                                    if (seriesData != null)
                                    {
                                        var chartComp = seriesData.Descendants<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>().ToList();
                                        foreach (var item in chartComp)
                                        {
                                            item.NumericValue = new DocumentFormat.OpenXml.Drawing.Charts.NumericValue($"{chartData[i]}");
                                            i++;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    doc.Save();
                }

                if (System.IO.File.Exists(outputPath))
                {
                    var fileName = System.IO.Path.GetFileName(outputPath);
                    var response = System.IO.File.ReadAllBytes(outputPath);
                    return File(response, "application/octet-stream", fileName);
                }

            }

            // Replace "template.docx" with the path to your actual template

            return BadRequest();
        }

        public static string GetPercentage(string val)
        {
            return $"{Math.Round(Convert.ToDouble(val) / 140 * 100)}%";
        }

        private ClientReportDto GetClientTests(Guid clientId)
        {
            ClientReportDto clientReport = new ClientReportDto();
            var client = _dbContext.Clients.FirstOrDefault(x => x.Id == clientId);
            if (client == null)
            {
                return null;
            }

            var writ =  _dbContext.ClientWRITDetails.FirstOrDefault(x => x.ClientId == clientId);
            if (writ != null)
            {
                clientReport.WRITVA = writ.vaStandardScore;
                clientReport.WRITVC = writ.vcStandardScore;
                clientReport.WRITMAT = writ.maStandardScore;
                clientReport.WRITVB = writ.diStandardScore;
            }

            var tomal =  _dbContext.ClientTOMALDetails.FirstOrDefault(x => x.ClientId == clientId);
            if (tomal != null)
            {
                clientReport.TOMAL2DF = (tomal.ofVerbalScaleScore * 5 + 50).ToString();
                clientReport.TOMAL2LF = (tomal.lfVerbalScaleScore * 5 + 50).ToString();
                clientReport.TOMAL2DB = (tomal.dbVerbalScaleScore * 5 + 50).ToString();
                clientReport.TOMAL2LB = (tomal.lbVerbalScaleScore * 5 + 50).ToString();
                clientReport.TOMAL2ACI = tomal.indAci.ToString();
            }

            var ctopp =  _dbContext.ClientCTOPPDetails.FirstOrDefault(x => x.ClientId == clientId);
            if (ctopp != null)
            {
                clientReport.CTOPP2MD = (ctopp.MdScaleScore * 5 + 50).ToString();
                clientReport.CTOPP2NWR = (ctopp.NrScaleScore * 5 + 50).ToString();
                clientReport.CTOPP2PM = ctopp.PMScore.ToString();

                clientReport.CTOPP2EL = (ctopp.ElScaleScore * 5 + 50).ToString();
                clientReport.CTOPP2BW = (ctopp.BwScaleScore * 5 + 50).ToString();
                clientReport.CTOPP2PI = (ctopp.PlScaleScore * 5 + 50).ToString();
                clientReport.CTOPP2PAC = ctopp.PAScore.ToString();

                clientReport.CTOPP2RDN = (ctopp.RdScaleScore * 5 + 50).ToString();
                clientReport.CTOPP2RLN = (ctopp.RlRawScore * 5 + 50).ToString();
                clientReport.CTOPP2RSN = ctopp.RSNScore.ToString();
            }

            var wrat =  _dbContext.ClientWRATDetails.FirstOrDefault(x => x.ClientId == clientId);
            if (wrat != null)
            {
                clientReport.WRAT5WR = wrat.wrStandardScore.ToString();
                clientReport.WRAT5SP = wrat.spStandardScore.ToString();
            }

            var towre =  _dbContext.ClientTOWREDetails.FirstOrDefault(x => x.ClientId == clientId);
            if (towre != null)
            {
                clientReport.TOWRE2SWE = towre.sweScale;
                clientReport.TOWRE2PDE = towre.pdeScale;
                clientReport.TOWRE2IND = "79";
            }

            var art =  _dbContext.ClientARTDetails.FirstOrDefault(x => x.ClientId == clientId);
            if (art != null)
            {
                clientReport.ART2SC = art.SmCompreSilentStd;
                clientReport.ART2RA = art.SmSpeedAloud;
                clientReport.ART2SR = art.SmSpeedSilent;
                clientReport.HandWriting = art.SmWritingSpeed;
                clientReport.Typing = "25";
            }

            return clientReport;
        }

        //using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(templatePath, true))
        //{
        //    // Access the main document part.
        //    MainDocumentPart mainPart = wordDocument.MainDocumentPart;

        //    // Get the body of the document.
        //    Body body = mainPart.Document.Body;


        //    // Iterate through the paragraphs in the body.
        //    foreach (DocumentFormat.OpenXml.Drawing.Paragraph paragraph in body.Elements<DocumentFormat.OpenXml.Drawing.Paragraph>())
        //    {
        //        // Iterate through the runs in each paragraph.
        //        foreach (DocumentFormat.OpenXml.Drawing.Run run in paragraph.Elements<DocumentFormat.OpenXml.Drawing.Run>())
        //        {
        //            // Get the text of the run.
        //            string text = run.InnerText;

        //            // Check if the text contains the placeholder.
        //            if (text.Contains("{{Placeholder}}"))
        //            {
        //                // Replace the placeholder with actual data.
        //                run.GetFirstChild<DocumentFormat.OpenXml.Drawing.Text>().Text = text.Replace("{{Placeholder}}", "Actual Data");
        //            }
        //        }
        //    }

        //    // Save the changes.
        //    mainPart.Document.Save();
        //}

        // Console.WriteLine("Placeholders replaced with actual data.");


        // Define placeholders and their replacement values
        //Dictionary<string, string> placeholders = new Dictionary<string, string>()
        //{
        //    { "[NAME]", "John Doe" },
        //    { "[DATE]", DateTime.Now.ToString("yyyy-MM-dd") }
        //};

        //// Open the template document
        //using (WordprocessingDocument document = WordprocessingDocument.Open(templatePath, true))
        //{
        //    // Access the main document part
        //    MainDocumentPart mainPart = document.MainDocumentPart;

        //    // Iterate through all paragraphs in the document
        //    foreach (var paragraph in mainPart.Document.Body.Elements<Paragraph>())
        //    {
        //        // Process each run within the paragraph 
        //        foreach (var run in paragraph.Elements<Run>())
        //        {
        //            // Check if the run contains text
        //            if (run.HasChildren)
        //            {
        //                var text = run.GetFirstChild<DocumentFormat.OpenXml.Drawing.Text>().Text;

        //                // Replace placeholders with corresponding values
        //                foreach (var placeholder in placeholders.Keys)
        //                {
        //                    if (text.Contains(placeholder))
        //                    {
        //                        text = text.Replace(placeholder, placeholders[placeholder]);
        //                        run.GetFirstChild<DocumentFormat.OpenXml.Drawing.Text>().Text = text;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    using (WordprocessingDocument destinationDocument = (WordprocessingDocument)document.Clone(outputPath))
        //    {
        //        //var s = destinationDocument.MainDocumentPart.GetStream();
        //        //return File(s, "application/octet-stream", "1.docx");
        //    }

        //}

        //if (file != null)
        //{
        //    var fileName = Path.GetFileName(file.Url);
        //    var blobClient = blobContainerClient.GetBlobClient(fileName);
        //    var response = await blobClient.OpenReadAsync();
        //    return File(response, "application/octet-stream", file.Name);
        //}




        [HttpPost]
        [Route("individual/doc/upload")]
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
            string containerName = _configuration["ConnectionStrings:IndividualBlobName"];
            Stream myBlob = new MemoryStream();
            myBlob = image.OpenReadStream();
            var blobClient = new BlobContainerClient(Connection, containerName);
            var blobname = $"{Guid.NewGuid().ToString()}{System.IO.Path.GetExtension(image.FileName)}";
            var blob = blobClient.GetBlobClient(blobname);
            await blob.UploadAsync(myBlob);
            return Ok(blob.Uri);
        }

        [HttpPost]
        [Route("individual/{studentId}/doc")]
        public async Task<ActionResult> SaveStudentDocument([FromRoute] string studentId, List<StudentDocumentDto> studentDocuments)
        {
            if (!studentDocuments.Any())
            {
                return BadRequest();
            }

            _dbContext.StudentDocuments.RemoveRange(_dbContext.StudentDocuments.Where(x => x.StudentId == Guid.Parse(studentId)));
            await _dbContext.SaveChangesAsync();

            foreach (var studentDocumentDto in studentDocuments)
            {
                var doc = _mapper.Map<StudentDocument>(studentDocumentDto);
                doc.StudentId = Guid.Parse(studentId);
                await _dbContext.StudentDocuments.AddAsync(doc);
            }

            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("individual/{studentId}/page1")]
        public async Task<ActionResult> GetStudentPage1([FromRoute] string studentId)
        {

            if (string.IsNullOrEmpty(studentId))
            {
                return BadRequest();
            }

            Guid? id = Guid.Parse(studentId);
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == Guid.Parse(studentId));
            if (user == null)
            {
                id = _dbContext.Clients.FirstOrDefault(x => x.Id == Guid.Parse(studentId))?.UserId;
            }

            var page1 = _dbContext.StudentPage1.FirstOrDefault(x => x.StudentId == id);
            StudentPage1Dto StudentPage1 = _mapper.Map<StudentPage1Dto>(page1);
            return Ok(StudentPage1);
        }

        [HttpPost]
        [Route("individual/{studentId}/page1")]
        public async Task<ActionResult> SaveStudentPage1([FromRoute] string studentId, StudentPage1Dto page1)
        {
            if (page1 == null)
            {
                return BadRequest();
            }

            _dbContext.StudentPage1.RemoveRange(_dbContext.StudentPage1.Where(x => x.StudentId == Guid.Parse(studentId)));
            await _dbContext.SaveChangesAsync();

            var doc = _mapper.Map<StudentPage1>(page1);
            doc.StudentId = Guid.Parse(studentId);
            await _dbContext.StudentPage1.AddAsync(doc);

            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("individual/{studentId}/page2")]
        public async Task<ActionResult> GetStudentPage2([FromRoute] string studentId)
        {

            if (string.IsNullOrEmpty(studentId))
            {
                return BadRequest();
            }
            Guid? id = Guid.Parse(studentId);
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == Guid.Parse(studentId));
            if (user == null)
            {
                id = _dbContext.Clients.FirstOrDefault(x => x.Id == Guid.Parse(studentId))?.UserId;
            }

            var page2 = _dbContext.StudentPage2.FirstOrDefault(x => x.StudentId == id);
            StudentPage2Dto StudentPage2 = _mapper.Map<StudentPage2Dto>(page2);
            return Ok(StudentPage2);
        }


        [HttpPost]
        [Route("individual/{studentId}/page2")]
        public async Task<ActionResult> SaveStudentPage2([FromRoute] string studentId, StudentPage2Dto page2)
        {
            if (page2 == null)
            {
                return BadRequest();
            }

            _dbContext.StudentPage2.RemoveRange(_dbContext.StudentPage2.Where(x => x.StudentId == Guid.Parse(studentId)));
            await _dbContext.SaveChangesAsync();

            var doc = _mapper.Map<StudentPage2>(page2);
            doc.StudentId = Guid.Parse(studentId);
            await _dbContext.StudentPage2.AddAsync(doc);

            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("individual/{studentId}/page3")]
        public async Task<ActionResult> GetStudentPage3([FromRoute] string studentId)
        {

            if (string.IsNullOrEmpty(studentId))
            {
                return BadRequest();
            }

            Guid? id = Guid.Parse(studentId);
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == Guid.Parse(studentId));
            if (user == null)
            {
                id = _dbContext.Clients.FirstOrDefault(x => x.Id == Guid.Parse(studentId))?.UserId;
            }

            var page3 = _dbContext.StudentPage3.FirstOrDefault(x => x.StudentId == id);
            StudentPage3Dto StudentPage3 = _mapper.Map<StudentPage3Dto>(page3);
            return Ok(StudentPage3);
        }


        [HttpPost]
        [Route("individual/{studentId}/page3")]
        public async Task<ActionResult> SaveStudentPage3([FromRoute] string studentId, StudentPage3Dto page3)
        {
            if (page3 == null)
            {
                return BadRequest();
            }

            _dbContext.StudentPage3.RemoveRange(_dbContext.StudentPage3.Where(x => x.StudentId == Guid.Parse(studentId)));
            await _dbContext.SaveChangesAsync();

            var doc = _mapper.Map<StudentPage3>(page3);
            doc.StudentId = Guid.Parse(studentId);
            await _dbContext.StudentPage3.AddAsync(doc);

            await _dbContext.SaveChangesAsync();
            return Ok();
        }


        [HttpGet]
        [Route("individual/{studentId}/page4")]
        public async Task<ActionResult> GetStudentPage4([FromRoute] string studentId)
        {

            if (string.IsNullOrEmpty(studentId))
            {
                return BadRequest();
            }

            Guid? id = Guid.Parse(studentId);
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == Guid.Parse(studentId));
            if (user == null)
            {
                id = _dbContext.Clients.FirstOrDefault(x => x.Id == Guid.Parse(studentId))?.UserId;
            }

            var page4 = _dbContext.StudentPage4.FirstOrDefault(x => x.StudentId == id);
            StudentPage4Dto StudentPage4 = _mapper.Map<StudentPage4Dto>(page4);
            return Ok(StudentPage4);
        }


        [HttpPost]
        [Route("individual/{studentId}/page4")]
        public async Task<ActionResult> SaveStudentPage4([FromRoute] string studentId, StudentPage4Dto page4)
        {
            if (page4 == null)
            {
                return BadRequest();
            }

            _dbContext.StudentPage4.RemoveRange(_dbContext.StudentPage4.Where(x => x.StudentId == Guid.Parse(studentId)));
            await _dbContext.SaveChangesAsync();

            var doc = _mapper.Map<StudentPage4>(page4);
            doc.StudentId = Guid.Parse(studentId);
            await _dbContext.StudentPage4.AddAsync(doc);

            await _dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
