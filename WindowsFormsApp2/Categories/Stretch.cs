using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kmParctice2;
using kmParctice2.Exercises;

namespace WindowsFormsApp2.Categories
{
    public class Stretch : ExerciseCategory
    {
        public Stretch() 
        {
            Hamstrings hamstrings = new Hamstrings();
            ShoulderFocus shoulderFocus = new ShoulderFocus();
            BackFocus backFocus = new BackFocus();
            ChestFocus chestFocus = new ChestFocus();
            HipFocus hipFocus = new HipFocus();
            BalanceFocus balanceFocus = new BalanceFocus();
            CoreFocus coreFocus = new CoreFocus();

            Exercises = new List<Exercise>();

            Exercises.AddRange(new Exercise[] 
            {
                hamstrings, shoulderFocus, backFocus, chestFocus, hipFocus, balanceFocus, coreFocus
            });
        }
    }
}
