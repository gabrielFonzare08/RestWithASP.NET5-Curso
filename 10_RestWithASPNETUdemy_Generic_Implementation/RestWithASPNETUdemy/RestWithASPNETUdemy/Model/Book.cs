using RestWithASPNETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [Table("book")]
    public class Book : BaseEntity
    {
        [Column("title")]
        public string Title { get; set;}
        [Column("author")]
        public string Author { get; set;}
        [Column("gender")]
        public string Gender { get; set;}
        [Column("assessment")]
        public Decimal Assessment { get; set; }
        [Column("Year")]
        public int Year { get; set; }
        [Column("Edition")]
        public int Edition { get; set; }



    }
}
