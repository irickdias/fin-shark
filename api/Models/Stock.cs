using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int id { get; set; }
        public string symbol { get; set; } = string.Empty;
        public string companyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")] // informs the EF that the column 'lastDiv' must be a type of decimal(18,2)
        public decimal purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal lastDiv { get; set; }
        public string industry { get; set; } = string.Empty;
        public long marketCap { get; set; }
        public List<Comment> comments { get; set; } = new List<Comment>();
    }
}