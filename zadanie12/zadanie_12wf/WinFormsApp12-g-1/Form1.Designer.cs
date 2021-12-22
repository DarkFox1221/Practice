
namespace WinFormsApp12_g_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlPl = new System.Windows.Forms.Label();
            this.labelMnMn = new System.Windows.Forms.Label();
            this.labelTrFl = new System.Windows.Forms.Label();
            this.labelPointOut = new System.Windows.Forms.Label();
            this.labelPl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "enter point coords (x y)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "enter scalar +";
            // 
            // labelPlPl
            // 
            this.labelPlPl.AutoSize = true;
            this.labelPlPl.Location = new System.Drawing.Point(60, 218);
            this.labelPlPl.Name = "labelPlPl";
            this.labelPlPl.Size = new System.Drawing.Size(0, 15);
            this.labelPlPl.TabIndex = 3;
            // 
            // labelMnMn
            // 
            this.labelMnMn.AutoSize = true;
            this.labelMnMn.Location = new System.Drawing.Point(60, 265);
            this.labelMnMn.Name = "labelMnMn";
            this.labelMnMn.Size = new System.Drawing.Size(0, 15);
            this.labelMnMn.TabIndex = 4;
            // 
            // labelTrFl
            // 
            this.labelTrFl.AutoSize = true;
            this.labelTrFl.Location = new System.Drawing.Point(60, 308);
            this.labelTrFl.Name = "labelTrFl";
            this.labelTrFl.Size = new System.Drawing.Size(0, 15);
            this.labelTrFl.TabIndex = 5;
            // 
            // labelPointOut
            // 
            this.labelPointOut.AutoSize = true;
            this.labelPointOut.Location = new System.Drawing.Point(60, 352);
            this.labelPointOut.Name = "labelPointOut";
            this.labelPointOut.Size = new System.Drawing.Size(0, 15);
            this.labelPointOut.TabIndex = 6;
            // 
            // labelPl
            // 
            this.labelPl.AutoSize = true;
            this.labelPl.Location = new System.Drawing.Point(60, 175);
            this.labelPl.Name = "labelPl";
            this.labelPl.Size = new System.Drawing.Size(0, 15);
            this.labelPl.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelPl);
            this.Controls.Add(this.labelPointOut);
            this.Controls.Add(this.labelTrFl);
            this.Controls.Add(this.labelMnMn);
            this.Controls.Add(this.labelPlPl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPlPl;
        private System.Windows.Forms.Label labelMnMn;
        private System.Windows.Forms.Label labelTrFl;
        private System.Windows.Forms.Label labelPointOut;
        private System.Windows.Forms.Label labelPl;
        private System.Windows.Forms.TextBox textBox2;
    }
}

