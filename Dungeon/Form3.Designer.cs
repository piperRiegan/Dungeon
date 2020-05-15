namespace Dungeon
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.pic_main = new System.Windows.Forms.PictureBox();
            this.pic_dor1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic_dor2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dor2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_main
            // 
            this.pic_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_main.Location = new System.Drawing.Point(748, 341);
            this.pic_main.Name = "pic_main";
            this.pic_main.Size = new System.Drawing.Size(36, 36);
            this.pic_main.TabIndex = 0;
            this.pic_main.TabStop = false;
            // 
            // pic_dor1
            // 
            this.pic_dor1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_dor1.Location = new System.Drawing.Point(790, 298);
            this.pic_dor1.Name = "pic_dor1";
            this.pic_dor1.Size = new System.Drawing.Size(14, 110);
            this.pic_dor1.TabIndex = 1;
            this.pic_dor1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pic_dor2
            // 
            this.pic_dor2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_dor2.Location = new System.Drawing.Point(52, 437);
            this.pic_dor2.Name = "pic_dor2";
            this.pic_dor2.Size = new System.Drawing.Size(110, 14);
            this.pic_dor2.TabIndex = 2;
            this.pic_dor2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_dor2);
            this.Controls.Add(this.pic_dor1);
            this.Controls.Add(this.pic_main);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dor2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_main;
        private System.Windows.Forms.PictureBox pic_dor1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic_dor2;
    }
}