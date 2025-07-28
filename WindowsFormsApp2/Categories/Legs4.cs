using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2;
using kmParctice2.Exercises;

namespace WindowsFormsApp2.Categories
{
    public class Legs4 : ExerciseCategory
    {
        public Legs4()
        {
            Squats squats = new Squats();
            LegLifts legLifts = new LegLifts();
            LegCurls legCurls = new LegCurls();
            HipInduction hipInduction = new HipInduction();
            HipAbduction hipAbduction = new HipAbduction();
            Glutes glutes = new Glutes();
            CalfRaises calfRaises = new CalfRaises();

            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] 
            {
                calfRaises, squats, legLifts, legCurls, glutes, hipInduction, hipAbduction 
            });
        }

        public override WorkoutBodyPartCategoryTypeEnum GetWorkoutBodyPartCategoryType()
        {
            throw new NotImplementedException();
        }

        public override WorkoutCategorySplitTypeEnum GetWorkoutCategorySplitType()
        {
            throw new NotImplementedException();
        }
    }
}
