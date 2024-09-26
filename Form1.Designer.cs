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
      txtName = new TextBox();
      label2 = new Label();
      txtPhoneNumber = new TextBox();
      label3 = new Label();
      btnCount = new Button();
      txtZipCode = new TextBox();
      label4 = new Label();
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
      // txtName
      // 
      txtName.Font = new Font("Segoe UI", 20F);
      txtName.Location = new Point(272, 103);
      txtName.Name = "txtName";
      txtName.Size = new Size(212, 43);
      txtName.TabIndex = 7;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 20F);
      label2.Location = new Point(161, 103);
      label2.Name = "label2";
      label2.Size = new Size(88, 37);
      label2.TabIndex = 6;
      label2.Text = "Name";
      // 
      // txtPhoneNumber
      // 
      txtPhoneNumber.Font = new Font("Segoe UI", 20F);
      txtPhoneNumber.Location = new Point(272, 152);
      txtPhoneNumber.Name = "txtPhoneNumber";
      txtPhoneNumber.Size = new Size(212, 43);
      txtPhoneNumber.TabIndex = 9;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 20F);
      label3.Location = new Point(161, 152);
      label3.Name = "label3";
      label3.Size = new Size(92, 37);
      label3.TabIndex = 8;
      label3.Text = "Phone";
      // 
      // btnCount
      // 
      btnCount.Font = new Font("Segoe UI", 20F);
      btnCount.Location = new Point(526, 201);
      btnCount.Name = "btnCount";
      btnCount.Size = new Size(159, 43);
      btnCount.TabIndex = 10;
      btnCount.Text = "Count";
      btnCount.UseVisualStyleBackColor = true;
      btnCount.Click += btnCount_Click;
      // 
      // txtZipCode
      // 
      txtZipCode.Font = new Font("Segoe UI", 20F);
      txtZipCode.Location = new Point(272, 201);
      txtZipCode.Name = "txtZipCode";
      txtZipCode.Size = new Size(212, 43);
      txtZipCode.TabIndex = 12;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI", 20F);
      label4.Location = new Point(128, 204);
      label4.Name = "label4";
      label4.Size = new Size(125, 37);
      label4.TabIndex = 11;
      label4.Text = "Zip Code";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(txtZipCode);
      Controls.Add(label4);
      Controls.Add(btnCount);
      Controls.Add(txtPhoneNumber);
      Controls.Add(label3);
      Controls.Add(txtName);
      Controls.Add(label2);
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
    private TextBox txtName;
    private Label label2;
    private TextBox txtPhoneNumber;
    private Label label3;
    private Button btnCount;
    private TextBox txtZipCode;
    private Label label4;
  }
}
