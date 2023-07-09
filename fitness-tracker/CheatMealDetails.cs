using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_tracker
{
    public class CheatMealDetails
    {
        private int userId;
        private string cheatMealId;
        private string cheatMealName;
        private string note;
        private double bodyWeight;
        private DateTime date;
        private string status;
        private string mealCategory;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string CheatMealId
        {
            get { return cheatMealId; }
            set { cheatMealId = value; }
        }

        public string CheatMealName
        {
            get { return cheatMealName; }
            set { cheatMealName = value; }

        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public double BodyWeight
        {
            get { return bodyWeight; }
            set { bodyWeight = value; }
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

        public string MealCategory
        {
            get { return mealCategory; }
            set { mealCategory = value; }
        }
    }
}
