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

        public string question1Score { get; set; }
        public string question2Score { get; set; }
        public string question3Score { get; set; }
        public string question4Score { get; set; }
        public string question5Score { get; set; }
        public string question6Score { get; set; }
        public string question7Score { get; set; }
        public string question8Score { get; set; }
        public string question9Score { get; set; }
        public string question10Score { get; set; }
        public string questionAnswer { get; set; }
        public int questionScore { get; set; }
        public int totalScore { get; set; }
    }
}