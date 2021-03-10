using docx_file_content_viewer.Domain.Entities;

namespace docx_file_content_viewer.Domain.DTOs
{
    public class DocxFileDTO
    {
        public int ID { get; set; }
        public long Size { get; set; }
        public byte[] FileContent { get; set; }
        public string Filename { get; set; }

        public DocxFileDTO()
        {

        }
    }
}
