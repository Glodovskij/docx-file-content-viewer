using docx_file_content_viewer.Domain.Entities;
using System.Collections.Generic;

namespace docx_file_content_viewer.Domain.Repositories
{
    public interface IDocxFileRepository
    {
        void Add(DocxFile docxFile);
        void Remove(DocxFile docxFile);
        List<DocxFile> Get();
        DocxFile Get(int id);
    }
}
