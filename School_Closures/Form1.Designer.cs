namespace School_Closures
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
      this.numTemp = new System.Windows.Forms.NumericUpDown();
      this.NumWind = new System.Windows.Forms.NumericUpDown();
      this.numSnow = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblResults = new System.Windows.Forms.Label();
      this.btnSubmit = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumWind)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSnow)).BeginInit();
      this.SuspendLayout();
      // 
      // numTemp
      // 
      this.numTemp.Location = new System.Drawing.Point(236, 43);
      this.numTemp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numTemp.Name = "numTemp";
      this.numTemp.Size = new System.Drawing.Size(120, 31);
      this.numTemp.TabIndex = 0;
      // 
      // NumWind
      // 
      this.NumWind.Location = new System.Drawing.Point(236, 116);
      this.NumWind.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.NumWind.Name = "NumWind";
      this.NumWind.Size = new System.Drawing.Size(120, 31);
      this.NumWind.TabIndex = 1;
      // 
      // numSnow
      // 
      this.numSnow.Location = new System.Drawing.Point(236, 193);
      this.numSnow.Name = "numSnow";
      this.numSnow.Size = new System.Drawing.Size(120, 31);
      this.numSnow.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(76, 43);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 25);
      this.label1.TabIndex = 3;
      this.label1.Text = "Temp:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(76, 116);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "Wind Chill:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(76, 193);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(99, 25);
      this.label3.TabIndex = 5;
      this.label3.Text = "Snowfall:";
      // 
      // lblResults
      // 
      this.lblResults.AutoSize = true;
      this.lblResults.Location = new System.Drawing.Point(50, 254);
      this.lblResults.Name = "lblResults";
      this.lblResults.Size = new System.Drawing.Size(168, 25);
      this.lblResults.TabIndex = 6;
      this.lblResults.Text = "School Is Likely:";
      this.lblResults.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // btnSubmit
      // 
      this.btnSubmit.Location = new System.Drawing.Point(236, 254);
      this.btnSubmit.Name = "btnSubmit";
      this.btnSubmit.Size = new System.Drawing.Size(120, 53);
      this.btnSubmit.TabIndex = 3;
      this.btnSubmit.Text = "Submit";
      this.btnSubmit.UseVisualStyleBackColor = true;
      this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.btnSubmit;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(424, 365);
      this.Controls.Add(this.btnSubmit);
      this.Controls.Add(this.lblResults);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numSnow);
      this.Controls.Add(this.NumWind);
      this.Controls.Add(this.numTemp);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumWind)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSnow)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numTemp;
    private System.Windows.Forms.NumericUpDown NumWind;
    private System.Windows.Forms.NumericUpDown numSnow;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblResults;
    private System.Windows.Forms.Button btnSubmit;
  }
}

