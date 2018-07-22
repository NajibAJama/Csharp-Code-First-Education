using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code_First_Education
{
    //[Table("Resorts")]
    class Resort:Lodging
    {
        public string Entertainment { get; set; }
        public string Activities { get; set; }
    }
}
