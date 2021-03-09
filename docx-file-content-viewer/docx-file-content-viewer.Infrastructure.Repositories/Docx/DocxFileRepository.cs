using docx_file_content_viewer.Domain.Entities;
using docx_file_content_viewer.Domain.Repositories;
using docx_file_content_viewer.Infrastructure.Repositories.EF;
using System;
using System.Collections.Generic;
using System.Linq;

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
            _docxDbContext = docxDbContext ?? throw new ArgumentNullException(nameof(docxDbContext));
        }

        public void Add(DocxFile docxFile)
        {
            _docxDbContext.DocxFiles.Add(docxFile);
            _docxDbContext.SaveChanges();
        }

        public List<DocxFile> Get()
        {
            return _docxDbContext.DocxFiles.ToList();
        }

        public DocxFile Get(int id)
        {
            return _docxDbContext.DocxFiles.Find(id);
        }

        public void Remove(DocxFile docxFile)
        {
            _docxDbContext.DocxFiles.Remove(docxFile);
            _docxDbContext.SaveChanges();
        }
    }
}
