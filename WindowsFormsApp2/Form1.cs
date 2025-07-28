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
            int index = rnd.Next(0, category.Exercises.Count);
            return category.Exercises[index].ExerciseName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Chest chest = new Chest();
            Chest2 chest2 = new Chest2();
            ShouldersPush shouldersPush = new ShouldersPush();
            ShouldersPush2 shouldersPush2 = new ShouldersPush2();
            ArmsPush armsPush = new ArmsPush();
            ArmsPush2 armsPush2 = new ArmsPush2();
            Stretch stretch = new Stretch();
            Cardio cardio = new Cardio();

            string chestWorkoutName = getRandomWorkoutFromCategory(chest);
            string chestWorkoutNameTwo = getRandomWorkoutFromCategory(chest2);
            string shouldersPushWorkoutName = getRandomWorkoutFromCategory(shouldersPush);
            string shouldersPushWorkoutNameTwo = getRandomWorkoutFromCategory(shouldersPush2);
            string armsPushWorkoutName = getRandomWorkoutFromCategory(armsPush);
            string armsPushWorkoutNameTwo = getRandomWorkoutFromCategory(armsPush2);
            string stretchWorkoutName = getRandomWorkoutFromCategory(stretch);
            string cardioWorkoutName = getRandomWorkoutFromCategory(cardio);

            lbl1.Text = chestWorkoutName;
            lbl2.Text = shouldersPushWorkoutName;
            lbl3.Text = armsPushWorkoutName;
            lbl4.Text = chestWorkoutNameTwo;
            lbl5.Text = shouldersPushWorkoutNameTwo;
            lbl6.Text = armsPushWorkoutNameTwo;
            lbl7.Text = stretchWorkoutName;
            lbl8.Text = cardioWorkoutName;
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            ShouldersPull shouldersPull = new ShouldersPull();
            ShouldersPull2 shouldersPull2 = new ShouldersPull2();
            Back back = new Back();
            Back2 back2 = new Back2();
            ArmsPull armsPull = new ArmsPull();
            ArmsPull2 armsPull2 = new ArmsPull2();
            Stretch stretch = new Stretch();
            Cardio cardio = new Cardio();

            string shouldersPullWorkoutName = getRandomWorkoutFromCategory(shouldersPull);
            string shouldersPullWorkoutNameTwo = getRandomWorkoutFromCategory(shouldersPull2);
            string backWorkoutName = getRandomWorkoutFromCategory(back);
            string backWorkoutNameTwo = getRandomWorkoutFromCategory(back2);
            string armsPullWorkoutName = getRandomWorkoutFromCategory(armsPull);
            string armsPullWorkoutNameTwo = getRandomWorkoutFromCategory(armsPull2);
            string stretchWorkoutName = getRandomWorkoutFromCategory(stretch);
            string cardioWorkoutName = getRandomWorkoutFromCategory(cardio);

            lbl1.Text = shouldersPullWorkoutName;
            lbl2.Text = backWorkoutName;
            lbl3.Text = armsPullWorkoutName;
            lbl4.Text = shouldersPullWorkoutNameTwo;
            lbl5.Text = backWorkoutNameTwo;
            lbl6.Text = armsPullWorkoutNameTwo;
            lbl7.Text = stretchWorkoutName;
            lbl8.Text = cardioWorkoutName;

        }

        private void btnLegs_Click(object sender, EventArgs e)
        {
            Legs legs = new Legs();
            Legs2 legs2 = new Legs2();
            Legs3 legs3 = new Legs3();
            Legs4 legs4 = new Legs4();
            Legs5 legs5 = new Legs5();
            Stretch stretch = new Stretch();
            Cardio cardio = new Cardio();

            string legsWorkoutName = getRandomWorkoutFromCategory(legs);
            string legsWorkoutNameTwo = getRandomWorkoutFromCategory(legs2);
            string legsWorkoutNameThree = getRandomWorkoutFromCategory(legs3);
            string legsWorkoutNameFour = getRandomWorkoutFromCategory(legs4);
            string legsWorkoutNameFive = getRandomWorkoutFromCategory(legs5);
            string stretchWorkoutName = getRandomWorkoutFromCategory(stretch);
            string cardioWorkoutName = getRandomWorkoutFromCategory(cardio);

            lbl1.Text = legsWorkoutName;
            lbl2.Text = legsWorkoutNameTwo;
            lbl3.Text = legsWorkoutNameThree;
            lbl4.Text = legsWorkoutNameFour;
            lbl5.Text = legsWorkoutNameFive;
            lbl6.Text = stretchWorkoutName;
            lbl7.Text = cardioWorkoutName;

        }
    }
}
