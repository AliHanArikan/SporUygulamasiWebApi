using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ReadyTrainingInform
    {
        public int ReadyTrainingInformId { get; set; }
        public int ReadyTrainingId { get; set; }  // ilişkiyi doğru tanımlamak için bu propery yeterli

        public string ReadyTrainingInformName { get; set; }
        public int TotalTime { get; set; }
        public string BodyPart { get; set; }
    }
}
