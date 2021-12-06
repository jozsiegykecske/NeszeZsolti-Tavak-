namespace Tavak
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtBoxTóNév = new System.Windows.Forms.TextBox();
      this.txtBoxTerületEgy = new System.Windows.Forms.TextBox();
      this.txtBoxTerület2 = new System.Windows.Forms.TextBox();
      this.txtBoxOrszágai = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.listBoxOsszes = new System.Windows.Forms.ListBox();
      this.lblSivatag = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 52);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tó neve:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 125);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(463, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Tó terölete (négyzetkilométerben, vagy egy minimum és egy maximum érték kötőjelle" +
    "l elválasztva)";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(17, 233);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Tó országa(i):";
      // 
      // txtBoxTóNév
      // 
      this.txtBoxTóNév.Location = new System.Drawing.Point(91, 52);
      this.txtBoxTóNév.Name = "txtBoxTóNév";
      this.txtBoxTóNév.Size = new System.Drawing.Size(100, 20);
      this.txtBoxTóNév.TabIndex = 1;
      // 
      // txtBoxTerületEgy
      // 
      this.txtBoxTerületEgy.Location = new System.Drawing.Point(91, 161);
      this.txtBoxTerületEgy.Name = "txtBoxTerületEgy";
      this.txtBoxTerületEgy.Size = new System.Drawing.Size(100, 20);
      this.txtBoxTerületEgy.TabIndex = 1;
      // 
      // txtBoxTerület2
      // 
      this.txtBoxTerület2.Location = new System.Drawing.Point(275, 161);
      this.txtBoxTerület2.Name = "txtBoxTerület2";
      this.txtBoxTerület2.Size = new System.Drawing.Size(100, 20);
      this.txtBoxTerület2.TabIndex = 1;
      // 
      // txtBoxOrszágai
      // 
      this.txtBoxOrszágai.Location = new System.Drawing.Point(91, 230);
      this.txtBoxOrszágai.Name = "txtBoxOrszágai";
      this.txtBoxOrszágai.Size = new System.Drawing.Size(100, 20);
      this.txtBoxOrszágai.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(91, 391);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(301, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "adatok kiírása tavak.csv-be";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // listBoxOsszes
      // 
      this.listBoxOsszes.FormattingEnabled = true;
      this.listBoxOsszes.Location = new System.Drawing.Point(481, 12);
      this.listBoxOsszes.Name = "listBoxOsszes";
      this.listBoxOsszes.Size = new System.Drawing.Size(614, 420);
      this.listBoxOsszes.TabIndex = 3;
      // 
      // lblSivatag
      // 
      this.lblSivatag.AutoSize = true;
      this.lblSivatag.Location = new System.Drawing.Point(91, 291);
      this.lblSivatag.Name = "lblSivatag";
      this.lblSivatag.Size = new System.Drawing.Size(35, 13);
      this.lblSivatag.TabIndex = 4;
      this.lblSivatag.Text = "label4";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1128, 450);
      this.Controls.Add(this.lblSivatag);
      this.Controls.Add(this.listBoxOsszes);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtBoxTerület2);
      this.Controls.Add(this.txtBoxTerületEgy);
      this.Controls.Add(this.txtBoxOrszágai);
      this.Controls.Add(this.txtBoxTóNév);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtBoxTóNév;
    private System.Windows.Forms.TextBox txtBoxTerületEgy;
    private System.Windows.Forms.TextBox txtBoxTerület2;
    private System.Windows.Forms.TextBox txtBoxOrszágai;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listBoxOsszes;
    private System.Windows.Forms.Label lblSivatag;
  }
}

