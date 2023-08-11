namespace WinFormsApp1
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.myControl1 = new WinFormsControlLibrary1.MyControl();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
      this.dataGridView1.Location = new System.Drawing.Point(381, 115);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.Size = new System.Drawing.Size(259, 118);
      this.dataGridView1.TabIndex = 0;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Column1";
      this.Column1.Name = "Column1";
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Column2";
      this.Column2.Name = "Column2";
      // 
      // myControl1
      // 
      this.myControl1.Location = new System.Drawing.Point(34, 115);
      this.myControl1.Name = "myControl1";
      this.myControl1.Size = new System.Drawing.Size(223, 67);
      this.myControl1.TabIndex = 1;
      this.myControl1.Text = "myControl1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.myControl1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "Form1 .NET 6.0";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private WinFormsControlLibrary1.MyControl myControl1;
  }
}