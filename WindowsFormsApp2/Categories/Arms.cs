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
    public class Arms : ExerciseCategory
    {
        public Arms() 
        {
            CableTricepts cableTricepts = new CableTricepts();
            IsolatedTricepts isolatedTricepts = new IsolatedTricepts();
            VerticleBarBellCurls verticleBarBellCurls = new VerticleBarBellCurls();
            PreacherCurls preacherCurls = new PreacherCurls();
            InclineDumBellCurls inclineDumBellCurls = new InclineDumBellCurls();
            DipsMachine dipsMachine = new DipsMachine();
            ForeArms foreArms = new ForeArms();

            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] 
            {
                cableTricepts, isolatedTricepts, verticleBarBellCurls, preacherCurls, foreArms, inclineDumBellCurls, dipsMachine
            });

        }
    }
}
