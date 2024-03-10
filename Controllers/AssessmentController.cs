using AIMSService.Entity;
using AIMSService.Model;
using AutoMapper;
using Azure;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using System.IO;
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
                var fileName = Path.GetFileName(file.Url);
                var blobClient = blobContainerClient.GetBlobClient(fileName);
                var response = await blobClient.OpenReadAsync();
                return File(response, "application/octet-stream", file.Name);
            }

            return BadRequest();
        }

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
            var blobname = $"{Guid.NewGuid().ToString()}{Path.GetExtension(image.FileName)}";
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

            var page1 = _dbContext.StudentPage1.FirstOrDefault(x => x.StudentId == Guid.Parse(studentId));
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

            var userId = _dbContext.Clients.FirstOrDefault(x => x.Id == Guid.Parse(studentId))?.UserId;
            if (userId == null)
            {
                return BadRequest();
            }

            var docs = _dbContext.StudentPage2.Where(x => x.StudentId == userId);
            List<StudentPage2Dto> StudentPage2 = _mapper.Map<List<StudentPage2Dto>>(docs);
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

            var userId = _dbContext.Clients.FirstOrDefault(x => x.Id == Guid.Parse(studentId))?.UserId;
            if (userId == null)
            {
                return BadRequest();
            }

            var docs = _dbContext.StudentPage3.Where(x => x.StudentId == userId);
            List<StudentPage3Dto> StudentPage3 = _mapper.Map<List<StudentPage3Dto>>(docs);
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

            var userId = _dbContext.Clients.FirstOrDefault(x => x.Id == Guid.Parse(studentId))?.UserId;
            if (userId == null)
            {
                return BadRequest();
            }

            var docs = _dbContext.StudentPage4.Where(x => x.StudentId == userId);
            List<StudentPage4Dto> StudentPage4 = _mapper.Map<List<StudentPage4Dto>>(docs);
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
