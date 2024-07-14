using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class RecordedTraining
    {
        //Kullanıcının yaptığı ve kaydettiği antrenman
        public int RecordedTrainingId { get; set; }

        public DateTime DateOfTraining { get; set; }

        public string ExerciseTime { get; set; }

        public ICollection<Exercise>? RecordedExercise { get; set; }
    }
}
