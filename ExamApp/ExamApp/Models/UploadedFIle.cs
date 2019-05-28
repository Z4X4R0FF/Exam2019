using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.Models
{
    public class UploadedFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string ContentType { get; set; }
        public bool hasPass { get; set; }
        public string password { get; set; }
        public int AmountOfDownloads { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }

    }
}
