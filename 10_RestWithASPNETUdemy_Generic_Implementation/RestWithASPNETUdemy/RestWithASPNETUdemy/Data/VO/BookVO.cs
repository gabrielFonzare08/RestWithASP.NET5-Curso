using RestWithASPNETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    public class BookVO 
    {
        public long Id { get; set; }
        public string Title { get; set;}
        public string Author { get; set;}
        public string Gender { get; set;}
        public Decimal Assessment { get; set; }
        public int Year { get; set; }
        public int Edition { get; set; }



    }
}
