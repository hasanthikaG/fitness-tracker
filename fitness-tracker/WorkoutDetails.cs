using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace fitness_tracker
{
    public class WorkOutDetails
    {
        private int userId;
        private int workoutId;
        private string workoutName;
        private string workoutDescription;
        private string workoutType;
        private double bodyWeight;
        private DateTime date;
        private double durationInHours;
        private string status;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int WorkoutId
        {
            get { return workoutId; }
            set { workoutId = value; }
        }

        public string WorkoutName
        {
            get { return workoutName; }
            set { workoutName = value; }

        }
        public string WorkoutDescription
        {
            get { return workoutDescription; }
            set { workoutDescription = value; }
        }

        public string WorkoutType
        {
            get { return workoutType; }
            set { workoutType = value; }
        }
       
        public double BodyWeight
        {
            get { return bodyWeight; }
            set { bodyWeight = value; }
        }
        public Double DurationInHours
        {
            get { return durationInHours; }
            set { durationInHours = value; }
        }
  
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
