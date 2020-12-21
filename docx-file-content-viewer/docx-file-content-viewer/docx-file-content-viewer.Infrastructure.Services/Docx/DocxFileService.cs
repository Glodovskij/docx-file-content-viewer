using docx_file_content_viewer.Domain.DTOs;
using docx_file_content_viewer.Domain.Repositories;
using docx_file_content_viewer.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace docx_file_content_viewer.Infrastructure.Services.Docx
{
    public class DocxFileService : IDocxFileService
    {
        private readonly IDocxFileRepository _fileRepository;
        public DocxFileService(IDocxFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }
        public void Add(DocxFileDTO docxFile)
        {
            throw new NotImplementedException();
        }

        public List<DocxFileDTO> Get()
        {
            return _fileRepository.Get().Select(obj => new DocxFileDTO
            {
                Author = obj.Author
            }).ToList();
        }

        public DocxFileDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(DocxFileDTO docxFile)
        {
            throw new NotImplementedException();
        }
    }
}
