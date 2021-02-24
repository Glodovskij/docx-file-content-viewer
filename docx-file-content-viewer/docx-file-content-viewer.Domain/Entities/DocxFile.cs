namespace docx_file_content_viewer.Domain.Entities
{
    public class DocxFile
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Size { get; set; }
        public string DiscPath { get; set; }
        public string FileContent { get; set; } 
        public string Filename { get; set; }
    }
}