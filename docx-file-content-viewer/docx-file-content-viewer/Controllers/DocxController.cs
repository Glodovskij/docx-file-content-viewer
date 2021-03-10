using docx_file_content_viewer.Domain.DTOs;
using docx_file_content_viewer.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace docx_file_content_viewer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocxController : ControllerBase
    {
        private readonly IDocxFileService _docxFileService;
        private readonly ILogger _logger;
        public DocxController(IDocxFileService fileService, ILogger<DocxController> logger)
        {
            _docxFileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
            _logger = logger ?? throw new ArgumentException(nameof(logger));
        }

        [HttpGet]
        public ActionResult<List<DocxFileDTO>> Get()
        {
            _logger.LogInformation("Get all method called {0}", HttpContext.Request.Path);
            return Ok(_docxFileService.Get());
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _logger.LogInformation("Delete method {0}", HttpContext.Request.Path);
            _docxFileService.Remove(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            _logger.LogInformation("Get method {0}", HttpContext.Request.Path);
            DocxFileDTO docxFile = _docxFileService.Get(id);
           
            return File(docxFile.FileContent, MediaTypeNames.Application.Octet, docxFile.Filename);
        }

        [HttpPost, DisableRequestSizeLimit]
        public ActionResult Post()
        {
            _logger.LogInformation("Post method {0}", HttpContext.Request.Path);
            _docxFileService.Add(Request.Form.Files.ToList());

            return Ok();
        }

    }
}
