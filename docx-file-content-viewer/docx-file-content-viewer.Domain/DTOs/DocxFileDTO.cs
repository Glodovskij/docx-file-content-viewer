using docx_file_content_viewer.Domain.Entities;

namespace docx_file_content_viewer.Domain.DTOs
{
    public class DocxFileDTO
    {
        public int ID { get; set; }
        public long Size { get; set; }
        public string FileContent { get; set; }
        public string Filename { get; set; }

        public DocxFileDTO()
        {

        }

        public DocxFileDTO(DocxFile docxFile)
        {
            ID = docxFile.ID;
            Size = docxFile.Size;
            FileContent = docxFile.FileContent;
            Filename = docxFile.Filename;
        }
    }
}
