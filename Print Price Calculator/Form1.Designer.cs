
namespace Print_Price_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtBox_printerfile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_outputfile = new System.Windows.Forms.TextBox();
            this.butt_outputfile = new System.Windows.Forms.Button();
            this.butt_generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // txtBox_printerfile
            // 
            this.txtBox_printerfile.Location = new System.Drawing.Point(169, 11);
            this.txtBox_printerfile.Name = "txtBox_printerfile";
            this.txtBox_printerfile.Size = new System.Drawing.Size(619, 23);
            this.txtBox_printerfile.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Printer File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_outputfile
            // 
            this.txtBox_outputfile.Location = new System.Drawing.Point(169, 40);
            this.txtBox_outputfile.Name = "txtBox_outputfile";
            this.txtBox_outputfile.Size = new System.Drawing.Size(619, 23);
            this.txtBox_outputfile.TabIndex = 0;
            // 
            // butt_outputfile
            // 
            this.butt_outputfile.Location = new System.Drawing.Point(10, 39);
            this.butt_outputfile.Name = "butt_outputfile";
            this.butt_outputfile.Size = new System.Drawing.Size(153, 23);
            this.butt_outputfile.TabIndex = 1;
            this.butt_outputfile.Text = "Select Output File";
            this.butt_outputfile.UseVisualStyleBackColor = true;
            this.butt_outputfile.Click += new System.EventHandler(this.butt_outputfile_Click);
            // 
            // butt_generate
            // 
            this.butt_generate.Location = new System.Drawing.Point(10, 68);
            this.butt_generate.Name = "butt_generate";
            this.butt_generate.Size = new System.Drawing.Size(778, 23);
            this.butt_generate.TabIndex = 2;
            this.butt_generate.Text = "Generate";
            this.butt_generate.UseVisualStyleBackColor = true;
            this.butt_generate.Click += new System.EventHandler(this.butt_generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 101);
            this.Controls.Add(this.butt_generate);
            this.Controls.Add(this.butt_outputfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_outputfile);
            this.Controls.Add(this.txtBox_printerfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtBox_printerfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_outputfile;
        private System.Windows.Forms.Button butt_outputfile;
        private System.Windows.Forms.Button butt_generate;
    }
}

