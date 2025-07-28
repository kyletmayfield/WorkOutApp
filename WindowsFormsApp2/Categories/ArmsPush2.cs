using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2;
using kmParctice2.Exercises;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Categories
{
    public class ArmsPush2 : ExerciseCategory
    {
        public ArmsPush2() 
        {
            CableTricepts cableTricepts = new CableTricepts();
            IsolatedTricepts isolatedTricepts = new IsolatedTricepts();
            VerticleBarBellCurls verticleBarBellCurls = new VerticleBarBellCurls();
            DipsMachine dipsMachine = new DipsMachine();
            ForeArms foreArms = new ForeArms();

            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] 
            {
                 dipsMachine , foreArms, verticleBarBellCurls, isolatedTricepts, cableTricepts
            });

        }

        public override WorkoutBodyPartCategoryTypeEnum GetWorkoutBodyPartCategoryType()
        {
            return WorkoutBodyPartCategoryTypeEnum.Arms;
        }

        public override WorkoutCategorySplitTypeEnum GetWorkoutCategorySplitType()
        {
            return WorkoutCategorySplitTypeEnum.Push;
        }
    }
}
