using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using MoviesApp.Filtres;
using Newtonsoft.Json;

namespace MoviesApp.ViewModels.Actor
{
    public class InputActorViewModel
    { 
        public int ID { get; set; }
       // public static DateTime startdate = new DateTime(1922, 01, 01);
        //public static DateTime finishdate = new DateTime(2014, 01, 01);
        //[ Range(01/01/1922,01/01/2014 )]
        [Required]
        [NumberActor(4)]
        public string Name { get; set; }
        [Required]
        [LittleSurnameActor(4)]
        public string Surname { get; set; }


        
        [Required]
        [DataType(DataType.Date)]
        [OldActorAttribute(1922)]
        [YoungActor(2014)]
       
        public DateTime Birth { get; set; }
        
    }
}