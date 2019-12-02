namespace MovieCollection
{
    partial class ViewMoviesInCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yearLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.moviePositionlabel = new System.Windows.Forms.Label();
            this.moviePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.runtimeLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.Red;
            this.yearLabel.Location = new System.Drawing.Point(24, 71);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(70, 25);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "label1";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.ForeColor = System.Drawing.Color.Blue;
            this.MovieTitleLabel.Location = new System.Drawing.Point(24, 32);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(58, 29);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Text = "titre";
            // 
            // moviePositionlabel
            // 
            this.moviePositionlabel.AutoSize = true;
            this.moviePositionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviePositionlabel.ForeColor = System.Drawing.Color.Red;
            this.moviePositionlabel.Location = new System.Drawing.Point(422, 61);
            this.moviePositionlabel.Name = "moviePositionlabel";
            this.moviePositionlabel.Size = new System.Drawing.Size(49, 25);
            this.moviePositionlabel.TabIndex = 2;
            this.moviePositionlabel.Text = "Pos";
            // 
            // moviePictureBox
            // 
            this.moviePictureBox.Location = new System.Drawing.Point(115, 84);
            this.moviePictureBox.Name = "moviePictureBox";
            this.moviePictureBox.Size = new System.Drawing.Size(277, 331);
            this.moviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePictureBox.TabIndex = 3;
            this.moviePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Runtime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Format :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rating :";
            // 
            // runtimeLabel
            // 
            this.runtimeLabel.AutoSize = true;
            this.runtimeLabel.Location = new System.Drawing.Point(118, 437);
            this.runtimeLabel.Name = "runtimeLabel";
            this.runtimeLabel.Size = new System.Drawing.Size(20, 20);
            this.runtimeLabel.TabIndex = 8;
            this.runtimeLabel.Text = "X";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(118, 492);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(20, 20);
            this.genreLabel.TabIndex = 9;
            this.genreLabel.Text = "X";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(118, 543);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(20, 20);
            this.formatLabel.TabIndex = 10;
            this.formatLabel.Text = "X";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(398, 437);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(20, 20);
            this.ratingLabel.TabIndex = 11;
            this.ratingLabel.Text = "X";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(193, 597);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(118, 38);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next   >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(29, 597);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(118, 38);
            this.previousButton.TabIndex = 13;
            this.previousButton.Text = "<<   Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(382, 597);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 38);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ViewMoviesInCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 662);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.runtimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moviePictureBox);
            this.Controls.Add(this.moviePositionlabel);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.yearLabel);
            this.Name = "ViewMoviesInCollection";
            this.Text = "View Movies In Collection";
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label moviePositionlabel;
        private System.Windows.Forms.PictureBox moviePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label runtimeLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button exitButton;
    }
}