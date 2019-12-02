using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieCollection
{
    public partial class AddMoviesToCollection : Form
    {
        public AddMoviesToCollection()
        {
            InitializeComponent();
        }

        //Exit – Closes the modal form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear – resets form to startup state
        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Object myObject in this.Controls)
            {
                //clear all textbox 
                if (myObject is TextBox)
                {
                    (myObject as TextBox).Text = String.Empty;
                }
                //clear all checkBox 
                else if (myObject is CheckBox) {
                    if ((myObject as CheckBox).Checked)
                    {
                        (myObject as CheckBox).Checked = false;
                    }
                }
                //clear all RadioButton 
                else if (myObject is RadioButton) {
                    if ((myObject as RadioButton).Checked)
                    {
                        (myObject as RadioButton).Checked = false;
                    }
                }
                //clear all ComboBox 
                else if (myObject is ComboBox)
                {
                    (myObject as ComboBox).SelectedIndex = -1;
                }

            }
        }

        //saving
        private void saveButton_Click(object sender, EventArgs e)
        {
            //get fileName path from movie collection form
            string fileName = ((MovieCollection)this.Owner).getFileNamePath();
            //get separator from movie Collection form
            char separator = ((MovieCollection)this.Owner).getSeparator();

            string stars = null;                                         //rating
            List<string> genre = new List<string>();                     //genre
            string title = movieTitleTextBox.Text;                       // get title 
            string year = this.yearTextBox.Text;                         // get year
            string runtime = this.runtimeTextBox.Text;                   //get runtime

            //get format
            string format = "";
            if (this.formatComboBox.SelectedItem !=null)
            {
                format = this.formatComboBox.SelectedItem.ToString(); 
            }  

            //checked radio button : select the text  of the checked radio button
            var checkedRadioButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedRadioButton != null)
            {
                stars = checkedRadioButton.Text;
            }
            
            //checked ckeckBox : add in genre the text of all checked checkBox 
            foreach (Object checkBox in this.Controls.OfType<CheckBox>())
            {
                if ((checkBox as CheckBox).Checked) {
                    genre.Add((checkBox as CheckBox).Text);
                }
            }
            //concat 
            string genres = String.Join(separator.ToString(), genre.ToArray()).ToString();

            //write in movieCollection.txt file line in format: title; year; runtime; stars; separator; format; genre
            // if ";" is the separator 
            string newMovieToSave = title+ separator + year+ separator + runtime+ separator + stars+ separator + format+ separator + genres;
            using (StreamWriter writetext = new StreamWriter(fileName, true))
            {
                writetext.WriteLine(newMovieToSave);
            }
            //clear form
            this.clearButton_Click(sender, e);
            //set Focus to movie title textbox
            this.movieTitleTextBox.Focus();
            //display message box
            MessageBox.Show(title+" was successfully added to collection");

        }

    }
}
