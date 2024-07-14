using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Exercise
    {
        public int ExerciseId { get; set; }

        public string ExerciseName { get; set;}
        public string ExerciseDescription { get; set;}

        public string? ExerciseImage { get; set;}

        public string? ExerciseVideoUrl { get; set;}

        public string? ExcerciseLevel { get; set;}


    }
}
