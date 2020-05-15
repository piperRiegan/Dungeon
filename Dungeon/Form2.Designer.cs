namespace Dungeon
{
    partial class Form2
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dor1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_main
            // 
            this.pic_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_main.Location = new System.Drawing.Point(19, 332);
            this.pic_main.Name = "pic_main";
            this.pic_main.Size = new System.Drawing.Size(36, 36);
            this.pic_main.TabIndex = 0;
            this.pic_main.TabStop = false;
            // 
            // pic_dor1
            // 
            this.pic_dor1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_dor1.Location = new System.Drawing.Point(-1, 298);
            this.pic_dor1.Name = "pic_dor1";
            this.pic_dor1.Size = new System.Drawing.Size(14, 110);
            this.pic_dor1.TabIndex = 1;
            this.pic_dor1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_dor1);
            this.Controls.Add(this.pic_main);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_main;
        private System.Windows.Forms.PictureBox pic_dor1;
        private System.Windows.Forms.Timer timer1;
    }
}