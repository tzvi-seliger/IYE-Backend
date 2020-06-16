using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAppBack.Models
{
    public class TrainingWithFiles : Training
    {
        public List<TrainingFile> TrainingFiles { get; set; }
    }
}
