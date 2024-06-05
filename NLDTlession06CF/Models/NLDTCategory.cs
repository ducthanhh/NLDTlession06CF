using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLDTlession06CF.Models
{
    public class NLDTCategory
    {
        [Key]
        public int NLDTID { get; set; }
        public string NLDTCategoryName { get; set; }
        // thuoc tinh quan he
        public virtual ICollection<NLDTBook> NLDTBooks { get; set; }
    }
}