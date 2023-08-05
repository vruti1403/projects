<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_doctor
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
        Dim DOC_IDLabel As System.Windows.Forms.Label
        Dim DOC_NHSNoLabel As System.Windows.Forms.Label
        Dim DOC_NAMELabel As System.Windows.Forms.Label
        Dim DOC_PHNNoLabel As System.Windows.Forms.Label
        Dim DOC_MAILIDLabel As System.Windows.Forms.Label
        Dim DOC_EXPERIENCELabel As System.Windows.Forms.Label
        Dim DOC_GENDERLabel As System.Windows.Forms.Label
        Dim DOC_SPECIALITYLabel As System.Windows.Forms.Label
        Dim DOC_PASSLabel As System.Windows.Forms.Label
        Dim PATIENT_NHSNoLabel As System.Windows.Forms.Label
        Dim APPOINTMENT_REFLabel As System.Windows.Forms.Label
        Dim DOC_REFLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_doctor))
        Me.Hospital_managementDataSet = New hospital_management_system.hospital_managementDataSet()
        Me.Doctor_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Doctor_detailsTableAdapter = New hospital_management_system.hospital_managementDataSetTableAdapters.doctor_detailsTableAdapter()
        Me.TableAdapterManager = New hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager()
        Me.Doctor_detailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Doctor_detailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Doctor_detailsDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DOC_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DOC_NHSNoTextBox = New System.Windows.Forms.TextBox()
        Me.DOC_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.DOC_PHNNoTextBox = New System.Windows.Forms.TextBox()
        Me.DOC_MAILIDTextBox = New System.Windows.Forms.TextBox()
        Me.DOC_EXPERIENCETextBox = New System.Windows.Forms.TextBox()
        Me.DOC_PASSTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_NHSNoTextBox = New System.Windows.Forms.TextBox()
        Me.APPOINTMENT_REFTextBox = New System.Windows.Forms.TextBox()
        Me.DOC_REFTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_doctor = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        DOC_IDLabel = New System.Windows.Forms.Label()
        DOC_NHSNoLabel = New System.Windows.Forms.Label()
        DOC_NAMELabel = New System.Windows.Forms.Label()
        DOC_PHNNoLabel = New System.Windows.Forms.Label()
        DOC_MAILIDLabel = New System.Windows.Forms.Label()
        DOC_EXPERIENCELabel = New System.Windows.Forms.Label()
        DOC_GENDERLabel = New System.Windows.Forms.Label()
        DOC_SPECIALITYLabel = New System.Windows.Forms.Label()
        DOC_PASSLabel = New System.Windows.Forms.Label()
        PATIENT_NHSNoLabel = New System.Windows.Forms.Label()
        APPOINTMENT_REFLabel = New System.Windows.Forms.Label()
        DOC_REFLabel = New System.Windows.Forms.Label()
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Doctor_detailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Doctor_detailsBindingNavigator.SuspendLayout()
        CType(Me.Doctor_detailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DOC_IDLabel
        '
        DOC_IDLabel.AutoSize = True
        DOC_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_IDLabel.Location = New System.Drawing.Point(34, 19)
        DOC_IDLabel.Name = "DOC_IDLabel"
        DOC_IDLabel.Size = New System.Drawing.Size(71, 18)
        DOC_IDLabel.TabIndex = 0
        DOC_IDLabel.Text = "DOC ID:"
        '
        'DOC_NHSNoLabel
        '
        DOC_NHSNoLabel.AutoSize = True
        DOC_NHSNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_NHSNoLabel.Location = New System.Drawing.Point(34, 47)
        DOC_NHSNoLabel.Name = "DOC_NHSNoLabel"
        DOC_NHSNoLabel.Size = New System.Drawing.Size(112, 18)
        DOC_NHSNoLabel.TabIndex = 2
        DOC_NHSNoLabel.Text = "DOC NHSNo:"
        '
        'DOC_NAMELabel
        '
        DOC_NAMELabel.AutoSize = True
        DOC_NAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_NAMELabel.Location = New System.Drawing.Point(34, 75)
        DOC_NAMELabel.Name = "DOC_NAMELabel"
        DOC_NAMELabel.Size = New System.Drawing.Size(102, 18)
        DOC_NAMELabel.TabIndex = 4
        DOC_NAMELabel.Text = "DOC NAME:"
        '
        'DOC_PHNNoLabel
        '
        DOC_PHNNoLabel.AutoSize = True
        DOC_PHNNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_PHNNoLabel.Location = New System.Drawing.Point(34, 103)
        DOC_PHNNoLabel.Name = "DOC_PHNNoLabel"
        DOC_PHNNoLabel.Size = New System.Drawing.Size(112, 18)
        DOC_PHNNoLabel.TabIndex = 6
        DOC_PHNNoLabel.Text = "DOC PHNNo:"
        '
        'DOC_MAILIDLabel
        '
        DOC_MAILIDLabel.AutoSize = True
        DOC_MAILIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_MAILIDLabel.Location = New System.Drawing.Point(34, 131)
        DOC_MAILIDLabel.Name = "DOC_MAILIDLabel"
        DOC_MAILIDLabel.Size = New System.Drawing.Size(108, 18)
        DOC_MAILIDLabel.TabIndex = 8
        DOC_MAILIDLabel.Text = "DOC MAILID:"
        '
        'DOC_EXPERIENCELabel
        '
        DOC_EXPERIENCELabel.AutoSize = True
        DOC_EXPERIENCELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_EXPERIENCELabel.Location = New System.Drawing.Point(34, 156)
        DOC_EXPERIENCELabel.Name = "DOC_EXPERIENCELabel"
        DOC_EXPERIENCELabel.Size = New System.Drawing.Size(161, 18)
        DOC_EXPERIENCELabel.TabIndex = 10
        DOC_EXPERIENCELabel.Text = "DOC EXPERIENCE:"
        '
        'DOC_GENDERLabel
        '
        DOC_GENDERLabel.AutoSize = True
        DOC_GENDERLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_GENDERLabel.Location = New System.Drawing.Point(33, 184)
        DOC_GENDERLabel.Name = "DOC_GENDERLabel"
        DOC_GENDERLabel.Size = New System.Drawing.Size(126, 18)
        DOC_GENDERLabel.TabIndex = 12
        DOC_GENDERLabel.Text = "DOC GENDER:"
        '
        'DOC_SPECIALITYLabel
        '
        DOC_SPECIALITYLabel.AutoSize = True
        DOC_SPECIALITYLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_SPECIALITYLabel.Location = New System.Drawing.Point(33, 212)
        DOC_SPECIALITYLabel.Name = "DOC_SPECIALITYLabel"
        DOC_SPECIALITYLabel.Size = New System.Drawing.Size(147, 18)
        DOC_SPECIALITYLabel.TabIndex = 14
        DOC_SPECIALITYLabel.Text = "DOC SPECIALITY:"
        '
        'DOC_PASSLabel
        '
        DOC_PASSLabel.AutoSize = True
        DOC_PASSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_PASSLabel.Location = New System.Drawing.Point(34, 244)
        DOC_PASSLabel.Name = "DOC_PASSLabel"
        DOC_PASSLabel.Size = New System.Drawing.Size(98, 18)
        DOC_PASSLabel.TabIndex = 16
        DOC_PASSLabel.Text = "DOC PASS:"
        '
        'PATIENT_NHSNoLabel
        '
        PATIENT_NHSNoLabel.AutoSize = True
        PATIENT_NHSNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_NHSNoLabel.Location = New System.Drawing.Point(34, 274)
        PATIENT_NHSNoLabel.Name = "PATIENT_NHSNoLabel"
        PATIENT_NHSNoLabel.Size = New System.Drawing.Size(143, 18)
        PATIENT_NHSNoLabel.TabIndex = 18
        PATIENT_NHSNoLabel.Text = "PATIENT NHSNo:"
        '
        'APPOINTMENT_REFLabel
        '
        APPOINTMENT_REFLabel.AutoSize = True
        APPOINTMENT_REFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        APPOINTMENT_REFLabel.Location = New System.Drawing.Point(34, 304)
        APPOINTMENT_REFLabel.Name = "APPOINTMENT_REFLabel"
        APPOINTMENT_REFLabel.Size = New System.Drawing.Size(169, 18)
        APPOINTMENT_REFLabel.TabIndex = 20
        APPOINTMENT_REFLabel.Text = "APPOINTMENT REF:"
        '
        'DOC_REFLabel
        '
        DOC_REFLabel.AutoSize = True
        DOC_REFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_REFLabel.Location = New System.Drawing.Point(34, 334)
        DOC_REFLabel.Name = "DOC_REFLabel"
        DOC_REFLabel.Size = New System.Drawing.Size(88, 18)
        DOC_REFLabel.TabIndex = 22
        DOC_REFLabel.Text = "DOC REF:"
        '
        'Hospital_managementDataSet
        '
        Me.Hospital_managementDataSet.DataSetName = "hospital_managementDataSet"
        Me.Hospital_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_detailsBindingSource
        '
        Me.Doctor_detailsBindingSource.DataMember = "doctor_details"
        Me.Doctor_detailsBindingSource.DataSource = Me.Hospital_managementDataSet
        '
        'Doctor_detailsTableAdapter
        '
        Me.Doctor_detailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.doctor_detailsTableAdapter = Me.Doctor_detailsTableAdapter
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.patient_detailsTableAdapter = Nothing
        Me.TableAdapterManager.paymentsTableAdapter = Nothing
        Me.TableAdapterManager.pharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        '
        'Doctor_detailsBindingNavigator
        '
        Me.Doctor_detailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Doctor_detailsBindingNavigator.BindingSource = Me.Doctor_detailsBindingSource
        Me.Doctor_detailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Doctor_detailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Doctor_detailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Doctor_detailsBindingNavigatorSaveItem})
        Me.Doctor_detailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Doctor_detailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Doctor_detailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Doctor_detailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Doctor_detailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Doctor_detailsBindingNavigator.Name = "Doctor_detailsBindingNavigator"
        Me.Doctor_detailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Doctor_detailsBindingNavigator.Size = New System.Drawing.Size(1295, 27)
        Me.Doctor_detailsBindingNavigator.TabIndex = 0
        Me.Doctor_detailsBindingNavigator.Text = "BindingNavigator1"
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
        'Doctor_detailsBindingNavigatorSaveItem
        '
        Me.Doctor_detailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Doctor_detailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Doctor_detailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Doctor_detailsBindingNavigatorSaveItem.Name = "Doctor_detailsBindingNavigatorSaveItem"
        Me.Doctor_detailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Doctor_detailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Doctor_detailsDataGridView
        '
        Me.Doctor_detailsDataGridView.AutoGenerateColumns = False
        Me.Doctor_detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Doctor_detailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Doctor_detailsDataGridView.DataSource = Me.Doctor_detailsBindingSource
        Me.Doctor_detailsDataGridView.Location = New System.Drawing.Point(25, 479)
        Me.Doctor_detailsDataGridView.Name = "Doctor_detailsDataGridView"
        Me.Doctor_detailsDataGridView.RowTemplate.Height = 24
        Me.Doctor_detailsDataGridView.Size = New System.Drawing.Size(1248, 190)
        Me.Doctor_detailsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DOC_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DOC_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DOC_NHSNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DOC_NHSNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DOC_NAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DOC_NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DOC_PHNNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOC_PHNNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DOC_MAILID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DOC_MAILID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOC_EXPERIENCE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOC_EXPERIENCE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DOC_GENDER"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DOC_GENDER"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DOC_SPECIALITY"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DOC_SPECIALITY"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DOC_PASS"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DOC_PASS"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PATIENT_NHSNo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PATIENT_NHSNo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "APPOINTMENT_REF"
        Me.DataGridViewTextBoxColumn11.HeaderText = "APPOINTMENT_REF"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DOC_REF"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DOC_REF"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(DOC_IDLabel)
        Me.Panel1.Controls.Add(Me.DOC_IDTextBox)
        Me.Panel1.Controls.Add(DOC_NHSNoLabel)
        Me.Panel1.Controls.Add(Me.DOC_NHSNoTextBox)
        Me.Panel1.Controls.Add(DOC_NAMELabel)
        Me.Panel1.Controls.Add(Me.DOC_NAMETextBox)
        Me.Panel1.Controls.Add(DOC_PHNNoLabel)
        Me.Panel1.Controls.Add(Me.DOC_PHNNoTextBox)
        Me.Panel1.Controls.Add(DOC_MAILIDLabel)
        Me.Panel1.Controls.Add(Me.DOC_MAILIDTextBox)
        Me.Panel1.Controls.Add(DOC_EXPERIENCELabel)
        Me.Panel1.Controls.Add(Me.DOC_EXPERIENCETextBox)
        Me.Panel1.Controls.Add(DOC_GENDERLabel)
        Me.Panel1.Controls.Add(DOC_SPECIALITYLabel)
        Me.Panel1.Controls.Add(DOC_PASSLabel)
        Me.Panel1.Controls.Add(Me.DOC_PASSTextBox)
        Me.Panel1.Controls.Add(PATIENT_NHSNoLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_NHSNoTextBox)
        Me.Panel1.Controls.Add(APPOINTMENT_REFLabel)
        Me.Panel1.Controls.Add(Me.APPOINTMENT_REFTextBox)
        Me.Panel1.Controls.Add(DOC_REFLabel)
        Me.Panel1.Controls.Add(Me.DOC_REFTextBox)
        Me.Panel1.Location = New System.Drawing.Point(61, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 379)
        Me.Panel1.TabIndex = 2
        '
        'DOC_IDTextBox
        '
        Me.DOC_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "DOC_ID", True))
        Me.DOC_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_IDTextBox.Location = New System.Drawing.Point(224, 13)
        Me.DOC_IDTextBox.Name = "DOC_IDTextBox"
        Me.DOC_IDTextBox.Size = New System.Drawing.Size(249, 24)
        Me.DOC_IDTextBox.TabIndex = 1
        '
        'DOC_NHSNoTextBox
        '
        Me.DOC_NHSNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "DOC_NHSNo", True))
        Me.DOC_NHSNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_NHSNoTextBox.Location = New System.Drawing.Point(224, 41)
        Me.DOC_NHSNoTextBox.Name = "DOC_NHSNoTextBox"
        Me.DOC_NHSNoTextBox.Size = New System.Drawing.Size(249, 24)
        Me.DOC_NHSNoTextBox.TabIndex = 3
        '
        'DOC_NAMETextBox
        '
        Me.DOC_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "DOC_NAME", True))
        Me.DOC_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_NAMETextBox.Location = New System.Drawing.Point(224, 69)
        Me.DOC_NAMETextBox.Name = "DOC_NAMETextBox"
        Me.DOC_NAMETextBox.Size = New System.Drawing.Size(249, 24)
        Me.DOC_NAMETextBox.TabIndex = 5
        '
        'DOC_PHNNoTextBox
        '
        Me.DOC_PHNNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "DOC_PHNNo", True))
        Me.DOC_PHNNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_PHNNoTextBox.Location = New System.Drawing.Point(224, 97)
        Me.DOC_PHNNoTextBox.Name = "DOC_PHNNoTextBox"
        Me.DOC_PHNNoTextBox.Size = New System.Drawing.Size(249, 24)
        Me.DOC_PHNNoTextBox.TabIndex = 7
        '
        'DOC_MAILIDTextBox
        '
        Me.DOC_MAILIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "DOC_MAILID", True))
        Me.DOC_MAILIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_MAILIDTextBox.Location = New System.Drawing.Point(224, 125)
        Me.DOC_MAILIDTextBox.Name = "DOC_MAILIDTextBox"
        Me.DOC_MAILIDTextBox.Size = New System.Drawing.Size(249, 24)
        Me.DOC_MAILIDTextBox.TabIndex = 9
        '
        'DOC_EXPERIENCETextBox
        '
        Me.DOC_EXPERIENCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "DOC_EXPERIENCE", True))
        Me.DOC_EXPERIENCETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_EXPERIENCETextBox.Location = New System.Drawing.Point(224, 153)
        Me.DOC_EXPERIENCETextBox.Name = "DOC_EXPERIENCETextBox"
        Me.DOC_EXPERIENCETextBox.Size = New System.Drawing.Size(249, 24)
        Me.DOC_EXPERIENCETextBox.TabIndex = 11
        '
        'DOC_PASSTextBox
        '
        Me.DOC_PASSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "DOC_PASS", True))
        Me.DOC_PASSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_PASSTextBox.Location = New System.Drawing.Point(224, 244)
        Me.DOC_PASSTextBox.Name = "DOC_PASSTextBox"
        Me.DOC_PASSTextBox.Size = New System.Drawing.Size(249, 24)
        Me.DOC_PASSTextBox.TabIndex = 17
        '
        'PATIENT_NHSNoTextBox
        '
        Me.PATIENT_NHSNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "PATIENT_NHSNo", True))
        Me.PATIENT_NHSNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_NHSNoTextBox.Location = New System.Drawing.Point(224, 274)
        Me.PATIENT_NHSNoTextBox.Name = "PATIENT_NHSNoTextBox"
        Me.PATIENT_NHSNoTextBox.Size = New System.Drawing.Size(249, 24)
        Me.PATIENT_NHSNoTextBox.TabIndex = 19
        '
        'APPOINTMENT_REFTextBox
        '
        Me.APPOINTMENT_REFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "APPOINTMENT_REF", True))
        Me.APPOINTMENT_REFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APPOINTMENT_REFTextBox.Location = New System.Drawing.Point(224, 304)
        Me.APPOINTMENT_REFTextBox.Name = "APPOINTMENT_REFTextBox"
        Me.APPOINTMENT_REFTextBox.Size = New System.Drawing.Size(249, 24)
        Me.APPOINTMENT_REFTextBox.TabIndex = 21
        '
        'DOC_REFTextBox
        '
        Me.DOC_REFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Doctor_detailsBindingSource, "DOC_REF", True))
        Me.DOC_REFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_REFTextBox.Location = New System.Drawing.Point(224, 334)
        Me.DOC_REFTextBox.Name = "DOC_REFTextBox"
        Me.DOC_REFTextBox.Size = New System.Drawing.Size(249, 24)
        Me.DOC_REFTextBox.TabIndex = 23
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
        Me.Panel2.TabIndex = 3
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
        'lbl_doctor
        '
        Me.lbl_doctor.AutoSize = True
        Me.lbl_doctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doctor.ForeColor = System.Drawing.Color.Purple
        Me.lbl_doctor.Location = New System.Drawing.Point(607, 37)
        Me.lbl_doctor.Name = "lbl_doctor"
        Me.lbl_doctor.Size = New System.Drawing.Size(296, 32)
        Me.lbl_doctor.TabIndex = 4
        Me.lbl_doctor.Text = "DOCTORS MODULE"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(394, 185)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(81, 21)
        Me.RadioButton3.TabIndex = 29
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "TRANS"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(299, 184)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 21)
        Me.RadioButton2.TabIndex = 28
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "FEMALE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(223, 184)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 21)
        Me.RadioButton1.TabIndex = 27
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "MALE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"dermatologist", "anesthesiology", "pediatrics", "clinical pathology", "diagnostic radiology", "psychiatric", "nephrology", "cardiologist"})
        Me.ComboBox1.Location = New System.Drawing.Point(224, 214)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(249, 24)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "select speciality"
        '
        'frm_doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1295, 681)
        Me.Controls.Add(Me.lbl_doctor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Doctor_detailsDataGridView)
        Me.Controls.Add(Me.Doctor_detailsBindingNavigator)
        Me.Name = "frm_doctor"
        Me.Text = "doctor"
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Doctor_detailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Doctor_detailsBindingNavigator.ResumeLayout(False)
        Me.Doctor_detailsBindingNavigator.PerformLayout()
        CType(Me.Doctor_detailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hospital_managementDataSet As hospital_management_system.hospital_managementDataSet
    Friend WithEvents Doctor_detailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Doctor_detailsTableAdapter As hospital_management_system.hospital_managementDataSetTableAdapters.doctor_detailsTableAdapter
    Friend WithEvents TableAdapterManager As hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Doctor_detailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Doctor_detailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Doctor_detailsDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DOC_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_NHSNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_PHNNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_MAILIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_EXPERIENCETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_PASSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_NHSNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APPOINTMENT_REFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_REFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents lbl_doctor As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
