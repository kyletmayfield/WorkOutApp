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

        //button for full body workout
        private void button1_Click(object sender, EventArgs e)
        {

            Chest chest = new Chest();
            ShouldersPull shouldersPull = new ShouldersPull();
            ShouldersPush shouldersPush = new ShouldersPush();
            Back back = new Back();
            ArmsPull armsPull = new ArmsPull();
            ArmsPush armsPush = new ArmsPush();
            Legs legs = new Legs();
            Stretch stretch = new Stretch();
            Cardio cardio = new Cardio();

            string chestWorkoutName = getRandomWorkoutFromCategory(chest);
            string shouldersPullWorkoutName = getRandomWorkoutFromCategory(shouldersPull);
            string shouldersPushWorkoutName = getRandomWorkoutFromCategory(shouldersPush);
            string backWorkoutName = getRandomWorkoutFromCategory(back);
            string armsPullWorkoutName = getRandomWorkoutFromCategory(armsPull);
            string armsPushWorkoutName = getRandomWorkoutFromCategory(armsPush);
            string legsWorkoutName = getRandomWorkoutFromCategory(legs);
            string stretchWorkoutName = getRandomWorkoutFromCategory(stretch);
            string cardioWorkoutName = getRandomWorkoutFromCategory(cardio);

            //assign your labels with the workout names 
            lblChest.Text = chestWorkoutName;
            lblBack.Text = backWorkoutName;
            lblArms.Text = armsPullWorkoutName;
            lblLegs.Text = legsWorkoutName;
            lblCardio.Text = cardioWorkoutName;
            lblStretch.Text = stretchWorkoutName;
            lblShoulders.Text = shouldersPullWorkoutName;
            
        }
        private string getRandomWorkoutFromCategory(ExerciseCategory category)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, category.Exercises.Count - 1);
            return category.Exercises[index].ExerciseName;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
