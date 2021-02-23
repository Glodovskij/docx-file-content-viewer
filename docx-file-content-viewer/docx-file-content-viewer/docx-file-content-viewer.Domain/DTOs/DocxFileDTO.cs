namespace docx_file_content_viewer.Domain.DTOs
{
    public class DocxFileDTO
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Size { get; set; }
        public string DiscPath { get; set; }
        public byte[] FileContent { get; set; }
        public string Filename { get; set; }

    }
}
