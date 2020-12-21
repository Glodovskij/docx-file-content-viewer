using DocumentFormat.OpenXml.Packaging;
using docx_fileloader_in_db.DAL;
using Microsoft.EntityFrameworkCore;
using SautinSoft.Document;
using System;
using System.IO;
using System.Linq;

namespace docx_fileloader_in_db
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DBContext dBContext = new DBContext();

            FileInfo info = new FileInfo("vitya.docx");

            Console.WriteLine(info.Length);

            DocumentCore dc = DocumentCore.Load("vitya.docx");

            var kek = dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.Author].ToString();

            byte[] byteArray = System.IO.File.ReadAllBytes("vitya.docx");
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(byteArray, 0, (int)byteArray.Length);                       
            }

            //DAL.File filetosave = new DAL.File()
            //{
            //    ID = 1,
            //    Author = dc.Document.Properties.BuiltIn[BuiltInDocumentProperty.Author].ToString(),
            //    DiscPath = "SautinSoft.Document",
            //    DocxFile = byteArray,
            //    Size = info.Length + " bytes"
            //};

            //dBContext.Files.Add(filetosave);
            //dBContext.SaveChanges();

            DAL.File filefromdb = dBContext.Files.ToList().FirstOrDefault();

            System.IO.File.WriteAllBytes("vitya2.docx", filefromdb.DocxFile);

            Console.ReadLine();
        }
    }
}
