using docx_file_content_viewer.Domain.DTOs;
using System.Collections.Generic;

using IFormFile = Microsoft.AspNetCore.Http.IFormFile;

namespace docx_file_content_viewer.Domain.Services
{
    public interface IDocxFileService
    {
        void Add(List<IFormFile> docxFiles);
        void Remove(int id);
        List<DocxFileDTO> Get();
        DocxFileDTO Get(int id);
    }
}
