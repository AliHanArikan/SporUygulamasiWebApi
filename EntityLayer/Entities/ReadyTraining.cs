using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ReadyTraining
    {
        public int ReadyTrainingId { get; set; }

        public int ReadyTrainingInformId { get; set; }
        public ReadyTrainingInform ReadyTrainingInform { get; set; }

        public ICollection<Exercise> ReadyExercise { get; set; }



    }
}
