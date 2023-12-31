using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kmParctice2;
using kmParctice2.Categories;
using WindowsFormsApp2.Categories;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Chest chest = new Chest();
            Shoulders shoulders = new Shoulders();
            Back back = new Back();
            Arms arms = new Arms();
            Legs legs = new Legs();
            Stretch stretch = new Stretch();
            Cardio cardio = new Cardio();

            string chestWorkoutName = getRandomWorkoutFromCategory(chest);
            string shouldersWorkoutName = getRandomWorkoutFromCategory(shoulders);
            string backWorkoutName = getRandomWorkoutFromCategory(back);
            string armsWorkoutName = getRandomWorkoutFromCategory(arms);
            string legsWorkoutName = getRandomWorkoutFromCategory(legs);
            string stretchWorkoutName = getRandomWorkoutFromCategory(stretch);
            string cardioWorkoutName = getRandomWorkoutFromCategory(cardio);

            //assign your labels with the workout names 
            lblChest.Text = chestWorkoutName;
            lblBack.Text = backWorkoutName;
            lblArms.Text = armsWorkoutName;
            lblLegs.Text = legsWorkoutName;
            lblCardio.Text = cardioWorkoutName;
            lblStretch.Text = stretchWorkoutName;
            lblShoulders.Text = shouldersWorkoutName;

        }
        private string getRandomWorkoutFromCategory(ExerciseCategory category)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, category.Exercises.Count - 1);
            return category.Exercises[index].ExerciseName;
        }
    }
}
