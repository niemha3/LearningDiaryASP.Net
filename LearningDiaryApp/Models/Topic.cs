using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiaryApp.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double? TimeToMaster { get; set; }
        public double? TimeSpent { get; set; }
        public string Source { get; set; }
        public DateTime? StartLearningDate { get; set; }
        public DateTime? CompletitionDate { get; set; }
        public bool? InProgress { get; set; }
        public bool? StudiesOnTime { get; set; }
        public bool? DateInFuture { get; set; }
    }
}
