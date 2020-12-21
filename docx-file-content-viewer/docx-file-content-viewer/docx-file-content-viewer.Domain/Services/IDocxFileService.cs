using docx_file_content_viewer.Domain.DTOs;
using System.Collections.Generic;

namespace docx_file_content_viewer.Domain.Services
{
    public interface IDocxFileService
    {
        void Add(DocxFileDTO docxFile);
        void Remove(DocxFileDTO docxFile);
        List<DocxFileDTO> Get();
        DocxFileDTO Get(int id);
    }
}
