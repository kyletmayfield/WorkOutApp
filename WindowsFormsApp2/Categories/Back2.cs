using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2;
using kmParctice2.Exercises;
using WindowsFormsApp2.Categories;

namespace WindowsFormsApp2.Categories
{
    public class Back2 : ExerciseCategory
    {
        public Back2() 
        {
            PullUps pullUps = new PullUps();
            SeatedRow seatedRow = new SeatedRow();
            LowerBackRecline lowerBackRecline = new LowerBackRecline();
            DeadLifts deadLifts = new DeadLifts();
            LatPullDowns latPullDowns = new LatPullDowns();
            DumBellLowLats dumBellLowLats = new DumBellLowLats();
            YogaMatMobility yogaMatMobility = new YogaMatMobility();

            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] 
            {
                yogaMatMobility, dumBellLowLats, latPullDowns, deadLifts, lowerBackRecline, seatedRow, pullUps });




        }

        public override WorkoutBodyPartCategoryTypeEnum GetWorkoutBodyPartCategoryType()
        {
            return WorkoutBodyPartCategoryTypeEnum.Back;
        }

        public override WorkoutCategorySplitTypeEnum GetWorkoutCategorySplitType()
        {
            return WorkoutCategorySplitTypeEnum.Pull;
        }
    }
}
