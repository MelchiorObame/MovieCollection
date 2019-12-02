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
    public partial class ViewMoviesInCollection : Form
    {
        //contains all movie from movie data file
        private string[] movieData;

        //current movie index
        private int currentIndex;
        
        public ViewMoviesInCollection()
        {
            InitializeComponent();
            currentIndex = 0;
        }

        //loads data in movieData
        public void readMovieDataFile()
        {
            string fileName = ((MovieCollection)this.Owner).getFileNamePath();
            this.movieData = File.ReadAllLines(fileName);
        }

        //get movie data lenght
        public int getNumberOfMovies() {
            return movieData.Length;
        }

        //update all labels
        public void updateField()
        {
            string currentMovie = movieData[currentIndex];
            char separator = ((MovieCollection)this.Owner).getSeparator();
            string[] currentmovieFeatures = currentMovie.Split(separator);
            this.MovieTitleLabel.Text = currentmovieFeatures[0];
            //display picture
            string imagePath = "../../../pics/" + currentmovieFeatures[0]+".jpg";
            if (File.Exists(imagePath)) {
                this.moviePictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                this.moviePictureBox.Image = null;
            }
            this.yearLabel.Text = currentmovieFeatures[1];
            this.runtimeLabel.Text = currentmovieFeatures[2];
            this.ratingLabel.Text = currentmovieFeatures[3];
            this.formatLabel.Text = currentmovieFeatures[4];
            string genre= currentmovieFeatures[5];
            //add ", " separator between genres
            var newArray = currentmovieFeatures.Skip(5).Take(movieData.Length+1).ToArray();
            genre = String.Join(" ,", newArray).ToString();
            this.genreLabel.Text = genre;

            this.moviePositionlabel.Text = ((currentIndex+1)+" of "+ movieData.Length);
            if (currentIndex == movieData.Length - 1)
            {
                nextButton.Enabled = false;
            }
            
        }

        //Closes the modal form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Next – Displays the next movie and all relevant data in the collection
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIndex  >= movieData.Length-2)
            {
                currentIndex++;
                //disable button
                nextButton.Enabled = false;
                this.updateField();
                //print messageBox
                MessageBox.Show("Sorry ! You have reached the end of the movie collection");
            }
            else
            {
                currentIndex++;
                this.updateField();

            }
            if (previousButton.Enabled == false)
            {
                previousButton.Enabled = true;
            }

        }

        //Previous – Displays the previous movie and all relevant data in the collection
        private void previousButton_Click(object sender, EventArgs e)
        {
            
            if (currentIndex == 1) {
                currentIndex--;
                //disable button
                previousButton.Enabled = false;
                this.updateField();
                //print messageBox
                MessageBox.Show("Sorry ! You have reached the end of the movie collection");

            }
            else
            {
                currentIndex--;
                this.updateField();
            }
            if (nextButton.Enabled == false)
            {
                nextButton.Enabled = true;
            }

        }

    }
}
