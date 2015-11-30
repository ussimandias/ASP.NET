using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OutOfTheBox.Models
{
    public class Book
    {
	    public int ID { get; set; }
        
	    public string Name { get; set; }

        [Display(Name = "Pub Date")]
        [DataType(DataType.Date)]
	    public DateTime PubDate { get; set; }

	    public decimal Price { get; set; }
    }
}