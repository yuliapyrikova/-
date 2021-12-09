using System;

namespace pyrikova.Domain
{

    public class WorkoutRecord
    {

        public int WorkoutRecordId { get; set; }

        public DateTime TimeAndDateOfRecording { get; set; }

        public string TrainerFullName { get; set; }
    }
}