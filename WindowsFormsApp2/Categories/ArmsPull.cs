using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using kmParctice2;
using kmParctice2.Exercises;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Categories
{
    public class ArmsPull : ExerciseCategory
    {
        public ArmsPull() 
        {
            PreacherCurls preacherCurls = new PreacherCurls();
            InclineDumBellCurls inclineDumBellCurls = new InclineDumBellCurls();
         
            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] 
            {
               preacherCurls, inclineDumBellCurls
            });

        }

        public override WorkoutBodyPartCategoryTypeEnum GetWorkoutBodyPartCategoryType()
        {
            return WorkoutBodyPartCategoryTypeEnum.Arms;
        }

        public override WorkoutCategorySplitTypeEnum GetWorkoutCategorySplitType()
        {
            return WorkoutCategorySplitTypeEnum.Pull;
        }
    }
}
