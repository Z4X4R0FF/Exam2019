using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.Models
{
    public class NonDbFile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public bool hasPass { get; set; }
        public string password { get; set; }
        public IFormFile UploadedFile { get; set; }
    }
}
