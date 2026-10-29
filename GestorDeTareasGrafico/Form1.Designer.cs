namespace GestorDeTareasGrafico;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(button1, 0, 1);
        tableLayoutPanel1.Controls.Add(button2, 1, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(918, 414);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        tableLayoutPanel1.SetColumnSpan(label1, 2);
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Location = new System.Drawing.Point(3, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(912, 207);
        label1.TabIndex = 0;
        label1.Text = "LABEL 1";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button1
        // 
        button1.Dock = System.Windows.Forms.DockStyle.Fill;
        button1.Location = new System.Drawing.Point(3, 210);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(453, 201);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        //
        // button2
        // 
        button2.Dock = System.Windows.Forms.DockStyle.Fill;
        button2.Location = new System.Drawing.Point(462, 210);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(453, 201);
        button2.TabIndex = 2;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(918, 414);
        Controls.Add(tableLayoutPanel1);
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}