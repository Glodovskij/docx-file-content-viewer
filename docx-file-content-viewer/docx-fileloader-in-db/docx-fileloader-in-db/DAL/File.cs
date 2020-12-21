namespace docx_fileloader_in_db.DAL
{
    public class File
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Size { get; set; }
        public string DiscPath { get; set; }
        public byte[] DocxFile { get; set; }

    }
}