using docx_file_content_viewer.Domain.DTOs;
using docx_file_content_viewer.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace docx_file_content_viewer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocxController : ControllerBase
    {
        private readonly IDocxFileService _docxFileService;
        public DocxController(IDocxFileService fileService)
        {
            _docxFileService = fileService;
        }

        [HttpGet]
        public ActionResult<List<DocxFileDTO>> Get()
        {
            return Ok(_docxFileService.Get());
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<DocxFileDTO> Get(long id)
        {
            return Ok();
        }

        [HttpPost, DisableRequestSizeLimit]
        public ActionResult Post()
        {
            var files = Request.Form.Files;
            files[0].OpenReadStream();
           
             StreamReader reader = new StreamReader(files[0].OpenReadStream());

            var str = reader.ReadToEnd();

            //using(var stream = new FileStream(files))
            return Ok();
        }


    }
}
