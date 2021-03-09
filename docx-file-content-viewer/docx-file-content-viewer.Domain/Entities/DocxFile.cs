namespace docx_file_content_viewer.Domain.Entities
{
    public class DocxFile
    {
        public int ID { get; set; }
        public long Size { get; set; }
        public string FileContent { get; set; } 
        public string Filename { get; set; }
    }
}