using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTMLPreviewWeb.Models
{
    public class HTMLContent
    {
        public int ID { get; set; }
        public string Description { get; set; }
        [Column("Content")]
        public string Content { get; set; }
    }
}
