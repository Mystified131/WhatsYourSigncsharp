using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{

    public class ResultViewModel
    {
        public int Bday { get; set; }
        public int Bmonth { get; set; }
        public string Sign { get; set; }
        public string Englishtrans { get; set; }
        public string Imageplace { get; set; }
        public String Error { get; set; }
    }
}


