using System.Collections.Generic;

namespace EmployeeAppBack.Models
{
    public class Training
    {
        public int TrainingID { get; set; }
        public int AccountID { get; set; }
        public string TrainingName { get; set; }
        public string TrainingDescription { get; set; }
    }
}