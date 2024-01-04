using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2;
using kmParctice2.Exercises;

namespace WindowsFormsApp2
{
    public class Chest : ExerciseCategory
    {
        public Chest()
        {
            BenchPress benchPress = new BenchPress();
            InclinePress inclinePress = new InclinePress();
            DeclinePress declinePress = new DeclinePress();
            Flys flys = new Flys();
            PushUps pushUps = new PushUps();
            Dips dips = new Dips();
            Diamonds diamonds = new Diamonds();


            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] 
            {
                benchPress, inclinePress, declinePress, flys, pushUps, dips, diamonds
            });
        }

        public override WorkoutBodyPartCategoryTypeEnum GetWorkoutBodyPartCategoryType()
        {
            return WorkoutBodyPartCategoryTypeEnum.Chest;
        }

        public override WorkoutCategorySplitTypeEnum GetWorkoutCategorySplitType()
        {
            return WorkoutCategorySplitTypeEnum.Push;
        }
    }
}
