namespace cacpheptinh
{
    partial class Form1
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbkq = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.rckq = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(12, 43);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(66, 29);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "So a";
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(12, 98);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(67, 29);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "So b";
            this.lb2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkq.Location = new System.Drawing.Point(12, 154);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(98, 29);
            this.lbkq.TabIndex = 0;
            this.lbkq.Text = "ket qua";
            this.lbkq.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(121, 43);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(173, 30);
            this.tb1.TabIndex = 2;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(121, 105);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(173, 30);
            this.tb2.TabIndex = 2;
            // 
            // rckq
            // 
            this.rckq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rckq.Location = new System.Drawing.Point(121, 153);
            this.rckq.Name = "rckq";
            this.rckq.Size = new System.Drawing.Size(173, 30);
            this.rckq.TabIndex = 2;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(183, 206);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(76, 36);
            this.btCong.TabIndex = 3;
            this.btCong.Text = "Cong";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 287);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.rckq);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "cacpheptinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbkq;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox rckq;
        private System.Windows.Forms.Button btCong;
    }
}

