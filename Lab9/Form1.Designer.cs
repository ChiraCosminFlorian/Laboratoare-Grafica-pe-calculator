namespace WindowsFormsApp1
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
            this.txtAx = new System.Windows.Forms.TextBox();
            this.txtAz = new System.Windows.Forms.TextBox();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.txtCx = new System.Windows.Forms.TextBox();
            this.txtCy = new System.Windows.Forms.TextBox();
            this.txtCz = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.txtBz = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAx
            // 
            this.txtAx.Location = new System.Drawing.Point(23, 12);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(100, 22);
            this.txtAx.TabIndex = 0;
            // 
            // txtAz
            // 
            this.txtAz.Location = new System.Drawing.Point(263, 12);
            this.txtAz.Name = "txtAz";
            this.txtAz.Size = new System.Drawing.Size(100, 22);
            this.txtAz.TabIndex = 1;
            // 
            // txtBy
            // 
            this.txtBy.Location = new System.Drawing.Point(141, 50);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(100, 22);
            this.txtBy.TabIndex = 2;
            // 
            // txtCx
            // 
            this.txtCx.Location = new System.Drawing.Point(23, 92);
            this.txtCx.Name = "txtCx";
            this.txtCx.Size = new System.Drawing.Size(100, 22);
            this.txtCx.TabIndex = 3;
            // 
            // txtCy
            // 
            this.txtCy.Location = new System.Drawing.Point(141, 92);
            this.txtCy.Name = "txtCy";
            this.txtCy.Size = new System.Drawing.Size(100, 22);
            this.txtCy.TabIndex = 4;
            // 
            // txtCz
            // 
            this.txtCz.Location = new System.Drawing.Point(263, 92);
            this.txtCz.Name = "txtCz";
            this.txtCz.Size = new System.Drawing.Size(100, 22);
            this.txtCz.TabIndex = 5;
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(141, 12);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(100, 22);
            this.txtAy.TabIndex = 6;
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(23, 50);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(100, 22);
            this.txtBx.TabIndex = 7;
            this.txtBx.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtBz
            // 
            this.txtBz.Location = new System.Drawing.Point(263, 50);
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(100, 22);
            this.txtBz.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(149, 192);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(152, 151);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Aplica";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtBz);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.txtCz);
            this.Controls.Add(this.txtCy);
            this.Controls.Add(this.txtCx);
            this.Controls.Add(this.txtBy);
            this.Controls.Add(this.txtAz);
            this.Controls.Add(this.txtAx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnCalc_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAx;
        private System.Windows.Forms.TextBox txtAz;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.TextBox txtCx;
        private System.Windows.Forms.TextBox txtCy;
        private System.Windows.Forms.TextBox txtCz;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.TextBox txtBz;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
    }
}

