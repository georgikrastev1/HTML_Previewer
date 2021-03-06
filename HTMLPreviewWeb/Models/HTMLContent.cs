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

        [Display(Name = "Last Modified")]
        public System.DateTime LastModified { get; set; } = DateTime.Now;

        [Display(Name = "Create Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; }

    }
}
