using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string content { get; set; } = string.Empty;
        public DateTime createdOn { get; set; } = DateTime.Now;
        public int? stockId { get; set; } // ? indica que pode receber nulo
        public Stock? stock { get; set; }
    }
}