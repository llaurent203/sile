﻿namespace WindowsFormsApplication1
{
    partial class lessonMenu
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.imagename6 = new WindowsFormsApplication1.imagename();
            this.imagename5 = new WindowsFormsApplication1.imagename();
            this.imagename4 = new WindowsFormsApplication1.imagename();
            this.imagename3 = new WindowsFormsApplication1.imagename();
            this.imagename2 = new WindowsFormsApplication1.imagename();
            this.imagename1 = new WindowsFormsApplication1.imagename();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(775, 605);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(206, 604);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(438, 604);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // imagename6
            // 
            this.imagename6.Location = new System.Drawing.Point(593, 291);
            this.imagename6.Name = "imagename6";
            this.imagename6.pic = null;
            this.imagename6.Size = new System.Drawing.Size(220, 231);
            this.imagename6.TabIndex = 6;
            this.imagename6.title = "";
            this.imagename6.clicked += new System.EventHandler(this.imagename_clicked);
            // 
            // imagename5
            // 
            this.imagename5.Location = new System.Drawing.Point(367, 291);
            this.imagename5.Name = "imagename5";
            this.imagename5.pic = null;
            this.imagename5.Size = new System.Drawing.Size(220, 231);
            this.imagename5.TabIndex = 5;
            this.imagename5.title = "";
            this.imagename5.clicked += new System.EventHandler(this.imagename_clicked);
            // 
            // imagename4
            // 
            this.imagename4.Location = new System.Drawing.Point(77, 291);
            this.imagename4.Name = "imagename4";
            this.imagename4.pic = null;
            this.imagename4.Size = new System.Drawing.Size(220, 231);
            this.imagename4.TabIndex = 4;
            this.imagename4.title = "";
            this.imagename4.clicked += new System.EventHandler(this.imagename_clicked);
            // 
            // imagename3
            // 
            this.imagename3.Location = new System.Drawing.Point(593, 54);
            this.imagename3.Name = "imagename3";
            this.imagename3.pic = null;
            this.imagename3.Size = new System.Drawing.Size(220, 231);
            this.imagename3.TabIndex = 2;
            this.imagename3.title = "";
            this.imagename3.clicked += new System.EventHandler(this.imagename_clicked);
            // 
            // imagename2
            // 
            this.imagename2.Location = new System.Drawing.Point(367, 54);
            this.imagename2.Name = "imagename2";
            this.imagename2.pic = null;
            this.imagename2.Size = new System.Drawing.Size(220, 231);
            this.imagename2.TabIndex = 1;
            this.imagename2.title = "";
            this.imagename2.clicked += new System.EventHandler(this.imagename_clicked);
            // 
            // imagename1
            // 
            this.imagename1.Location = new System.Drawing.Point(77, 54);
            this.imagename1.Name = "imagename1";
            this.imagename1.pic = null;
            this.imagename1.Size = new System.Drawing.Size(220, 231);
            this.imagename1.TabIndex = 0;
            this.imagename1.title = "";
            this.imagename1.clicked += new System.EventHandler(this.imagename_clicked);
            // 
            // lessonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 640);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.imagename6);
            this.Controls.Add(this.imagename5);
            this.Controls.Add(this.imagename4);
            this.Controls.Add(this.imagename3);
            this.Controls.Add(this.imagename2);
            this.Controls.Add(this.imagename1);
            this.Name = "lessonMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private imagename imagename1;
        private imagename imagename2;
        private imagename imagename3;
        private imagename imagename4;
        private imagename imagename5;
        private imagename imagename6;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
    }
}