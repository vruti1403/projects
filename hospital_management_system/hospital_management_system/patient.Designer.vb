<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_patient
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
        Dim PATIENTIDLabel As System.Windows.Forms.Label
        Dim PATIENT_NHSNoLabel As System.Windows.Forms.Label
        Dim PATIENT_NAMELabel As System.Windows.Forms.Label
        Dim PATIENT_PHN_NOLabel As System.Windows.Forms.Label
        Dim PATIENT_DOBLabel As System.Windows.Forms.Label
        Dim PATIENT_GENDERLabel As System.Windows.Forms.Label
        Dim P_BLOOD_GRPLabel As System.Windows.Forms.Label
        Dim PATIENT_DISEASELabel As System.Windows.Forms.Label
        Dim PATIENT_SYMPTOMSLabel As System.Windows.Forms.Label
        Dim PATIENT_ADDRESSLabel As System.Windows.Forms.Label
        Dim PATIENT_COUNTRYLabel As System.Windows.Forms.Label
        Dim PATIENT_NXTOF_KINSHIPLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_patient))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PATIENTIDTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospital_managementDataSet = New hospital_management_system.hospital_managementDataSet()
        Me.PATIENT_NHSNoTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_PHN_NOTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_BLOOD_GRPTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_DISEASETextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_SYMPTOMSTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_NXTOF_KINSHIPTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_patient = New System.Windows.Forms.Label()
        Me.Patient_detailsTableAdapter = New hospital_management_system.hospital_managementDataSetTableAdapters.patient_detailsTableAdapter()
        Me.TableAdapterManager = New hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager()
        Me.Patient_detailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Patient_detailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Patient_detailsDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        PATIENTIDLabel = New System.Windows.Forms.Label()
        PATIENT_NHSNoLabel = New System.Windows.Forms.Label()
        PATIENT_NAMELabel = New System.Windows.Forms.Label()
        PATIENT_PHN_NOLabel = New System.Windows.Forms.Label()
        PATIENT_DOBLabel = New System.Windows.Forms.Label()
        PATIENT_GENDERLabel = New System.Windows.Forms.Label()
        P_BLOOD_GRPLabel = New System.Windows.Forms.Label()
        PATIENT_DISEASELabel = New System.Windows.Forms.Label()
        PATIENT_SYMPTOMSLabel = New System.Windows.Forms.Label()
        PATIENT_ADDRESSLabel = New System.Windows.Forms.Label()
        PATIENT_COUNTRYLabel = New System.Windows.Forms.Label()
        PATIENT_NXTOF_KINSHIPLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Patient_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Patient_detailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Patient_detailsBindingNavigator.SuspendLayout()
        CType(Me.Patient_detailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PATIENTIDLabel
        '
        PATIENTIDLabel.AutoSize = True
        PATIENTIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENTIDLabel.Location = New System.Drawing.Point(27, 32)
        PATIENTIDLabel.Name = "PATIENTIDLabel"
        PATIENTIDLabel.Size = New System.Drawing.Size(97, 18)
        PATIENTIDLabel.TabIndex = 0
        PATIENTIDLabel.Text = "PATIENTID:"
        '
        'PATIENT_NHSNoLabel
        '
        PATIENT_NHSNoLabel.AutoSize = True
        PATIENT_NHSNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_NHSNoLabel.Location = New System.Drawing.Point(27, 60)
        PATIENT_NHSNoLabel.Name = "PATIENT_NHSNoLabel"
        PATIENT_NHSNoLabel.Size = New System.Drawing.Size(143, 18)
        PATIENT_NHSNoLabel.TabIndex = 2
        PATIENT_NHSNoLabel.Text = "PATIENT NHSNo:"
        '
        'PATIENT_NAMELabel
        '
        PATIENT_NAMELabel.AutoSize = True
        PATIENT_NAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_NAMELabel.Location = New System.Drawing.Point(27, 88)
        PATIENT_NAMELabel.Name = "PATIENT_NAMELabel"
        PATIENT_NAMELabel.Size = New System.Drawing.Size(133, 18)
        PATIENT_NAMELabel.TabIndex = 4
        PATIENT_NAMELabel.Text = "PATIENT NAME:"
        '
        'PATIENT_PHN_NOLabel
        '
        PATIENT_PHN_NOLabel.AutoSize = True
        PATIENT_PHN_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_PHN_NOLabel.Location = New System.Drawing.Point(27, 116)
        PATIENT_PHN_NOLabel.Name = "PATIENT_PHN_NOLabel"
        PATIENT_PHN_NOLabel.Size = New System.Drawing.Size(151, 18)
        PATIENT_PHN_NOLabel.TabIndex = 6
        PATIENT_PHN_NOLabel.Text = "PATIENT PHN NO:"
        '
        'PATIENT_DOBLabel
        '
        PATIENT_DOBLabel.AutoSize = True
        PATIENT_DOBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_DOBLabel.Location = New System.Drawing.Point(27, 145)
        PATIENT_DOBLabel.Name = "PATIENT_DOBLabel"
        PATIENT_DOBLabel.Size = New System.Drawing.Size(122, 18)
        PATIENT_DOBLabel.TabIndex = 8
        PATIENT_DOBLabel.Text = "PATIENT DOB:"
        '
        'PATIENT_GENDERLabel
        '
        PATIENT_GENDERLabel.AutoSize = True
        PATIENT_GENDERLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_GENDERLabel.Location = New System.Drawing.Point(27, 172)
        PATIENT_GENDERLabel.Name = "PATIENT_GENDERLabel"
        PATIENT_GENDERLabel.Size = New System.Drawing.Size(157, 18)
        PATIENT_GENDERLabel.TabIndex = 10
        PATIENT_GENDERLabel.Text = "PATIENT GENDER:"
        '
        'P_BLOOD_GRPLabel
        '
        P_BLOOD_GRPLabel.AutoSize = True
        P_BLOOD_GRPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        P_BLOOD_GRPLabel.Location = New System.Drawing.Point(27, 200)
        P_BLOOD_GRPLabel.Name = "P_BLOOD_GRPLabel"
        P_BLOOD_GRPLabel.Size = New System.Drawing.Size(128, 18)
        P_BLOOD_GRPLabel.TabIndex = 12
        P_BLOOD_GRPLabel.Text = "P BLOOD GRP:"
        '
        'PATIENT_DISEASELabel
        '
        PATIENT_DISEASELabel.AutoSize = True
        PATIENT_DISEASELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_DISEASELabel.Location = New System.Drawing.Point(27, 228)
        PATIENT_DISEASELabel.Name = "PATIENT_DISEASELabel"
        PATIENT_DISEASELabel.Size = New System.Drawing.Size(156, 18)
        PATIENT_DISEASELabel.TabIndex = 14
        PATIENT_DISEASELabel.Text = "PATIENT DISEASE:"
        '
        'PATIENT_SYMPTOMSLabel
        '
        PATIENT_SYMPTOMSLabel.AutoSize = True
        PATIENT_SYMPTOMSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_SYMPTOMSLabel.Location = New System.Drawing.Point(27, 256)
        PATIENT_SYMPTOMSLabel.Name = "PATIENT_SYMPTOMSLabel"
        PATIENT_SYMPTOMSLabel.Size = New System.Drawing.Size(180, 18)
        PATIENT_SYMPTOMSLabel.TabIndex = 16
        PATIENT_SYMPTOMSLabel.Text = "PATIENT SYMPTOMS:"
        '
        'PATIENT_ADDRESSLabel
        '
        PATIENT_ADDRESSLabel.AutoSize = True
        PATIENT_ADDRESSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_ADDRESSLabel.Location = New System.Drawing.Point(27, 284)
        PATIENT_ADDRESSLabel.Name = "PATIENT_ADDRESSLabel"
        PATIENT_ADDRESSLabel.Size = New System.Drawing.Size(165, 18)
        PATIENT_ADDRESSLabel.TabIndex = 18
        PATIENT_ADDRESSLabel.Text = "PATIENT ADDRESS:"
        '
        'PATIENT_COUNTRYLabel
        '
        PATIENT_COUNTRYLabel.AutoSize = True
        PATIENT_COUNTRYLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_COUNTRYLabel.Location = New System.Drawing.Point(27, 312)
        PATIENT_COUNTRYLabel.Name = "PATIENT_COUNTRYLabel"
        PATIENT_COUNTRYLabel.Size = New System.Drawing.Size(167, 18)
        PATIENT_COUNTRYLabel.TabIndex = 20
        PATIENT_COUNTRYLabel.Text = "PATIENT COUNTRY:"
        '
        'PATIENT_NXTOF_KINSHIPLabel
        '
        PATIENT_NXTOF_KINSHIPLabel.AutoSize = True
        PATIENT_NXTOF_KINSHIPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_NXTOF_KINSHIPLabel.Location = New System.Drawing.Point(27, 340)
        PATIENT_NXTOF_KINSHIPLabel.Name = "PATIENT_NXTOF_KINSHIPLabel"
        PATIENT_NXTOF_KINSHIPLabel.Size = New System.Drawing.Size(212, 18)
        PATIENT_NXTOF_KINSHIPLabel.TabIndex = 22
        PATIENT_NXTOF_KINSHIPLabel.Text = "PATIENT NXTOF KINSHIP:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(PATIENTIDLabel)
        Me.Panel1.Controls.Add(Me.PATIENTIDTextBox)
        Me.Panel1.Controls.Add(PATIENT_NHSNoLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_NHSNoTextBox)
        Me.Panel1.Controls.Add(PATIENT_NAMELabel)
        Me.Panel1.Controls.Add(Me.PATIENT_NAMETextBox)
        Me.Panel1.Controls.Add(PATIENT_PHN_NOLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_PHN_NOTextBox)
        Me.Panel1.Controls.Add(PATIENT_DOBLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_DOBDateTimePicker)
        Me.Panel1.Controls.Add(PATIENT_GENDERLabel)
        Me.Panel1.Controls.Add(P_BLOOD_GRPLabel)
        Me.Panel1.Controls.Add(Me.P_BLOOD_GRPTextBox)
        Me.Panel1.Controls.Add(PATIENT_DISEASELabel)
        Me.Panel1.Controls.Add(Me.PATIENT_DISEASETextBox)
        Me.Panel1.Controls.Add(PATIENT_SYMPTOMSLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_SYMPTOMSTextBox)
        Me.Panel1.Controls.Add(PATIENT_ADDRESSLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_ADDRESSTextBox)
        Me.Panel1.Controls.Add(PATIENT_COUNTRYLabel)
        Me.Panel1.Controls.Add(PATIENT_NXTOF_KINSHIPLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_NXTOF_KINSHIPTextBox)
        Me.Panel1.Location = New System.Drawing.Point(61, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 379)
        Me.Panel1.TabIndex = 6
        '
        'PATIENTIDTextBox
        '
        Me.PATIENTIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "PATIENTID", True))
        Me.PATIENTIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENTIDTextBox.Location = New System.Drawing.Point(256, 26)
        Me.PATIENTIDTextBox.Name = "PATIENTIDTextBox"
        Me.PATIENTIDTextBox.Size = New System.Drawing.Size(253, 24)
        Me.PATIENTIDTextBox.TabIndex = 1
        '
        'Patient_detailsBindingSource
        '
        Me.Patient_detailsBindingSource.DataMember = "patient_details"
        Me.Patient_detailsBindingSource.DataSource = Me.Hospital_managementDataSet
        '
        'Hospital_managementDataSet
        '
        Me.Hospital_managementDataSet.DataSetName = "hospital_managementDataSet"
        Me.Hospital_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PATIENT_NHSNoTextBox
        '
        Me.PATIENT_NHSNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "PATIENT_NHSNo", True))
        Me.PATIENT_NHSNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_NHSNoTextBox.Location = New System.Drawing.Point(256, 54)
        Me.PATIENT_NHSNoTextBox.Name = "PATIENT_NHSNoTextBox"
        Me.PATIENT_NHSNoTextBox.Size = New System.Drawing.Size(253, 24)
        Me.PATIENT_NHSNoTextBox.TabIndex = 3
        '
        'PATIENT_NAMETextBox
        '
        Me.PATIENT_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "PATIENT_NAME", True))
        Me.PATIENT_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_NAMETextBox.Location = New System.Drawing.Point(256, 82)
        Me.PATIENT_NAMETextBox.Name = "PATIENT_NAMETextBox"
        Me.PATIENT_NAMETextBox.Size = New System.Drawing.Size(253, 24)
        Me.PATIENT_NAMETextBox.TabIndex = 5
        '
        'PATIENT_PHN_NOTextBox
        '
        Me.PATIENT_PHN_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "PATIENT_PHN_NO", True))
        Me.PATIENT_PHN_NOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_PHN_NOTextBox.Location = New System.Drawing.Point(256, 110)
        Me.PATIENT_PHN_NOTextBox.Name = "PATIENT_PHN_NOTextBox"
        Me.PATIENT_PHN_NOTextBox.Size = New System.Drawing.Size(253, 24)
        Me.PATIENT_PHN_NOTextBox.TabIndex = 7
        '
        'PATIENT_DOBDateTimePicker
        '
        Me.PATIENT_DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Patient_detailsBindingSource, "PATIENT_DOB", True))
        Me.PATIENT_DOBDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_DOBDateTimePicker.Location = New System.Drawing.Point(256, 138)
        Me.PATIENT_DOBDateTimePicker.Name = "PATIENT_DOBDateTimePicker"
        Me.PATIENT_DOBDateTimePicker.Size = New System.Drawing.Size(253, 24)
        Me.PATIENT_DOBDateTimePicker.TabIndex = 9
        '
        'P_BLOOD_GRPTextBox
        '
        Me.P_BLOOD_GRPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "P_BLOOD_GRP", True))
        Me.P_BLOOD_GRPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_BLOOD_GRPTextBox.Location = New System.Drawing.Point(256, 194)
        Me.P_BLOOD_GRPTextBox.Name = "P_BLOOD_GRPTextBox"
        Me.P_BLOOD_GRPTextBox.Size = New System.Drawing.Size(253, 24)
        Me.P_BLOOD_GRPTextBox.TabIndex = 13
        '
        'PATIENT_DISEASETextBox
        '
        Me.PATIENT_DISEASETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "PATIENT_DISEASE", True))
        Me.PATIENT_DISEASETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_DISEASETextBox.Location = New System.Drawing.Point(256, 222)
        Me.PATIENT_DISEASETextBox.Name = "PATIENT_DISEASETextBox"
        Me.PATIENT_DISEASETextBox.Size = New System.Drawing.Size(253, 24)
        Me.PATIENT_DISEASETextBox.TabIndex = 15
        '
        'PATIENT_SYMPTOMSTextBox
        '
        Me.PATIENT_SYMPTOMSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "PATIENT_SYMPTOMS", True))
        Me.PATIENT_SYMPTOMSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_SYMPTOMSTextBox.Location = New System.Drawing.Point(256, 250)
        Me.PATIENT_SYMPTOMSTextBox.Name = "PATIENT_SYMPTOMSTextBox"
        Me.PATIENT_SYMPTOMSTextBox.Size = New System.Drawing.Size(253, 24)
        Me.PATIENT_SYMPTOMSTextBox.TabIndex = 17
        '
        'PATIENT_ADDRESSTextBox
        '
        Me.PATIENT_ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "PATIENT_ADDRESS", True))
        Me.PATIENT_ADDRESSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_ADDRESSTextBox.Location = New System.Drawing.Point(256, 278)
        Me.PATIENT_ADDRESSTextBox.Name = "PATIENT_ADDRESSTextBox"
        Me.PATIENT_ADDRESSTextBox.Size = New System.Drawing.Size(253, 24)
        Me.PATIENT_ADDRESSTextBox.TabIndex = 19
        '
        'PATIENT_NXTOF_KINSHIPTextBox
        '
        Me.PATIENT_NXTOF_KINSHIPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_detailsBindingSource, "PATIENT_NXTOF_KINSHIP", True))
        Me.PATIENT_NXTOF_KINSHIPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_NXTOF_KINSHIPTextBox.Location = New System.Drawing.Point(256, 337)
        Me.PATIENT_NXTOF_KINSHIPTextBox.Name = "PATIENT_NXTOF_KINSHIPTextBox"
        Me.PATIENT_NXTOF_KINSHIPTextBox.Size = New System.Drawing.Size(253, 24)
        Me.PATIENT_NXTOF_KINSHIPTextBox.TabIndex = 23
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
        'lbl_patient
        '
        Me.lbl_patient.AutoSize = True
        Me.lbl_patient.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_patient.ForeColor = System.Drawing.Color.Purple
        Me.lbl_patient.Location = New System.Drawing.Point(607, 37)
        Me.lbl_patient.Name = "lbl_patient"
        Me.lbl_patient.Size = New System.Drawing.Size(294, 32)
        Me.lbl_patient.TabIndex = 8
        Me.lbl_patient.Text = "PATIENTS MODULE"
        '
        'Patient_detailsTableAdapter
        '
        Me.Patient_detailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.doctor_detailsTableAdapter = Nothing
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.patient_detailsTableAdapter = Me.Patient_detailsTableAdapter
        Me.TableAdapterManager.paymentsTableAdapter = Nothing
        Me.TableAdapterManager.pharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        '
        'Patient_detailsBindingNavigator
        '
        Me.Patient_detailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Patient_detailsBindingNavigator.BindingSource = Me.Patient_detailsBindingSource
        Me.Patient_detailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Patient_detailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Patient_detailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Patient_detailsBindingNavigatorSaveItem})
        Me.Patient_detailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Patient_detailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Patient_detailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Patient_detailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Patient_detailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Patient_detailsBindingNavigator.Name = "Patient_detailsBindingNavigator"
        Me.Patient_detailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Patient_detailsBindingNavigator.Size = New System.Drawing.Size(1295, 27)
        Me.Patient_detailsBindingNavigator.TabIndex = 9
        Me.Patient_detailsBindingNavigator.Text = "BindingNavigator1"
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
        'Patient_detailsBindingNavigatorSaveItem
        '
        Me.Patient_detailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patient_detailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Patient_detailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Patient_detailsBindingNavigatorSaveItem.Name = "Patient_detailsBindingNavigatorSaveItem"
        Me.Patient_detailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Patient_detailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Patient_detailsDataGridView
        '
        Me.Patient_detailsDataGridView.AutoGenerateColumns = False
        Me.Patient_detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Patient_detailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Patient_detailsDataGridView.DataSource = Me.Patient_detailsBindingSource
        Me.Patient_detailsDataGridView.Location = New System.Drawing.Point(22, 487)
        Me.Patient_detailsDataGridView.Name = "Patient_detailsDataGridView"
        Me.Patient_detailsDataGridView.RowTemplate.Height = 24
        Me.Patient_detailsDataGridView.Size = New System.Drawing.Size(1249, 214)
        Me.Patient_detailsDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PATIENTID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PATIENTID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PATIENT_NHSNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PATIENT_NHSNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PATIENT_NAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PATIENT_NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PATIENT_PHN_NO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PATIENT_PHN_NO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PATIENT_DOB"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PATIENT_DOB"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PATIENT_GENDER"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PATIENT_GENDER"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "P_BLOOD_GRP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "P_BLOOD_GRP"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PATIENT_DISEASE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PATIENT_DISEASE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PATIENT_SYMPTOMS"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PATIENT_SYMPTOMS"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PATIENT_ADDRESS"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PATIENT_ADDRESS"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PATIENT_COUNTRY"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PATIENT_COUNTRY"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PATIENT_NXTOF_KINSHIP"
        Me.DataGridViewTextBoxColumn12.HeaderText = "PATIENT_NXTOF_KINSHIP"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(257, 167)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 21)
        Me.RadioButton1.TabIndex = 24
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "MALE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(333, 167)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 21)
        Me.RadioButton2.TabIndex = 25
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "FEMALE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(428, 168)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(81, 21)
        Me.RadioButton3.TabIndex = 26
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "TRANS"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"INDIA", "PAKISTAN", "NEPAL", "U.S.A", "U.K", "GERMANY", "FRANCE"})
        Me.ComboBox1.Location = New System.Drawing.Point(256, 308)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(253, 24)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.Text = "SELECT YOUR COUNTRY"
        '
        'frm_patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1295, 826)
        Me.Controls.Add(Me.Patient_detailsDataGridView)
        Me.Controls.Add(Me.Patient_detailsBindingNavigator)
        Me.Controls.Add(Me.lbl_patient)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_patient"
        Me.Text = "patient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Patient_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Patient_detailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Patient_detailsBindingNavigator.ResumeLayout(False)
        Me.Patient_detailsBindingNavigator.PerformLayout()
        CType(Me.Patient_detailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_patient As System.Windows.Forms.Label
    Friend WithEvents Hospital_managementDataSet As hospital_management_system.hospital_managementDataSet
    Friend WithEvents Patient_detailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Patient_detailsTableAdapter As hospital_management_system.hospital_managementDataSetTableAdapters.patient_detailsTableAdapter
    Friend WithEvents TableAdapterManager As hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patient_detailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Patient_detailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PATIENTIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_NHSNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_PHN_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents P_BLOOD_GRPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_DISEASETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_SYMPTOMSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_NXTOF_KINSHIPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_detailsDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
End Class
