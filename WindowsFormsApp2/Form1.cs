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
            lbl1.Text = chestWorkoutName;
            lbl2.Text = shouldersPullWorkoutName;
            lbl3.Text = shouldersPushWorkoutName;
            lbl4.Text = backWorkoutName;
            lbl5.Text = armsPullWorkoutName;
            lbl6.Text = armsPushWorkoutName;
            lbl7.Text = legsWorkoutName;
            lbl8.Text = stretchWorkoutName;
            lbl9.Text = cardioWorkoutName;


            
        }
        private string getRandomWorkoutFromCategory(ExerciseCategory category)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, category.Exercises.Count - 1);
            return category.Exercises[index].ExerciseName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Chest chest = new Chest();
            ShouldersPush shouldersPush = new ShouldersPush();
            ArmsPush armsPush = new ArmsPush();
            Stretch stretch = new Stretch();
            Cardio cardio = new Cardio();

            string chestWorkoutName = getRandomWorkoutFromCategory(chest);
            string shouldersPushWorkoutName = getRandomWorkoutFromCategory(shouldersPush);
            string armsPushWorkoutName = getRandomWorkoutFromCategory(armsPush);
            string stretchWorkoutName = getRandomWorkoutFromCategory(stretch);
            string cardioWorkoutName = getRandomWorkoutFromCategory(cardio);

            lbl1.Text = chestWorkoutName;
            lbl2.Text = shouldersPushWorkoutName;
            lbl3.Text = armsPushWorkoutName;
            lbl4.Text = chestWorkoutName;
            lbl5.Text = shouldersPushWorkoutName;
            lbl6.Text = armsPushWorkoutName;
            lbl7.Text = stretchWorkoutName;
            lbl8.Text = cardioWorkoutName;
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            ShouldersPull shouldersPull = new ShouldersPull();
            Back back = new Back();
            ArmsPull armsPull = new ArmsPull();
            Stretch stretch = new Stretch();
            Cardio cardio = new Cardio();

            string shouldersPullWorkoutName = getRandomWorkoutFromCategory(shouldersPull);
            string backWorkoutName = getRandomWorkoutFromCategory(back);
            string armsPullWorkoutName = getRandomWorkoutFromCategory(armsPull);
            string stretchWorkoutName = getRandomWorkoutFromCategory(stretch);
            string cardioWorkoutName = getRandomWorkoutFromCategory(cardio);

            lbl1.Text = shouldersPullWorkoutName;
            lbl2.Text = backWorkoutName;
            lbl3.Text = armsPullWorkoutName;
            lbl4.Text = shouldersPullWorkoutName;
            lbl5.Text = backWorkoutName;
            lbl6.Text = armsPullWorkoutName;
            lbl7.Text = stretchWorkoutName;
            lbl8.Text = cardioWorkoutName;

        }

        private void btnLegs_Click(object sender, EventArgs e)
        {
            Legs legs = new Legs();
            Stretch stretch = new Stretch();
            Cardio cardio = new Cardio();

            string legsWorkoutName = getRandomWorkoutFromCategory(legs);
            string stretchWorkoutName = getRandomWorkoutFromCategory(stretch);
            string cardioWorkoutName = getRandomWorkoutFromCategory(cardio);

            lbl1.Text = legsWorkoutName;
            lbl2.Text = legsWorkoutName;
            lbl3.Text = legsWorkoutName;
            lbl4.Text = legsWorkoutName;
            lbl5.Text = legsWorkoutName;
            lbl6.Text = stretchWorkoutName;
            lbl7.Text = cardioWorkoutName;

        }
    }
}
