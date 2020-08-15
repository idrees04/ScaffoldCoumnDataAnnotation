using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScaffoldCoumnDataAnnotation.Models
{
    public class Person
    {
        //SCAFFOLD COLUMN DATA ANNOTATION
        //we  will use create templete view for all properties and we want to show just top three properties to user
        //contact and address property will not autogenrate view if we use annotation [ScaffoldColumn(false)]
        public string name { get; set; }
        public string gender { get; set; }

        public string age { get; set; }

        [ScaffoldColumn(false)]
        public string contact { get; set; }

        [ScaffoldColumn(false)]
        public string address { get; set; }

    }
}