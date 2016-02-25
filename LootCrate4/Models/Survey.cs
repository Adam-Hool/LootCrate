using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;

namespace LootCrate4.Models
{
    public class Survey
    {
        public int ID { get; set; }
        public string question { get; set; }
        public string questionAnswer { get; set; }
        public int questionScore { get; set; }
        public int totalScore { get; set; }
    }
}