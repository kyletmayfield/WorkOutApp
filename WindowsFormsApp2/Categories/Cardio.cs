using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2;
using kmParctice2.Exercises;

namespace WindowsFormsApp2.Categories
{
    public class Cardio : ExerciseCategory
    {
        public Cardio() 
        {
            Walk1 walk1 = new Walk1();
            Jog1 jog1 = new Jog1();
            Elipticle10 elipticle10 = new Elipticle10();
            BackwardsWalk backwardsWalk = new BackwardsWalk();
            InclineWalk inclineWalk = new InclineWalk();
            Bike10 bike10 = new Bike10();
            Steps10 steps10 = new Steps10();

            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] 
            { walk1, jog1, elipticle10, backwardsWalk, inclineWalk, bike10, steps10 });
        }

    }
}
