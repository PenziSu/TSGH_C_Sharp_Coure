using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mod04_07.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="subject不可為空白")]
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        public string HtmlComment { get; set; }

        public int Price { get; set; }

        public bool IsApprove { get; set; }
    }
}