using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2.Exercises;
using WindowsFormsApp2;
using WindowsFormsApp2.Exercises;

namespace kmParctice2.Categories
{
    public class ShouldersPush : ExerciseCategory
    {
        public ShouldersPush()
        {
            ShoulderInclinePress shoulderInclinePress = new ShoulderInclinePress();
            CableShoulders cableShoulders = new CableShoulders();
            ShoulderWide shoulderWide = new ShoulderWide();

            Exercises = new List<Exercise>();
            
            Exercises.AddRange(new Exercise[] {
                shoulderInclinePress, cableShoulders, shoulderWide
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