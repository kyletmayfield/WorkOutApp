using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2.Exercises;
using WindowsFormsApp2;

namespace kmParctice2.Categories
{
    public class ShouldersPull2 : ExerciseCategory
    {
        public ShouldersPull2()
        {
            
            BentRearDelts bentRearDelts = new BentRearDelts();
            SeatedRearDelts seatedRearDelts = new SeatedRearDelts();
            FrontRaises frontRaises = new FrontRaises();
            SideRaises sideRaises = new SideRaises();
            LatteralRaises latteralRaises = new LatteralRaises();

            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] {
                 latteralRaises, sideRaises, frontRaises, seatedRearDelts
            });
        }

        public override WorkoutBodyPartCategoryTypeEnum GetWorkoutBodyPartCategoryType()
        {
            return WorkoutBodyPartCategoryTypeEnum.Shoulders;
        }

        public override WorkoutCategorySplitTypeEnum GetWorkoutCategorySplitType()
        {
            return WorkoutCategorySplitTypeEnum.Pull;
        }
    }
}