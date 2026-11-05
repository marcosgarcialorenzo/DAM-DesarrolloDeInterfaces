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
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        btnDelete = new System.Windows.Forms.Button();
        btnModify = new System.Windows.Forms.Button();
        btnAdd = new System.Windows.Forms.Button();
        chkCompleted = new System.Windows.Forms.CheckBox();
        txtDescription = new System.Windows.Forms.TextBox();
        txtName = new System.Windows.Forms.TextBox();
        lvTasks = new System.Windows.Forms.ListView();
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        columnHeader2 = new System.Windows.Forms.ColumnHeader();
        columnHeader3 = new System.Windows.Forms.ColumnHeader();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        cmbFilter = new System.Windows.Forms.ComboBox();
        lblFilter = new System.Windows.Forms.Label();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
        tableLayoutPanel1.Controls.Add(chkCompleted, 1, 2);
        tableLayoutPanel1.Controls.Add(txtDescription, 1, 1);
        tableLayoutPanel1.Controls.Add(txtName, 1, 0);
        tableLayoutPanel1.Controls.Add(lvTasks, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanel1.Location = new System.Drawing.Point(29, 21);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.333336F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
        tableLayoutPanel1.Size = new System.Drawing.Size(744, 408);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.Controls.Add(btnDelete, 2, 0);
        tableLayoutPanel2.Controls.Add(btnModify, 1, 0);
        tableLayoutPanel2.Controls.Add(btnAdd, 0, 0);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(375, 323);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new System.Drawing.Size(366, 82);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // btnDelete
        // 
        btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
        btnDelete.Location = new System.Drawing.Point(247, 3);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(116, 76);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Eliminar";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnModify
        // 
        btnModify.Dock = System.Windows.Forms.DockStyle.Fill;
        btnModify.Location = new System.Drawing.Point(125, 3);
        btnModify.Name = "btnModify";
        btnModify.Size = new System.Drawing.Size(116, 76);
        btnModify.TabIndex = 1;
        btnModify.Text = "Modificar";
        btnModify.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
        btnAdd.Location = new System.Drawing.Point(3, 3);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(116, 76);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Añadir";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // chkCompleted
        // 
        chkCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
        chkCompleted.Location = new System.Drawing.Point(375, 276);
        chkCompleted.Name = "chkCompleted";
        chkCompleted.Size = new System.Drawing.Size(366, 41);
        chkCompleted.TabIndex = 1;
        chkCompleted.Text = "Completado";
        chkCompleted.UseVisualStyleBackColor = true;
        // 
        // txtDescription
        // 
        txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
        txtDescription.Location = new System.Drawing.Point(375, 48);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.PlaceholderText = "Descripcion";
        txtDescription.Size = new System.Drawing.Size(366, 222);
        txtDescription.TabIndex = 2;
        // 
        // txtName
        // 
        txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
        txtName.Location = new System.Drawing.Point(375, 11);
        txtName.Name = "txtName";
        txtName.PlaceholderText = "Nombre";
        txtName.Size = new System.Drawing.Size(366, 23);
        txtName.TabIndex = 3;
        // 
        // lvTasks
        // 
        lvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
        lvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
        lvTasks.FullRowSelect = true;
        lvTasks.GridLines = true;
        lvTasks.Location = new System.Drawing.Point(3, 48);
        lvTasks.MultiSelect = false;
        lvTasks.Name = "lvTasks";
        tableLayoutPanel1.SetRowSpan(lvTasks, 3);
        lvTasks.Size = new System.Drawing.Size(366, 357);
        lvTasks.TabIndex = 4;
        lvTasks.UseCompatibleStateImageBehavior = false;
        lvTasks.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Name = "columnHeader1";
        columnHeader1.Text = "Nombre";
        // 
        // columnHeader2
        // 
        columnHeader2.Name = "columnHeader2";
        columnHeader2.Text = "Descripcion";
        columnHeader2.Width = 223;
        // 
        // columnHeader3
        // 
        columnHeader3.Name = "columnHeader3";
        columnHeader3.Text = "Completada";
        columnHeader3.Width = 77;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tableLayoutPanel3.Controls.Add(cmbFilter, 1, 0);
        tableLayoutPanel3.Controls.Add(lblFilter, 0, 0);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel3.Size = new System.Drawing.Size(366, 39);
        tableLayoutPanel3.TabIndex = 5;
        // 
        // cmbFilter
        // 
        cmbFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
        cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbFilter.FormattingEnabled = true;
        cmbFilter.Items.AddRange(new object[] { "Todas", "Pendientes", "Completadas" });
        cmbFilter.Location = new System.Drawing.Point(167, 8);
        cmbFilter.Name = "cmbFilter";
        cmbFilter.Size = new System.Drawing.Size(177, 23);
        cmbFilter.TabIndex = 0;
        cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
        // 
        // lblFilter
        // 
        lblFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblFilter.Location = new System.Drawing.Point(3, 11);
        lblFilter.Name = "lblFilter";
        lblFilter.Size = new System.Drawing.Size(140, 16);
        lblFilter.TabIndex = 0;
        lblFilter.Text = "Filtrar por estado:";
        lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tableLayoutPanel1);
        Text = "Gestor de Tareas Grafico";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblFilter;
    private System.Windows.Forms.ComboBox cmbFilter;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;

    private System.Windows.Forms.ListView lvTasks;

    private System.Windows.Forms.TextBox txtDescription;

    private System.Windows.Forms.TextBox txtName;

    private System.Windows.Forms.CheckBox chkCompleted;

    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Button btnDelete;

    private System.Windows.Forms.Button btnAdd;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}