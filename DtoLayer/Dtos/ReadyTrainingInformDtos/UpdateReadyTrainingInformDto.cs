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

        public int TotalTime { get; set; }
        public int BodyPart { get; set; }
    }
}
