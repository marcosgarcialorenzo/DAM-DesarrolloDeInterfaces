namespace GestorDeTareas.Views;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlTop = new Panel();
        lblFilter = new Label();
        cmbFilter = new ComboBox();
        lblCount = new Label();
        dgvTasks = new DataGridView();
        colName = new DataGridViewTextBoxColumn();
        colDescription = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        grpEditor = new GroupBox();
        lblName = new Label();
        txtName = new TextBox();
        lblDescription = new Label();
        txtDescription = new TextBox();
        chkCompleted = new CheckBox();
        btnAdd = new Button();
        btnModify = new Button();
        btnDelete = new Button();
        btnToggle = new Button();
        btnClear = new Button();
        pnlTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
        grpEditor.SuspendLayout();
        SuspendLayout();

        // pnlTop
        pnlTop.Controls.Add(lblFilter);
        pnlTop.Controls.Add(cmbFilter);
        pnlTop.Controls.Add(lblCount);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(760, 48);

        // lblFilter
        lblFilter.AutoSize = true;
        lblFilter.Location = new Point(12, 16);
        lblFilter.Name = "lblFilter";
        lblFilter.Text = "Mostrar:";

        // cmbFilter
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFilter.Items.AddRange(new object[] { "Todas", "Pendientes", "Completadas" });
        cmbFilter.Location = new Point(75, 12);
        cmbFilter.Name = "cmbFilter";
        cmbFilter.Size = new Size(160, 23);
        cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;

        // lblCount
        lblCount.AutoSize = true;
        lblCount.Location = new Point(260, 16);
        lblCount.Name = "lblCount";
        lblCount.Text = "0 tarea(s)";

        // dgvTasks
        dgvTasks.AllowUserToAddRows = false;
        dgvTasks.AllowUserToDeleteRows = false;
        dgvTasks.AllowUserToResizeRows = false;
        dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTasks.BackgroundColor = SystemColors.Window;
        dgvTasks.Columns.AddRange(new DataGridViewColumn[] { colName, colDescription, colStatus });
        dgvTasks.Dock = DockStyle.Fill;
        dgvTasks.MultiSelect = false;
        dgvTasks.Name = "dgvTasks";
        dgvTasks.ReadOnly = true;
        dgvTasks.RowHeadersVisible = false;
        dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTasks.SelectionChanged += dgvTasks_SelectionChanged;

        // colName
        colName.FillWeight = 30F;
        colName.HeaderText = "Nombre";
        colName.Name = "colName";
        colName.ReadOnly = true;

        // colDescription
        colDescription.FillWeight = 50F;
        colDescription.HeaderText = "Descripción";
        colDescription.Name = "colDescription";
        colDescription.ReadOnly = true;

        // colStatus
        colStatus.FillWeight = 20F;
        colStatus.HeaderText = "Estado";
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;

        // grpEditor
        grpEditor.Controls.Add(lblName);
        grpEditor.Controls.Add(txtName);
        grpEditor.Controls.Add(lblDescription);
        grpEditor.Controls.Add(txtDescription);
        grpEditor.Controls.Add(chkCompleted);
        grpEditor.Controls.Add(btnAdd);
        grpEditor.Controls.Add(btnModify);
        grpEditor.Controls.Add(btnDelete);
        grpEditor.Controls.Add(btnToggle);
        grpEditor.Controls.Add(btnClear);
        grpEditor.Dock = DockStyle.Bottom;
        grpEditor.Name = "grpEditor";
        grpEditor.Size = new Size(760, 205);
        grpEditor.Text = "Detalle de la tarea";

        // lblName
        lblName.AutoSize = true;
        lblName.Location = new Point(15, 30);
        lblName.Name = "lblName";
        lblName.Text = "Nombre:";

        // txtName
        txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtName.Location = new Point(100, 27);
        txtName.MaxLength = 100;
        txtName.Name = "txtName";
        txtName.Size = new Size(640, 23);

        // lblDescription
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(15, 64);
        lblDescription.Name = "lblDescription";
        lblDescription.Text = "Descripción:";

        // txtDescription
        txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtDescription.Location = new Point(100, 61);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.ScrollBars = ScrollBars.Vertical;
        txtDescription.Size = new Size(640, 55);

        // chkCompleted
        chkCompleted.AutoSize = true;
        chkCompleted.Location = new Point(100, 125);
        chkCompleted.Name = "chkCompleted";
        chkCompleted.Text = "Completada";

        // btnAdd
        btnAdd.Location = new Point(100, 158);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(100, 32);
        btnAdd.Text = "Añadir";
        btnAdd.Click += btnAdd_Click;

        // btnModify
        btnModify.Enabled = false;
        btnModify.Location = new Point(210, 158);
        btnModify.Name = "btnModify";
        btnModify.Size = new Size(100, 32);
        btnModify.Text = "Modificar";
        btnModify.Click += btnModify_Click;

        // btnDelete
        btnDelete.Enabled = false;
        btnDelete.Location = new Point(320, 158);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(100, 32);
        btnDelete.Text = "Eliminar";
        btnDelete.Click += btnDelete_Click;

        // btnToggle
        btnToggle.Enabled = false;
        btnToggle.Location = new Point(430, 158);
        btnToggle.Name = "btnToggle";
        btnToggle.Size = new Size(190, 32);
        btnToggle.Text = "Marcar como completada";
        btnToggle.Click += btnToggle_Click;

        // btnClear
        btnClear.Location = new Point(630, 158);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(110, 32);
        btnClear.Text = "Nueva / Limpiar";
        btnClear.Click += btnClear_Click;

        // MainForm (el control Fill va primero; los Dock de borde después)
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(760, 560);
        Controls.Add(dgvTasks);
        Controls.Add(grpEditor);
        Controls.Add(pnlTop);
        MinimumSize = new Size(700, 520);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestor de tareas";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
        grpEditor.ResumeLayout(false);
        grpEditor.PerformLayout();
        ResumeLayout(false);
    }

    private Panel pnlTop;
    private Label lblFilter;
    private ComboBox cmbFilter;
    private Label lblCount;
    private DataGridView dgvTasks;
    private DataGridViewTextBoxColumn colName;
    private DataGridViewTextBoxColumn colDescription;
    private DataGridViewTextBoxColumn colStatus;
    private GroupBox grpEditor;
    private Label lblName;
    private TextBox txtName;
    private Label lblDescription;
    private TextBox txtDescription;
    private CheckBox chkCompleted;
    private Button btnAdd;
    private Button btnModify;
    private Button btnDelete;
    private Button btnToggle;
    private Button btnClear;
}
