using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModel
{
    public class ViewCutomer
    {

        public Movie Movie { get; set; }

        public List<Customer> customers {get;set;}
    }
}