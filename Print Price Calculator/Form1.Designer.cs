
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
            this.lbl_mb = new System.Windows.Forms.Label();
            this.lbl_pb = new System.Windows.Forms.Label();
            this.lbl_gray = new System.Windows.Forms.Label();
            this.lbl_pg = new System.Windows.Forms.Label();
            this.lbl_cyan = new System.Windows.Forms.Label();
            this.lbl_magenta = new System.Windows.Forms.Label();
            this.lbl_co = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_pm = new System.Windows.Forms.Label();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.lbl_yellow = new System.Windows.Forms.Label();
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
            // lbl_mb
            // 
            this.lbl_mb.AutoSize = true;
            this.lbl_mb.Location = new System.Drawing.Point(10, 94);
            this.lbl_mb.Name = "lbl_mb";
            this.lbl_mb.Size = new System.Drawing.Size(72, 15);
            this.lbl_mb.TabIndex = 3;
            this.lbl_mb.Text = "Matte Black:";
            // 
            // lbl_pb
            // 
            this.lbl_pb.AutoSize = true;
            this.lbl_pb.Location = new System.Drawing.Point(10, 124);
            this.lbl_pb.Name = "lbl_pb";
            this.lbl_pb.Size = new System.Drawing.Size(73, 15);
            this.lbl_pb.TabIndex = 3;
            this.lbl_pb.Text = "Photo Black:";
            // 
            // lbl_gray
            // 
            this.lbl_gray.AutoSize = true;
            this.lbl_gray.Location = new System.Drawing.Point(10, 159);
            this.lbl_gray.Name = "lbl_gray";
            this.lbl_gray.Size = new System.Drawing.Size(34, 15);
            this.lbl_gray.TabIndex = 3;
            this.lbl_gray.Text = "Gray:";
            // 
            // lbl_pg
            // 
            this.lbl_pg.AutoSize = true;
            this.lbl_pg.Location = new System.Drawing.Point(10, 190);
            this.lbl_pg.Name = "lbl_pg";
            this.lbl_pg.Size = new System.Drawing.Size(69, 15);
            this.lbl_pg.TabIndex = 3;
            this.lbl_pg.Text = "Photo Gray:";
            // 
            // lbl_cyan
            // 
            this.lbl_cyan.AutoSize = true;
            this.lbl_cyan.Location = new System.Drawing.Point(10, 224);
            this.lbl_cyan.Name = "lbl_cyan";
            this.lbl_cyan.Size = new System.Drawing.Size(37, 15);
            this.lbl_cyan.TabIndex = 3;
            this.lbl_cyan.Text = "Cyan:";
            // 
            // lbl_magenta
            // 
            this.lbl_magenta.AutoSize = true;
            this.lbl_magenta.Location = new System.Drawing.Point(10, 260);
            this.lbl_magenta.Name = "lbl_magenta";
            this.lbl_magenta.Size = new System.Drawing.Size(57, 15);
            this.lbl_magenta.TabIndex = 3;
            this.lbl_magenta.Text = "Magenta:";
            // 
            // lbl_co
            // 
            this.lbl_co.AutoSize = true;
            this.lbl_co.Location = new System.Drawing.Point(373, 260);
            this.lbl_co.Name = "lbl_co";
            this.lbl_co.Size = new System.Drawing.Size(108, 15);
            this.lbl_co.TabIndex = 4;
            this.lbl_co.Text = "Chroma Optimizer:";
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Location = new System.Drawing.Point(373, 224);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(33, 15);
            this.lbl_blue.TabIndex = 5;
            this.lbl_blue.Text = "Blue:";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(373, 190);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(30, 15);
            this.lbl_red.TabIndex = 6;
            this.lbl_red.Text = "Red:";
            // 
            // lbl_pm
            // 
            this.lbl_pm.AutoSize = true;
            this.lbl_pm.Location = new System.Drawing.Point(373, 159);
            this.lbl_pm.Name = "lbl_pm";
            this.lbl_pm.Size = new System.Drawing.Size(92, 15);
            this.lbl_pm.TabIndex = 7;
            this.lbl_pm.Text = "Photo Magenta:";
            // 
            // lbl_pc
            // 
            this.lbl_pc.AutoSize = true;
            this.lbl_pc.Location = new System.Drawing.Point(373, 124);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(72, 15);
            this.lbl_pc.TabIndex = 8;
            this.lbl_pc.Text = "Photo Cyan:";
            // 
            // lbl_yellow
            // 
            this.lbl_yellow.AutoSize = true;
            this.lbl_yellow.Location = new System.Drawing.Point(373, 94);
            this.lbl_yellow.Name = "lbl_yellow";
            this.lbl_yellow.Size = new System.Drawing.Size(44, 15);
            this.lbl_yellow.TabIndex = 9;
            this.lbl_yellow.Text = "Yellow:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.lbl_co);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.lbl_pm);
            this.Controls.Add(this.lbl_pc);
            this.Controls.Add(this.lbl_yellow);
            this.Controls.Add(this.lbl_magenta);
            this.Controls.Add(this.lbl_cyan);
            this.Controls.Add(this.lbl_pg);
            this.Controls.Add(this.lbl_gray);
            this.Controls.Add(this.lbl_pb);
            this.Controls.Add(this.lbl_mb);
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
        private System.Windows.Forms.Label lbl_mb;
        private System.Windows.Forms.Label lbl_pb;
        private System.Windows.Forms.Label lbl_gray;
        private System.Windows.Forms.Label lbl_pg;
        private System.Windows.Forms.Label lbl_cyan;
        private System.Windows.Forms.Label lbl_magenta;
        private System.Windows.Forms.Label lbl_co;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label lbl_pm;
        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.Label lbl_yellow;
    }
}

