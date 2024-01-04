using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace kmParctice2
{
    public abstract class ExerciseCategory
    {
        public string CategoryName { get; set; }
        public List<Exercise> Exercises { get; set; }
        public abstract WorkoutCategorySplitTypeEnum GetWorkoutCategorySplitType();

        public abstract WorkoutBodyPartCategoryTypeEnum GetWorkoutBodyPartCategoryType();

    }
}
