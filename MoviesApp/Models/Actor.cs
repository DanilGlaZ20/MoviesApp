using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public class Actor
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
        

        
    }

    
}