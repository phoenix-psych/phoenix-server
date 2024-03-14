using AIMSService.Entity;
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

                        //if (text.Text.Contains("{{Placeholder}}"))
                        //{
                        //    text.Text = text.Text.Replace("{{Placeholder}}", "JJJJJ");
                        //}
                    }

                    doc.Save();
                }

            }

            // Replace "template.docx" with the path to your actual template

            return BadRequest();
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
