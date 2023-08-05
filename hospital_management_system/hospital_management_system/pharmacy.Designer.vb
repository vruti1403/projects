<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pharmacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pharmacy))
        Dim PATIENTIDLabel As System.Windows.Forms.Label
        Dim DRUGIDLabel As System.Windows.Forms.Label
        Dim DOC_NHSNoLabel As System.Windows.Forms.Label
        Dim ADMINISTRATIONLabel As System.Windows.Forms.Label
        Dim NAME_OF_TABLETSLabel As System.Windows.Forms.Label
        Dim DOSAGE_MGLabel As System.Windows.Forms.Label
        Dim LOTLabel As System.Windows.Forms.Label
        Dim DATE_ISSUEDLabel As System.Windows.Forms.Label
        Dim EXP_DATELabel As System.Windows.Forms.Label
        Dim SIDE_EFFECTSLabel As System.Windows.Forms.Label
        Dim STORAGE_ADVICELabel As System.Windows.Forms.Label
        Dim INTERACTIONSLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_pharmacy = New System.Windows.Forms.Label()
        Me.Hospital_managementDataSet = New hospital_management_system.hospital_managementDataSet()
        Me.PharmacyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacyTableAdapter = New hospital_management_system.hospital_managementDataSetTableAdapters.pharmacyTableAdapter()
        Me.TableAdapterManager = New hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager()
        Me.PharmacyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PharmacyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PATIENTIDTextBox = New System.Windows.Forms.TextBox()
        Me.DRUGIDTextBox = New System.Windows.Forms.TextBox()
        Me.DOC_NHSNoTextBox = New System.Windows.Forms.TextBox()
        Me.ADMINISTRATIONTextBox = New System.Windows.Forms.TextBox()
        Me.NAME_OF_TABLETSTextBox = New System.Windows.Forms.TextBox()
        Me.DOSAGE_MGTextBox = New System.Windows.Forms.TextBox()
        Me.LOTTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_ISSUEDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EXP_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SIDE_EFFECTSTextBox = New System.Windows.Forms.TextBox()
        Me.STORAGE_ADVICETextBox = New System.Windows.Forms.TextBox()
        Me.INTERACTIONSTextBox = New System.Windows.Forms.TextBox()
        Me.PharmacyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        PATIENTIDLabel = New System.Windows.Forms.Label()
        DRUGIDLabel = New System.Windows.Forms.Label()
        DOC_NHSNoLabel = New System.Windows.Forms.Label()
        ADMINISTRATIONLabel = New System.Windows.Forms.Label()
        NAME_OF_TABLETSLabel = New System.Windows.Forms.Label()
        DOSAGE_MGLabel = New System.Windows.Forms.Label()
        LOTLabel = New System.Windows.Forms.Label()
        DATE_ISSUEDLabel = New System.Windows.Forms.Label()
        EXP_DATELabel = New System.Windows.Forms.Label()
        SIDE_EFFECTSLabel = New System.Windows.Forms.Label()
        STORAGE_ADVICELabel = New System.Windows.Forms.Label()
        INTERACTIONSLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PharmacyBindingNavigator.SuspendLayout()
        CType(Me.PharmacyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(PATIENTIDLabel)
        Me.Panel1.Controls.Add(Me.PATIENTIDTextBox)
        Me.Panel1.Controls.Add(DRUGIDLabel)
        Me.Panel1.Controls.Add(Me.DRUGIDTextBox)
        Me.Panel1.Controls.Add(DOC_NHSNoLabel)
        Me.Panel1.Controls.Add(Me.DOC_NHSNoTextBox)
        Me.Panel1.Controls.Add(ADMINISTRATIONLabel)
        Me.Panel1.Controls.Add(Me.ADMINISTRATIONTextBox)
        Me.Panel1.Controls.Add(NAME_OF_TABLETSLabel)
        Me.Panel1.Controls.Add(Me.NAME_OF_TABLETSTextBox)
        Me.Panel1.Controls.Add(DOSAGE_MGLabel)
        Me.Panel1.Controls.Add(Me.DOSAGE_MGTextBox)
        Me.Panel1.Controls.Add(LOTLabel)
        Me.Panel1.Controls.Add(Me.LOTTextBox)
        Me.Panel1.Controls.Add(DATE_ISSUEDLabel)
        Me.Panel1.Controls.Add(Me.DATE_ISSUEDDateTimePicker)
        Me.Panel1.Controls.Add(EXP_DATELabel)
        Me.Panel1.Controls.Add(Me.EXP_DATEDateTimePicker)
        Me.Panel1.Controls.Add(SIDE_EFFECTSLabel)
        Me.Panel1.Controls.Add(Me.SIDE_EFFECTSTextBox)
        Me.Panel1.Controls.Add(STORAGE_ADVICELabel)
        Me.Panel1.Controls.Add(Me.STORAGE_ADVICETextBox)
        Me.Panel1.Controls.Add(INTERACTIONSLabel)
        Me.Panel1.Controls.Add(Me.INTERACTIONSTextBox)
        Me.Panel1.Location = New System.Drawing.Point(61, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 379)
        Me.Panel1.TabIndex = 6
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
        Me.Panel2.TabIndex = 7
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
        'lbl_pharmacy
        '
        Me.lbl_pharmacy.AutoSize = True
        Me.lbl_pharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pharmacy.ForeColor = System.Drawing.Color.Purple
        Me.lbl_pharmacy.Location = New System.Drawing.Point(607, 37)
        Me.lbl_pharmacy.Name = "lbl_pharmacy"
        Me.lbl_pharmacy.Size = New System.Drawing.Size(316, 32)
        Me.lbl_pharmacy.TabIndex = 8
        Me.lbl_pharmacy.Text = "PHARMACY MODULE"
        '
        'Hospital_managementDataSet
        '
        Me.Hospital_managementDataSet.DataSetName = "hospital_managementDataSet"
        Me.Hospital_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PharmacyBindingSource
        '
        Me.PharmacyBindingSource.DataMember = "pharmacy"
        Me.PharmacyBindingSource.DataSource = Me.Hospital_managementDataSet
        '
        'PharmacyTableAdapter
        '
        Me.PharmacyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.doctor_detailsTableAdapter = Nothing
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.patient_detailsTableAdapter = Nothing
        Me.TableAdapterManager.paymentsTableAdapter = Nothing
        Me.TableAdapterManager.pharmacyTableAdapter = Me.PharmacyTableAdapter
        Me.TableAdapterManager.UpdateOrder = hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        '
        'PharmacyBindingNavigator
        '
        Me.PharmacyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PharmacyBindingNavigator.BindingSource = Me.PharmacyBindingSource
        Me.PharmacyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PharmacyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PharmacyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PharmacyBindingNavigatorSaveItem})
        Me.PharmacyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PharmacyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PharmacyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PharmacyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PharmacyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PharmacyBindingNavigator.Name = "PharmacyBindingNavigator"
        Me.PharmacyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PharmacyBindingNavigator.Size = New System.Drawing.Size(1295, 27)
        Me.PharmacyBindingNavigator.TabIndex = 9
        Me.PharmacyBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PharmacyBindingNavigatorSaveItem
        '
        Me.PharmacyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PharmacyBindingNavigatorSaveItem.Image = CType(resources.GetObject("PharmacyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PharmacyBindingNavigatorSaveItem.Name = "PharmacyBindingNavigatorSaveItem"
        Me.PharmacyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.PharmacyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PATIENTIDLabel
        '
        PATIENTIDLabel.AutoSize = True
        PATIENTIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENTIDLabel.Location = New System.Drawing.Point(16, 26)
        PATIENTIDLabel.Name = "PATIENTIDLabel"
        PATIENTIDLabel.Size = New System.Drawing.Size(97, 18)
        PATIENTIDLabel.TabIndex = 0
        PATIENTIDLabel.Text = "PATIENTID:"
        '
        'PATIENTIDTextBox
        '
        Me.PATIENTIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "PATIENTID", True))
        Me.PATIENTIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENTIDTextBox.Location = New System.Drawing.Point(219, 20)
        Me.PATIENTIDTextBox.Name = "PATIENTIDTextBox"
        Me.PATIENTIDTextBox.Size = New System.Drawing.Size(299, 24)
        Me.PATIENTIDTextBox.TabIndex = 1
        '
        'DRUGIDLabel
        '
        DRUGIDLabel.AutoSize = True
        DRUGIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DRUGIDLabel.Location = New System.Drawing.Point(16, 54)
        DRUGIDLabel.Name = "DRUGIDLabel"
        DRUGIDLabel.Size = New System.Drawing.Size(78, 18)
        DRUGIDLabel.TabIndex = 2
        DRUGIDLabel.Text = "DRUGID:"
        '
        'DRUGIDTextBox
        '
        Me.DRUGIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "DRUGID", True))
        Me.DRUGIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRUGIDTextBox.Location = New System.Drawing.Point(219, 48)
        Me.DRUGIDTextBox.Name = "DRUGIDTextBox"
        Me.DRUGIDTextBox.Size = New System.Drawing.Size(299, 24)
        Me.DRUGIDTextBox.TabIndex = 3
        '
        'DOC_NHSNoLabel
        '
        DOC_NHSNoLabel.AutoSize = True
        DOC_NHSNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_NHSNoLabel.Location = New System.Drawing.Point(16, 82)
        DOC_NHSNoLabel.Name = "DOC_NHSNoLabel"
        DOC_NHSNoLabel.Size = New System.Drawing.Size(112, 18)
        DOC_NHSNoLabel.TabIndex = 4
        DOC_NHSNoLabel.Text = "DOC NHSNo:"
        '
        'DOC_NHSNoTextBox
        '
        Me.DOC_NHSNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "DOC_NHSNo", True))
        Me.DOC_NHSNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_NHSNoTextBox.Location = New System.Drawing.Point(219, 76)
        Me.DOC_NHSNoTextBox.Name = "DOC_NHSNoTextBox"
        Me.DOC_NHSNoTextBox.Size = New System.Drawing.Size(299, 24)
        Me.DOC_NHSNoTextBox.TabIndex = 5
        '
        'ADMINISTRATIONLabel
        '
        ADMINISTRATIONLabel.AutoSize = True
        ADMINISTRATIONLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ADMINISTRATIONLabel.Location = New System.Drawing.Point(16, 110)
        ADMINISTRATIONLabel.Name = "ADMINISTRATIONLabel"
        ADMINISTRATIONLabel.Size = New System.Drawing.Size(151, 18)
        ADMINISTRATIONLabel.TabIndex = 6
        ADMINISTRATIONLabel.Text = "ADMINISTRATION:"
        '
        'ADMINISTRATIONTextBox
        '
        Me.ADMINISTRATIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "ADMINISTRATION", True))
        Me.ADMINISTRATIONTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADMINISTRATIONTextBox.Location = New System.Drawing.Point(219, 104)
        Me.ADMINISTRATIONTextBox.Name = "ADMINISTRATIONTextBox"
        Me.ADMINISTRATIONTextBox.Size = New System.Drawing.Size(299, 24)
        Me.ADMINISTRATIONTextBox.TabIndex = 7
        '
        'NAME_OF_TABLETSLabel
        '
        NAME_OF_TABLETSLabel.AutoSize = True
        NAME_OF_TABLETSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NAME_OF_TABLETSLabel.Location = New System.Drawing.Point(16, 138)
        NAME_OF_TABLETSLabel.Name = "NAME_OF_TABLETSLabel"
        NAME_OF_TABLETSLabel.Size = New System.Drawing.Size(165, 18)
        NAME_OF_TABLETSLabel.TabIndex = 8
        NAME_OF_TABLETSLabel.Text = "NAME OF TABLETS:"
        '
        'NAME_OF_TABLETSTextBox
        '
        Me.NAME_OF_TABLETSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "NAME_OF_TABLETS", True))
        Me.NAME_OF_TABLETSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAME_OF_TABLETSTextBox.Location = New System.Drawing.Point(219, 135)
        Me.NAME_OF_TABLETSTextBox.Name = "NAME_OF_TABLETSTextBox"
        Me.NAME_OF_TABLETSTextBox.Size = New System.Drawing.Size(299, 24)
        Me.NAME_OF_TABLETSTextBox.TabIndex = 9
        '
        'DOSAGE_MGLabel
        '
        DOSAGE_MGLabel.AutoSize = True
        DOSAGE_MGLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOSAGE_MGLabel.Location = New System.Drawing.Point(16, 166)
        DOSAGE_MGLabel.Name = "DOSAGE_MGLabel"
        DOSAGE_MGLabel.Size = New System.Drawing.Size(115, 18)
        DOSAGE_MGLabel.TabIndex = 10
        DOSAGE_MGLabel.Text = "DOSAGE MG:"
        '
        'DOSAGE_MGTextBox
        '
        Me.DOSAGE_MGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "DOSAGE_MG", True))
        Me.DOSAGE_MGTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOSAGE_MGTextBox.Location = New System.Drawing.Point(219, 163)
        Me.DOSAGE_MGTextBox.Name = "DOSAGE_MGTextBox"
        Me.DOSAGE_MGTextBox.Size = New System.Drawing.Size(299, 24)
        Me.DOSAGE_MGTextBox.TabIndex = 11
        '
        'LOTLabel
        '
        LOTLabel.AutoSize = True
        LOTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LOTLabel.Location = New System.Drawing.Point(16, 194)
        LOTLabel.Name = "LOTLabel"
        LOTLabel.Size = New System.Drawing.Size(45, 18)
        LOTLabel.TabIndex = 12
        LOTLabel.Text = "LOT:"
        '
        'LOTTextBox
        '
        Me.LOTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "LOT", True))
        Me.LOTTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOTTextBox.Location = New System.Drawing.Point(219, 191)
        Me.LOTTextBox.Name = "LOTTextBox"
        Me.LOTTextBox.Size = New System.Drawing.Size(299, 24)
        Me.LOTTextBox.TabIndex = 13
        '
        'DATE_ISSUEDLabel
        '
        DATE_ISSUEDLabel.AutoSize = True
        DATE_ISSUEDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATE_ISSUEDLabel.Location = New System.Drawing.Point(16, 223)
        DATE_ISSUEDLabel.Name = "DATE_ISSUEDLabel"
        DATE_ISSUEDLabel.Size = New System.Drawing.Size(122, 18)
        DATE_ISSUEDLabel.TabIndex = 14
        DATE_ISSUEDLabel.Text = "DATE ISSUED:"
        '
        'DATE_ISSUEDDateTimePicker
        '
        Me.DATE_ISSUEDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PharmacyBindingSource, "DATE_ISSUED", True))
        Me.DATE_ISSUEDDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATE_ISSUEDDateTimePicker.Location = New System.Drawing.Point(219, 219)
        Me.DATE_ISSUEDDateTimePicker.Name = "DATE_ISSUEDDateTimePicker"
        Me.DATE_ISSUEDDateTimePicker.Size = New System.Drawing.Size(299, 24)
        Me.DATE_ISSUEDDateTimePicker.TabIndex = 15
        '
        'EXP_DATELabel
        '
        EXP_DATELabel.AutoSize = True
        EXP_DATELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EXP_DATELabel.Location = New System.Drawing.Point(16, 251)
        EXP_DATELabel.Name = "EXP_DATELabel"
        EXP_DATELabel.Size = New System.Drawing.Size(94, 18)
        EXP_DATELabel.TabIndex = 16
        EXP_DATELabel.Text = "EXP DATE:"
        '
        'EXP_DATEDateTimePicker
        '
        Me.EXP_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PharmacyBindingSource, "EXP_DATE", True))
        Me.EXP_DATEDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXP_DATEDateTimePicker.Location = New System.Drawing.Point(219, 247)
        Me.EXP_DATEDateTimePicker.Name = "EXP_DATEDateTimePicker"
        Me.EXP_DATEDateTimePicker.Size = New System.Drawing.Size(299, 24)
        Me.EXP_DATEDateTimePicker.TabIndex = 17
        '
        'SIDE_EFFECTSLabel
        '
        SIDE_EFFECTSLabel.AutoSize = True
        SIDE_EFFECTSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SIDE_EFFECTSLabel.Location = New System.Drawing.Point(16, 278)
        SIDE_EFFECTSLabel.Name = "SIDE_EFFECTSLabel"
        SIDE_EFFECTSLabel.Size = New System.Drawing.Size(131, 18)
        SIDE_EFFECTSLabel.TabIndex = 18
        SIDE_EFFECTSLabel.Text = "SIDE EFFECTS:"
        '
        'SIDE_EFFECTSTextBox
        '
        Me.SIDE_EFFECTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "SIDE_EFFECTS", True))
        Me.SIDE_EFFECTSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIDE_EFFECTSTextBox.Location = New System.Drawing.Point(219, 275)
        Me.SIDE_EFFECTSTextBox.Name = "SIDE_EFFECTSTextBox"
        Me.SIDE_EFFECTSTextBox.Size = New System.Drawing.Size(299, 24)
        Me.SIDE_EFFECTSTextBox.TabIndex = 19
        '
        'STORAGE_ADVICELabel
        '
        STORAGE_ADVICELabel.AutoSize = True
        STORAGE_ADVICELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        STORAGE_ADVICELabel.Location = New System.Drawing.Point(16, 306)
        STORAGE_ADVICELabel.Name = "STORAGE_ADVICELabel"
        STORAGE_ADVICELabel.Size = New System.Drawing.Size(157, 18)
        STORAGE_ADVICELabel.TabIndex = 20
        STORAGE_ADVICELabel.Text = "STORAGE ADVICE:"
        '
        'STORAGE_ADVICETextBox
        '
        Me.STORAGE_ADVICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "STORAGE_ADVICE", True))
        Me.STORAGE_ADVICETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STORAGE_ADVICETextBox.Location = New System.Drawing.Point(219, 303)
        Me.STORAGE_ADVICETextBox.Name = "STORAGE_ADVICETextBox"
        Me.STORAGE_ADVICETextBox.Size = New System.Drawing.Size(299, 24)
        Me.STORAGE_ADVICETextBox.TabIndex = 21
        '
        'INTERACTIONSLabel
        '
        INTERACTIONSLabel.AutoSize = True
        INTERACTIONSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        INTERACTIONSLabel.Location = New System.Drawing.Point(16, 334)
        INTERACTIONSLabel.Name = "INTERACTIONSLabel"
        INTERACTIONSLabel.Size = New System.Drawing.Size(134, 18)
        INTERACTIONSLabel.TabIndex = 22
        INTERACTIONSLabel.Text = "INTERACTIONS:"
        '
        'INTERACTIONSTextBox
        '
        Me.INTERACTIONSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmacyBindingSource, "INTERACTIONS", True))
        Me.INTERACTIONSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INTERACTIONSTextBox.Location = New System.Drawing.Point(219, 333)
        Me.INTERACTIONSTextBox.Name = "INTERACTIONSTextBox"
        Me.INTERACTIONSTextBox.Size = New System.Drawing.Size(299, 24)
        Me.INTERACTIONSTextBox.TabIndex = 23
        '
        'PharmacyDataGridView
        '
        Me.PharmacyDataGridView.AutoGenerateColumns = False
        Me.PharmacyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PharmacyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.PharmacyDataGridView.DataSource = Me.PharmacyBindingSource
        Me.PharmacyDataGridView.Location = New System.Drawing.Point(23, 488)
        Me.PharmacyDataGridView.Name = "PharmacyDataGridView"
        Me.PharmacyDataGridView.RowTemplate.Height = 24
        Me.PharmacyDataGridView.Size = New System.Drawing.Size(1251, 220)
        Me.PharmacyDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PATIENTID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PATIENTID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DRUGID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DRUGID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DOC_NHSNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DOC_NHSNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ADMINISTRATION"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ADMINISTRATION"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NAME_OF_TABLETS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NAME_OF_TABLETS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOSAGE_MG"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOSAGE_MG"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LOT"
        Me.DataGridViewTextBoxColumn7.HeaderText = "LOT"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DATE_ISSUED"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DATE_ISSUED"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EXP_DATE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "EXP_DATE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SIDE_EFFECTS"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SIDE_EFFECTS"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "STORAGE_ADVICE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "STORAGE_ADVICE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "INTERACTIONS"
        Me.DataGridViewTextBoxColumn12.HeaderText = "INTERACTIONS"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'frm_pharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1295, 880)
        Me.Controls.Add(Me.PharmacyDataGridView)
        Me.Controls.Add(Me.PharmacyBindingNavigator)
        Me.Controls.Add(Me.lbl_pharmacy)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_pharmacy"
        Me.Text = "pharmacy"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PharmacyBindingNavigator.ResumeLayout(False)
        Me.PharmacyBindingNavigator.PerformLayout()
        CType(Me.PharmacyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents lbl_pharmacy As System.Windows.Forms.Label
    Friend WithEvents Hospital_managementDataSet As hospital_management_system.hospital_managementDataSet
    Friend WithEvents PharmacyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PharmacyTableAdapter As hospital_management_system.hospital_managementDataSetTableAdapters.pharmacyTableAdapter
    Friend WithEvents TableAdapterManager As hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PharmacyBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PharmacyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PATIENTIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DRUGIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_NHSNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ADMINISTRATIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAME_OF_TABLETSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOSAGE_MGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LOTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_ISSUEDDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EXP_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SIDE_EFFECTSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STORAGE_ADVICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents INTERACTIONSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PharmacyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
