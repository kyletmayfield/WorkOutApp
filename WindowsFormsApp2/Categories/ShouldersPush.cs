using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2.Exercises;
using WindowsFormsApp2;

namespace kmParctice2.Categories
{
    public class ShouldersPush : ExerciseCategory
    {
        public ShouldersPush()
        {
            ShoulderInclinePress shoulderInclinePress = new ShoulderInclinePress();
            CableShoulders cableShoulders = new CableShoulders();

            Exercises = new List<Exercise>();
            
            Exercises.AddRange(new Exercise[] {
                shoulderInclinePress, cableShoulders
            });
        }

        public override WorkoutBodyPartCategoryTypeEnum GetWorkoutBodyPartCategoryType()
        {
            return WorkoutBodyPartCategoryTypeEnum.Shoulders;
        }

        public override WorkoutCategorySplitTypeEnum GetWorkoutCategorySplitType()
        {
            return WorkoutCategorySplitTypeEnum.Push;
        }
    }
}