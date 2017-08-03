//***********************************************************************
// Name: Olmer Chavarria
// Date: 12/08/2016
// Lab: 15
// Description: This program demonstrates the use of C# automatically generated code
/////////////// and solution structure. This program also takes input from the user
////////////// and write the data to a text file; It can also load the data and display it on 
////////////// its correspondent fields.
//***********************************************************************
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Chavarria_Lab_15
{
    public partial class Form1 : Form     //class form1 INHERITS FROM class form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//THIS FUNCTION IS TRIGGERED BY THE USER BY PRESSING THE Save BUTTON ON THE GUI.
        {
            if (nameTBox.Text.Length > 0 && addressTBox2.Text.Length > 0)
            {
                string data = nameTBox.Text + " : " + addressTBox2.Text;// " : " IS USED AS A DELIMITER FOR LATER USE
                saveFileDialog1.Filter = "Text File | *.txt";           //SETS THE FILE AS PLAIN TEXT BY DEFAULT
                saveFileDialog1.Title = "Save Name and address";        //SETS THE TITLE OF saveFileDialog1
                string filename = saveFileDialog1.FileName;             //GETS THE filename GIVEN BY THE USER FROM saveFileDialog1
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(data);//DISPLAYS A MESSAGE BOX THAT SHOWS data TO BE WRITTEN
                    StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());//AN StreamWriter OBJECT IS USED TO ACTUALY WRITE data TO THE FILE
                    writer.WriteLine(data);
                    writer.Dispose();
                    writer.Close();
                    
                }
                
            }
            else
            {
                MessageBox.Show("NO DATA TO WRITE"); //THIS IS TRIGERED IS IF THE FIEDLS ON THE GUI FORM ARE EMPTY
            }
        }

        private void loadButton_Click(object sender, EventArgs e)//THIS METHOD IS TRIGGERED WHEN THE Load BUTTON IS PRESSED
        {
            openFileDialog1.InitialDirectory = "c:\\";        //SETS THE FIRST DIRECTORY TO SEARCH FOR A FILE
            openFileDialog1.Filter = "Text File | *.txt";     //FILTERS THE ALL THE TEXT FILES
            openFileDialog1.RestoreDirectory = true;
            string content;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog1.OpenFile()) != null)
                    {
                        StreamReader strReader = new StreamReader(openFileDialog1.OpenFile());//AN StreamReader OBJECT IS USED TO RETRIEVED data FROM TEXT FILE
                        content = strReader.ReadToEnd();
                        MessageBox.Show(content); //DISPLAYS A MESSAGE BOX THAT SHOWS data TO BE LOADED
                        String[] elements = Regex.Split(content, ":"); //SPLIT THE data AT " : " DELIMITER AND PUT EACH TOKEN IN AN ARRAY
                        nameTBox.Text = elements[0];                   //ASSIGN A TOKEN TO THE Name FIELD ON THE GUI FORM
                        addressTBox2.Text = elements[1];               //ASSIGN A THE SECOND TOKEN TO THE Adress FIELD ON THE GUI FORM
                        strReader.Dispose();
                        strReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);//TRIGGERED IF THERE IS SOMETHING WRONG WITH THE FILE
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)// THIS METHOD CLEARS THE TEXT FIELDS ON THE GUI FORM BY PRESSING THE Clear BUTTON.
        {
            nameTBox.Text = "";
            addressTBox2.Text = "";
        }
    }
}
