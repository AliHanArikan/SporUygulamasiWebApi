using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class CreatedTraining
    {
        public int CreatedTrainingId { get; set; }

        public int TotalTime { get; set; }
        public int BodyPart { get; set; }

        //public int user ID 

        public ICollection<Exercise> CreatedExercises { get; set; }
    }
}
