﻿namespace sportsdatabase
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F);
            this.button1.Location = new System.Drawing.Point(99, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Sport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F);
            this.button2.Location = new System.Drawing.Point(1084, 115);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Player";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F);
            this.button3.Location = new System.Drawing.Point(99, 393);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 112);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Players \r\n\r\n   Nation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F);
            this.button4.Location = new System.Drawing.Point(1084, 384);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Stadium";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F);
            this.button5.Location = new System.Drawing.Point(580, 608);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add Tournment";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}