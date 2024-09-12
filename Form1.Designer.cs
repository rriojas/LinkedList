namespace LinkedList
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
      label1 = new Label();
      txtValue = new TextBox();
      btnAdd = new Button();
      button2 = new Button();
      btnContains = new Button();
      btnRemove = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 20F);
      label1.Location = new Point(161, 54);
      label1.Name = "label1";
      label1.Size = new Size(82, 37);
      label1.TabIndex = 0;
      label1.Text = "Value";
      // 
      // txtValue
      // 
      txtValue.Font = new Font("Segoe UI", 20F);
      txtValue.Location = new Point(272, 54);
      txtValue.Name = "txtValue";
      txtValue.Size = new Size(212, 43);
      txtValue.TabIndex = 1;
      // 
      // btnAdd
      // 
      btnAdd.Font = new Font("Segoe UI", 20F);
      btnAdd.Location = new Point(526, 54);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(159, 43);
      btnAdd.TabIndex = 2;
      btnAdd.Text = "Add";
      btnAdd.UseVisualStyleBackColor = true;
      btnAdd.Click += btnAdd_Click;
      // 
      // button2
      // 
      button2.Location = new Point(563, 273);
      button2.Name = "button2";
      button2.Size = new Size(8, 8);
      button2.TabIndex = 3;
      button2.Text = "button2";
      button2.UseVisualStyleBackColor = true;
      // 
      // btnContains
      // 
      btnContains.Font = new Font("Segoe UI", 20F);
      btnContains.Location = new Point(526, 103);
      btnContains.Name = "btnContains";
      btnContains.Size = new Size(159, 43);
      btnContains.TabIndex = 4;
      btnContains.Text = "Contains";
      btnContains.UseVisualStyleBackColor = true;
      btnContains.Click += btnContains_Click;
      // 
      // btnRemove
      // 
      btnRemove.Font = new Font("Segoe UI", 20F);
      btnRemove.Location = new Point(526, 152);
      btnRemove.Name = "btnRemove";
      btnRemove.Size = new Size(159, 43);
      btnRemove.TabIndex = 5;
      btnRemove.Text = "Remove";
      btnRemove.UseVisualStyleBackColor = true;
      btnRemove.Click += btnRemove_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(btnRemove);
      Controls.Add(btnContains);
      Controls.Add(button2);
      Controls.Add(btnAdd);
      Controls.Add(txtValue);
      Controls.Add(label1);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtValue;
    private Button btnAdd;
    private Button button2;
    private Button btnContains;
    private Button btnRemove;
  }
}
