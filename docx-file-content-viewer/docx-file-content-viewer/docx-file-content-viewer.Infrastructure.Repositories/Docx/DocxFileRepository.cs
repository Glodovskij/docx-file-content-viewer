using docx_file_content_viewer.Domain.Entities;
using docx_file_content_viewer.Domain.Repositories;
using docx_file_content_viewer.Infrastructure.Repositories.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace docx_file_content_viewer.Infrastructure.Repositories.Repositories
{
    public class DocxFileRepository : IDocxFileRepository
    {
        private readonly DocxDbContext _docxDbContext;

        public DocxFileRepository()
        {

        }

        public DocxFileRepository(DocxDbContext docxDbContext)
        {
            _docxDbContext = docxDbContext;
        }

        public void Add(DocxFile docxFile)
        {
            throw new NotImplementedException();
        }

        public List<DocxFile> Get()
        {
            return _docxDbContext.DocxFiles.ToList();
        }

        public DocxFile Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(DocxFile docxFile)
        {
            throw new NotImplementedException();
        }
    }
}
