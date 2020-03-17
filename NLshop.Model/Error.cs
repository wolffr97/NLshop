using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NLshop.Model
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        public int ID { set; get; }
        public string Massage { set; get; }
        public string StackTrace { set; get; }
        public string DateTime { set; get; }
        public DateTime CreatedDate { get; set; }

    }
}
