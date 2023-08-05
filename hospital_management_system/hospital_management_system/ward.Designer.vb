<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ward
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim WARD_IDLabel As System.Windows.Forms.Label
        Dim WARD_NAMELabel As System.Windows.Forms.Label
        Dim CAPACITYLabel As System.Windows.Forms.Label
        Dim AILMENTLabel As System.Windows.Forms.Label
        Dim PATIENT_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ward))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WARD_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital_managementDataSet = New hospital_management_system.hospital_managementDataSet()
        Me.WARD_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.AILMENTTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WardsTableAdapter = New hospital_management_system.hospital_managementDataSetTableAdapters.wardsTableAdapter()
        Me.TableAdapterManager = New hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager()
        Me.WardsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.WardsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WardsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_ward = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        WARD_IDLabel = New System.Windows.Forms.Label()
        WARD_NAMELabel = New System.Windows.Forms.Label()
        CAPACITYLabel = New System.Windows.Forms.Label()
        AILMENTLabel = New System.Windows.Forms.Label()
        PATIENT_IDLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WardsBindingNavigator.SuspendLayout()
        CType(Me.WardsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WARD_IDLabel
        '
        WARD_IDLabel.AutoSize = True
        WARD_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WARD_IDLabel.Location = New System.Drawing.Point(85, 108)
        WARD_IDLabel.Name = "WARD_IDLabel"
        WARD_IDLabel.Size = New System.Drawing.Size(84, 18)
        WARD_IDLabel.TabIndex = 0
        WARD_IDLabel.Text = "WARD ID:"
        '
        'WARD_NAMELabel
        '
        WARD_NAMELabel.AutoSize = True
        WARD_NAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WARD_NAMELabel.Location = New System.Drawing.Point(85, 137)
        WARD_NAMELabel.Name = "WARD_NAMELabel"
        WARD_NAMELabel.Size = New System.Drawing.Size(115, 18)
        WARD_NAMELabel.TabIndex = 2
        WARD_NAMELabel.Text = "WARD NAME:"
        '
        'CAPACITYLabel
        '
        CAPACITYLabel.AutoSize = True
        CAPACITYLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CAPACITYLabel.Location = New System.Drawing.Point(85, 165)
        CAPACITYLabel.Name = "CAPACITYLabel"
        CAPACITYLabel.Size = New System.Drawing.Size(92, 18)
        CAPACITYLabel.TabIndex = 4
        CAPACITYLabel.Text = "CAPACITY:"
        '
        'AILMENTLabel
        '
        AILMENTLabel.AutoSize = True
        AILMENTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AILMENTLabel.Location = New System.Drawing.Point(85, 193)
        AILMENTLabel.Name = "AILMENTLabel"
        AILMENTLabel.Size = New System.Drawing.Size(83, 18)
        AILMENTLabel.TabIndex = 6
        AILMENTLabel.Text = "AILMENT:"
        '
        'PATIENT_IDLabel
        '
        PATIENT_IDLabel.AutoSize = True
        PATIENT_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_IDLabel.Location = New System.Drawing.Point(85, 224)
        PATIENT_IDLabel.Name = "PATIENT_IDLabel"
        PATIENT_IDLabel.Size = New System.Drawing.Size(102, 18)
        PATIENT_IDLabel.TabIndex = 8
        PATIENT_IDLabel.Text = "PATIENT ID:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.btn_close)
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_previous)
        Me.Panel2.Controls.Add(Me.btn_next)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Location = New System.Drawing.Point(931, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 367)
        Me.Panel2.TabIndex = 4
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(41, 295)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(150, 35)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "CLOSE"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(41, 233)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(150, 35)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_previous
        '
        Me.btn_previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_previous.Location = New System.Drawing.Point(41, 167)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(150, 35)
        Me.btn_previous.TabIndex = 2
        Me.btn_previous.Text = "PREVIOUS"
        Me.btn_previous.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_next.Location = New System.Drawing.Point(41, 97)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(150, 35)
        Me.btn_next.TabIndex = 1
        Me.btn_next.Text = "NEXT"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(41, 30)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(150, 35)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(WARD_IDLabel)
        Me.Panel1.Controls.Add(Me.WARD_IDTextBox)
        Me.Panel1.Controls.Add(WARD_NAMELabel)
        Me.Panel1.Controls.Add(Me.WARD_NAMETextBox)
        Me.Panel1.Controls.Add(CAPACITYLabel)
        Me.Panel1.Controls.Add(AILMENTLabel)
        Me.Panel1.Controls.Add(Me.AILMENTTextBox)
        Me.Panel1.Controls.Add(PATIENT_IDLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_IDTextBox)
        Me.Panel1.Location = New System.Drawing.Point(61, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 379)
        Me.Panel1.TabIndex = 5
        '
        'WARD_IDTextBox
        '
        Me.WARD_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "WARD_ID", True))
        Me.WARD_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WARD_IDTextBox.Location = New System.Drawing.Point(219, 102)
        Me.WARD_IDTextBox.Name = "WARD_IDTextBox"
        Me.WARD_IDTextBox.Size = New System.Drawing.Size(245, 24)
        Me.WARD_IDTextBox.TabIndex = 1
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "wards"
        Me.WardsBindingSource.DataSource = Me.Hospital_managementDataSet
        '
        'Hospital_managementDataSet
        '
        Me.Hospital_managementDataSet.DataSetName = "hospital_managementDataSet"
        Me.Hospital_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WARD_NAMETextBox
        '
        Me.WARD_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "WARD_NAME", True))
        Me.WARD_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WARD_NAMETextBox.Location = New System.Drawing.Point(219, 132)
        Me.WARD_NAMETextBox.Name = "WARD_NAMETextBox"
        Me.WARD_NAMETextBox.Size = New System.Drawing.Size(245, 24)
        Me.WARD_NAMETextBox.TabIndex = 3
        '
        'AILMENTTextBox
        '
        Me.AILMENTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "AILMENT", True))
        Me.AILMENTTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AILMENTTextBox.Location = New System.Drawing.Point(219, 193)
        Me.AILMENTTextBox.Name = "AILMENTTextBox"
        Me.AILMENTTextBox.Size = New System.Drawing.Size(245, 24)
        Me.AILMENTTextBox.TabIndex = 7
        '
        'PATIENT_IDTextBox
        '
        Me.PATIENT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "PATIENT_ID", True))
        Me.PATIENT_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_IDTextBox.Location = New System.Drawing.Point(219, 221)
        Me.PATIENT_IDTextBox.Name = "PATIENT_IDTextBox"
        Me.PATIENT_IDTextBox.Size = New System.Drawing.Size(245, 24)
        Me.PATIENT_IDTextBox.TabIndex = 9
        '
        'WardsTableAdapter
        '
        Me.WardsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.doctor_detailsTableAdapter = Nothing
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.patient_detailsTableAdapter = Nothing
        Me.TableAdapterManager.paymentsTableAdapter = Nothing
        Me.TableAdapterManager.pharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Me.WardsTableAdapter
        '
        'WardsBindingNavigator
        '
        Me.WardsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WardsBindingNavigator.BindingSource = Me.WardsBindingSource
        Me.WardsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WardsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WardsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WardsBindingNavigatorSaveItem})
        Me.WardsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WardsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WardsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WardsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WardsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WardsBindingNavigator.Name = "WardsBindingNavigator"
        Me.WardsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WardsBindingNavigator.Size = New System.Drawing.Size(1295, 27)
        Me.WardsBindingNavigator.TabIndex = 6
        Me.WardsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'WardsBindingNavigatorSaveItem
        '
        Me.WardsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WardsBindingNavigatorSaveItem.Image = CType(resources.GetObject("WardsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WardsBindingNavigatorSaveItem.Name = "WardsBindingNavigatorSaveItem"
        Me.WardsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.WardsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WardsDataGridView
        '
        Me.WardsDataGridView.AutoGenerateColumns = False
        Me.WardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WardsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.WardsDataGridView.DataSource = Me.WardsBindingSource
        Me.WardsDataGridView.Location = New System.Drawing.Point(433, 475)
        Me.WardsDataGridView.Name = "WardsDataGridView"
        Me.WardsDataGridView.RowTemplate.Height = 24
        Me.WardsDataGridView.Size = New System.Drawing.Size(549, 194)
        Me.WardsDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WARD_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WARD_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WARD_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "WARD_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CAPACITY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CAPACITY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AILMENT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AILMENT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PATIENT_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PATIENT_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'lbl_ward
        '
        Me.lbl_ward.AutoSize = True
        Me.lbl_ward.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ward.ForeColor = System.Drawing.Color.Purple
        Me.lbl_ward.Location = New System.Drawing.Point(607, 37)
        Me.lbl_ward.Name = "lbl_ward"
        Me.lbl_ward.Size = New System.Drawing.Size(258, 32)
        Me.lbl_ward.TabIndex = 7
        Me.lbl_ward.Text = "WARDS MODULE"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(219, 162)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(245, 22)
        Me.NumericUpDown1.TabIndex = 10
        '
        'frm_ward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1295, 681)
        Me.Controls.Add(Me.lbl_ward)
        Me.Controls.Add(Me.WardsDataGridView)
        Me.Controls.Add(Me.WardsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_ward"
        Me.Text = "ward"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WardsBindingNavigator.ResumeLayout(False)
        Me.WardsBindingNavigator.PerformLayout()
        CType(Me.WardsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Hospital_managementDataSet As hospital_management_system.hospital_managementDataSet
    Friend WithEvents WardsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WardsTableAdapter As hospital_management_system.hospital_managementDataSetTableAdapters.wardsTableAdapter
    Friend WithEvents TableAdapterManager As hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WardsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WardsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WardsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_ward As System.Windows.Forms.Label
    Friend WithEvents WARD_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WARD_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents AILMENTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
