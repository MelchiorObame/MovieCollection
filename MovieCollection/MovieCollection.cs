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
    public partial class MovieCollection : Form
    {
        ViewMoviesInCollection viewMoviesInCollection;
        AddMoviesToCollection addMoviesToCollection;

        private string fileNamePath;
        private char separator;

        public MovieCollection()
        {
            InitializeComponent();
            fileNamePath = "";
            separator = ';';
        }

        //get the file Name Path
        public string getFileNamePath() {
            return this.fileNamePath;
        }

        //get separator used
        public char getSeparator()
        {
            return this.separator;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMoviesToCollectionBtn_Click(object sender, EventArgs e)
        {
            addMoviesToCollection = new AddMoviesToCollection();
            //create file if not exist 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.OverwritePrompt = false;
            sfd.DefaultExt = "txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileNamePath = sfd.FileName;
            }
            addMoviesToCollection.Owner = this;
            addMoviesToCollection.ShowDialog();
        }

        private void ViewMoviesInCollectionBtn_Click(object sender, EventArgs e)
        {
            viewMoviesInCollection = new ViewMoviesInCollection();
            //openFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strFileName = openFileDialog.FileName;
                fileNamePath = strFileName;
            }
            viewMoviesInCollection.Owner = this;
            viewMoviesInCollection.readMovieDataFile();
            if (viewMoviesInCollection.getNumberOfMovies() != 0) {
                MessageBox.Show(viewMoviesInCollection.getNumberOfMovies()+" movie(s) found !");
                viewMoviesInCollection.updateField();
                viewMoviesInCollection.ShowDialog();
            }
            else
            {
                MessageBox.Show("File not Exists ! 0 movie");
            }
        }

    }

}
