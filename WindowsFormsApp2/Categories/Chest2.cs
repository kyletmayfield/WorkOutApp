using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2;
using kmParctice2.Exercises;

namespace WindowsFormsApp2
{
    public class Chest2 : ExerciseCategory
    {
        public Chest2()
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
                diamonds, dips, pushUps, flys, declinePress, inclinePress, benchPress
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
