using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2.Exercises;
using WindowsFormsApp2;

namespace kmParctice2.Categories
{
    public class Shoulders : ExerciseCategory
    {
        public Shoulders()
        {
            ShoulderInclinePress shoulderInclinePress = new ShoulderInclinePress();
            BentRearDelts bentRearDelts = new BentRearDelts();
            SeatedRearDelts seatedRearDelts = new SeatedRearDelts();
            CableShoulders cableShoulders = new CableShoulders();
            FrontRaises frontRaises = new FrontRaises();
            SideRaises sideRaises = new SideRaises();
            LatteralRaises latteralRaises = new LatteralRaises();

            Exercises = new List<Exercise>();
            
            Exercises.AddRange(new Exercise[] {
                shoulderInclinePress, bentRearDelts, seatedRearDelts, cableShoulders, frontRaises, sideRaises, latteralRaises
            });
        }
    }
}