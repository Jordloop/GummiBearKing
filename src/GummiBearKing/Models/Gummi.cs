using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GummiBearKing.Models
{
    public class Gummi
    {
        [Key]
        public int GummiId { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }

    }
}
