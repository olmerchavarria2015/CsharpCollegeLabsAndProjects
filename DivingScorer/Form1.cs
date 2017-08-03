//Filename: Diving Score Board
//Written by: Olmer Chavarria
//10-18-2016
//This program combines previous activity and lab.
using System;
using System.Windows.Forms;

namespace DivingScorer
{
    public partial class Form1 : Form
    {
        const int ARRAY_SIZE = 20;
        Divescore[] divers = new Divescore [ARRAY_SIZE];
        int diversIndex = 0;
        const int NUMBER_OF_JUDGES = 7;
        public float dificulty = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        public float[] scores()//populates and returns a float array of scores
        {
            float[] empty = null;
            TextBox[] judges = { judge1Tbox, judge2Tbox, judge3Tbox,
                                judge4Tbox, judge5Tbox, judge6Tbox, judge7Tbox };
            float[] scores = new float[NUMBER_OF_JUDGES];

            try
            {
                
                for (int i = 0; i < NUMBER_OF_JUDGES; i++)
                {
                    scores[i] = float.Parse(judges[i].Text);
                }
                return scores;
            }
            catch
            {

                finalScoreLabel.Text = "Error on input, try again";
                return empty;//had to return this emty array instead of null because it crashes the program
                
            }
        }


        // This method populates the object array an set them to a default value
        public void populateObjetArray()
        {
            if ((divers[0]) == null)
            {
                Divescore tempObj = new Divescore();
                for (int i = 0; i < divers.Length; i++)
                {
                    divers[i] = tempObj;
                } 
            }
        }


        //This method calculates the score and sets the value of the first object array
        public void finalScore(float[] array,float dificulty)//requires a float array and a float
        {
            if (array != null && diversIndex <=19)
            {
                try
                {
                    dificulty = float.Parse(levelOfDificultyTbox.Text);
                    currentDiverNameLabel.Text = diverNameTBox.Text;
                    currentDiverDDLabel.Text = dificulty.ToString("0.00");
                }
                catch
                {
                    finalScoreLabel.Text = "Error";
                }
                
                Array.Sort(array);
                float finalScore = (array[2] + array[3] + array[4]) * dificulty;
                finalScoreLabel.Text = finalScore.ToString("0.00");
                divers[0] = new Divescore(finalScore, diverNameTBox.Text, dificulty);
                

           }
            else
            {
                finalScoreLabel.Text = "Error";
            }
            

        }
        //This method rearrange the bottom scoreboard by placing the divers ordered by higher score.
        public void refreshScoreboard()
        {
            
            Array.Sort(divers);
            

            try
            {
                firstPlaceNameLabel.Text = divers[19].DiverName;
                firstPlaceScoreLabel.Text = (divers[19].Score).ToString("0.00");
                firstPlaceDDLabel.Text = (divers[19].DegreeOfDificulty).ToString("0.00");
                secondPlaceNameLabel.Text = divers[18].DiverName;
                secondPlaceScoreLabel.Text = (divers[18].Score).ToString("0.00");
                secondPlaceDDLabel.Text = (divers[18].DegreeOfDificulty).ToString("0.00");
                thirdPlaceNameLabel.Text = divers[17].DiverName;
                thirdPlaceScoreLabel.Text = (divers[17].Score).ToString("0.00");
                thirdPlaceDDLabel.Text = (divers[17].DegreeOfDificulty).ToString("0.00");
            }
            catch 
            {
                firstPlaceNameLabel.Text="something wrong";
                ////throw;
            }
            
            diversIndex++;

        }        private void button1_Click(object sender, EventArgs e)
        {
            populateObjetArray();
            finalScore(scores(),dificulty);//passing an array of scores and a float as dificulty
            refreshScoreboard();
        }

        
    }
    class Divescore : IComparable   //IComparable allows objects to be compared.
    {
        private float diverScore;
        private string diverName;
        private float degreeOfDificulty;
        public float HIGHEST_DD = 4.0F;
        public float LOWEST_DD = 0.0F;
        public float Score
        {
            get
            {
                return diverScore;
            }
            set
            {
                diverScore = value;
            }
        }
        public string DiverName
        {
            get
            {
                return diverName;
            }
            set
            {
                diverName = value;
            }
        }
        public double DegreeOfDificulty
        {
            get
            {
                return degreeOfDificulty;
            }
            set
            {
                if (value >= LOWEST_DD && value <= HIGHEST_DD)
                {
                    degreeOfDificulty = (float)value;
                }
                else
                {
                    degreeOfDificulty = LOWEST_DD;
                }
            }
        }
        public Divescore(float score, string name, float dd)
        {
            Score = score;
            DiverName = name;
            DegreeOfDificulty = dd;
        }
        public Divescore() : this(0, "", 0)
        {
        }

        // This method compares diver objects by score.
        int IComparable.CompareTo(object o)  
        {
            int returnVal;
            Divescore temp = (Divescore)o;
            if (Math.Abs(this.Score) > Math.Abs(temp.Score))
            {
                returnVal = 1;
            }
            else
            {
                if (Math.Abs(this.Score) < Math.Abs(temp.Score))
                    returnVal = -1;
                else
                    returnVal = 0;
            }
            return returnVal;

        }
    }
}
