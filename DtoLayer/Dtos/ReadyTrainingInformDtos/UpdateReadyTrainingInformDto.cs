using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ReadyTrainingInformDtos
{
    public record UpdateReadyTrainingInformDto
    {
        public int ReadyTrainingInformId { get; set; }

        public string ReadyTrainingInformName { get; set; }
        public int TotalTime { get; set; }
        public string BodyPart { get; set; }
    }
}
