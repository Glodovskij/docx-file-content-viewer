using docx_file_content_viewer.Domain.DTOs;
using docx_file_content_viewer.Domain.Entities;
using docx_file_content_viewer.Domain.Repositories;
using docx_file_content_viewer.Domain.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace docx_file_content_viewer.Infrastructure.Services.Docx
{
    public class DocxFileService : IDocxFileService
    {
        private readonly IDocxFileRepository _fileRepository;
        public DocxFileService(IDocxFileRepository fileRepository)
        {
            _fileRepository = fileRepository ?? throw new ArgumentNullException(nameof(fileRepository));
        }

        public void Add(List<IFormFile> docxFiles)
        {
            foreach(var file in docxFiles)
            {
                using MemoryStream memoryStream = new();
                file.OpenReadStream().CopyTo(memoryStream);

                _fileRepository.Add(new DocxFile
                {
                    Filename = file.FileName,
                    FileContent = Convert.ToBase64String(memoryStream.ToArray()),
                    Size = file.Length
                });
            }
        }

        public List<DocxFileDTO> Get()
        {
            return _fileRepository.Get().Select(file => new DocxFileDTO
            {
                Size = file.Size,
                FileContent = file.FileContent,
                Filename = file.Filename,
                ID = file.ID

            }).ToList();
        }

        public DocxFileDTO Get(int id)
        {
            return new DocxFileDTO(_fileRepository.Get(id));
        }

        public void Remove(int id)
        {
            _fileRepository.Remove(_fileRepository.Get(id));  
        }
    }
}
