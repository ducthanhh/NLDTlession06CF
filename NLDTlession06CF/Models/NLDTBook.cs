using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLDTlession06CF.Models
{
    public class NLDTBook
    {
        [Key]
        public int ID { get; set; }
        public string NLDTBookID { get; set; }
        public string NLDTTitle { get; set; }
        public string NLDTAuthor { get; set;}
        public int NLDTYear { get; set;}
        public string NLDTPulisher {  get; set;}
        public string NLDTPicture { get; set;}
        public int NLDTCategoryID { get; set;}
        // thuoc tinh quan he
        public virtual NLDTCategory NLDTCategory { get; set;}

            
    }
}