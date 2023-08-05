<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_appointment))
        Dim APPOINTMENT_REFLabel As System.Windows.Forms.Label
        Dim PATIENT_NUMBERLabel As System.Windows.Forms.Label
        Dim APPOINTMENT_NOLabel As System.Windows.Forms.Label
        Dim PATIENT_NAMELabel As System.Windows.Forms.Label
        Dim PATIENT_IDLabel As System.Windows.Forms.Label
        Dim MEDICAL_CENTRE_NAMELabel As System.Windows.Forms.Label
        Dim DOC_NHSNoLabel As System.Windows.Forms.Label
        Dim DOC_IDLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_appointment = New System.Windows.Forms.Label()
        Me.Hospital_managementDataSet = New hospital_management_system.hospital_managementDataSet()
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsTableAdapter = New hospital_management_system.hospital_managementDataSetTableAdapters.appointmentsTableAdapter()
        Me.TableAdapterManager = New hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager()
        Me.AppointmentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AppointmentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AppointmentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPOINTMENT_REFTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.APPOINTMENT_NOTextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.PATIENT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.MEDICAL_CENTRE_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.DOC_NHSNoTextBox = New System.Windows.Forms.TextBox()
        Me.DOC_IDTextBox = New System.Windows.Forms.TextBox()
        APPOINTMENT_REFLabel = New System.Windows.Forms.Label()
        PATIENT_NUMBERLabel = New System.Windows.Forms.Label()
        APPOINTMENT_NOLabel = New System.Windows.Forms.Label()
        PATIENT_NAMELabel = New System.Windows.Forms.Label()
        PATIENT_IDLabel = New System.Windows.Forms.Label()
        MEDICAL_CENTRE_NAMELabel = New System.Windows.Forms.Label()
        DOC_NHSNoLabel = New System.Windows.Forms.Label()
        DOC_IDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppointmentsBindingNavigator.SuspendLayout()
        CType(Me.AppointmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(APPOINTMENT_REFLabel)
        Me.Panel1.Controls.Add(Me.APPOINTMENT_REFTextBox)
        Me.Panel1.Controls.Add(PATIENT_NUMBERLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_NUMBERTextBox)
        Me.Panel1.Controls.Add(APPOINTMENT_NOLabel)
        Me.Panel1.Controls.Add(Me.APPOINTMENT_NOTextBox)
        Me.Panel1.Controls.Add(PATIENT_NAMELabel)
        Me.Panel1.Controls.Add(Me.PATIENT_NAMETextBox)
        Me.Panel1.Controls.Add(PATIENT_IDLabel)
        Me.Panel1.Controls.Add(Me.PATIENT_IDTextBox)
        Me.Panel1.Controls.Add(MEDICAL_CENTRE_NAMELabel)
        Me.Panel1.Controls.Add(Me.MEDICAL_CENTRE_NAMETextBox)
        Me.Panel1.Controls.Add(DOC_NHSNoLabel)
        Me.Panel1.Controls.Add(Me.DOC_NHSNoTextBox)
        Me.Panel1.Controls.Add(DOC_IDLabel)
        Me.Panel1.Controls.Add(Me.DOC_IDTextBox)
        Me.Panel1.Location = New System.Drawing.Point(61, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 379)
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
        'lbl_appointment
        '
        Me.lbl_appointment.AutoSize = True
        Me.lbl_appointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_appointment.ForeColor = System.Drawing.Color.Purple
        Me.lbl_appointment.Location = New System.Drawing.Point(607, 37)
        Me.lbl_appointment.Name = "lbl_appointment"
        Me.lbl_appointment.Size = New System.Drawing.Size(382, 32)
        Me.lbl_appointment.TabIndex = 8
        Me.lbl_appointment.Text = "APPOINTMENTS MODULE"
        '
        'Hospital_managementDataSet
        '
        Me.Hospital_managementDataSet.DataSetName = "hospital_managementDataSet"
        Me.Hospital_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "appointments"
        Me.AppointmentsBindingSource.DataSource = Me.Hospital_managementDataSet
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.appointmentsTableAdapter = Me.AppointmentsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.doctor_detailsTableAdapter = Nothing
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.patient_detailsTableAdapter = Nothing
        Me.TableAdapterManager.paymentsTableAdapter = Nothing
        Me.TableAdapterManager.pharmacyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wardsTableAdapter = Nothing
        '
        'AppointmentsBindingNavigator
        '
        Me.AppointmentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AppointmentsBindingNavigator.BindingSource = Me.AppointmentsBindingSource
        Me.AppointmentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AppointmentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AppointmentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AppointmentsBindingNavigatorSaveItem})
        Me.AppointmentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AppointmentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AppointmentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AppointmentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AppointmentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AppointmentsBindingNavigator.Name = "AppointmentsBindingNavigator"
        Me.AppointmentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AppointmentsBindingNavigator.Size = New System.Drawing.Size(1295, 27)
        Me.AppointmentsBindingNavigator.TabIndex = 9
        Me.AppointmentsBindingNavigator.Text = "BindingNavigator1"
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
        'AppointmentsBindingNavigatorSaveItem
        '
        Me.AppointmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AppointmentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("AppointmentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AppointmentsBindingNavigatorSaveItem.Name = "AppointmentsBindingNavigatorSaveItem"
        Me.AppointmentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.AppointmentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AppointmentsDataGridView
        '
        Me.AppointmentsDataGridView.AutoGenerateColumns = False
        Me.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.AppointmentsDataGridView.DataSource = Me.AppointmentsBindingSource
        Me.AppointmentsDataGridView.Location = New System.Drawing.Point(201, 495)
        Me.AppointmentsDataGridView.Name = "AppointmentsDataGridView"
        Me.AppointmentsDataGridView.RowTemplate.Height = 24
        Me.AppointmentsDataGridView.Size = New System.Drawing.Size(850, 220)
        Me.AppointmentsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "APPOINTMENT_REF"
        Me.DataGridViewTextBoxColumn1.HeaderText = "APPOINTMENT_REF"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PATIENT_NUMBER"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PATIENT_NUMBER"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APPOINTMENT_NO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APPOINTMENT_NO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PATIENT_NAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PATIENT_NAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PATIENT_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PATIENT_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MEDICAL_CENTRE_NAME"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MEDICAL_CENTRE_NAME"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DOC_NHSNo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DOC_NHSNo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DOC_ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DOC_ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'APPOINTMENT_REFLabel
        '
        APPOINTMENT_REFLabel.AutoSize = True
        APPOINTMENT_REFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        APPOINTMENT_REFLabel.Location = New System.Drawing.Point(57, 81)
        APPOINTMENT_REFLabel.Name = "APPOINTMENT_REFLabel"
        APPOINTMENT_REFLabel.Size = New System.Drawing.Size(169, 18)
        APPOINTMENT_REFLabel.TabIndex = 0
        APPOINTMENT_REFLabel.Text = "APPOINTMENT REF:"
        '
        'APPOINTMENT_REFTextBox
        '
        Me.APPOINTMENT_REFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "APPOINTMENT_REF", True))
        Me.APPOINTMENT_REFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APPOINTMENT_REFTextBox.Location = New System.Drawing.Point(303, 78)
        Me.APPOINTMENT_REFTextBox.Name = "APPOINTMENT_REFTextBox"
        Me.APPOINTMENT_REFTextBox.Size = New System.Drawing.Size(220, 24)
        Me.APPOINTMENT_REFTextBox.TabIndex = 1
        '
        'PATIENT_NUMBERLabel
        '
        PATIENT_NUMBERLabel.AutoSize = True
        PATIENT_NUMBERLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_NUMBERLabel.Location = New System.Drawing.Point(57, 109)
        PATIENT_NUMBERLabel.Name = "PATIENT_NUMBERLabel"
        PATIENT_NUMBERLabel.Size = New System.Drawing.Size(158, 18)
        PATIENT_NUMBERLabel.TabIndex = 2
        PATIENT_NUMBERLabel.Text = "PATIENT NUMBER:"
        '
        'PATIENT_NUMBERTextBox
        '
        Me.PATIENT_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "PATIENT_NUMBER", True))
        Me.PATIENT_NUMBERTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_NUMBERTextBox.Location = New System.Drawing.Point(303, 106)
        Me.PATIENT_NUMBERTextBox.Name = "PATIENT_NUMBERTextBox"
        Me.PATIENT_NUMBERTextBox.Size = New System.Drawing.Size(220, 24)
        Me.PATIENT_NUMBERTextBox.TabIndex = 3
        '
        'APPOINTMENT_NOLabel
        '
        APPOINTMENT_NOLabel.AutoSize = True
        APPOINTMENT_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        APPOINTMENT_NOLabel.Location = New System.Drawing.Point(57, 137)
        APPOINTMENT_NOLabel.Name = "APPOINTMENT_NOLabel"
        APPOINTMENT_NOLabel.Size = New System.Drawing.Size(161, 18)
        APPOINTMENT_NOLabel.TabIndex = 4
        APPOINTMENT_NOLabel.Text = "APPOINTMENT NO:"
        '
        'APPOINTMENT_NOTextBox
        '
        Me.APPOINTMENT_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "APPOINTMENT_NO", True))
        Me.APPOINTMENT_NOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APPOINTMENT_NOTextBox.Location = New System.Drawing.Point(303, 134)
        Me.APPOINTMENT_NOTextBox.Name = "APPOINTMENT_NOTextBox"
        Me.APPOINTMENT_NOTextBox.Size = New System.Drawing.Size(220, 24)
        Me.APPOINTMENT_NOTextBox.TabIndex = 5
        '
        'PATIENT_NAMELabel
        '
        PATIENT_NAMELabel.AutoSize = True
        PATIENT_NAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_NAMELabel.Location = New System.Drawing.Point(57, 165)
        PATIENT_NAMELabel.Name = "PATIENT_NAMELabel"
        PATIENT_NAMELabel.Size = New System.Drawing.Size(133, 18)
        PATIENT_NAMELabel.TabIndex = 6
        PATIENT_NAMELabel.Text = "PATIENT NAME:"
        '
        'PATIENT_NAMETextBox
        '
        Me.PATIENT_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "PATIENT_NAME", True))
        Me.PATIENT_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_NAMETextBox.Location = New System.Drawing.Point(303, 162)
        Me.PATIENT_NAMETextBox.Name = "PATIENT_NAMETextBox"
        Me.PATIENT_NAMETextBox.Size = New System.Drawing.Size(220, 24)
        Me.PATIENT_NAMETextBox.TabIndex = 7
        '
        'PATIENT_IDLabel
        '
        PATIENT_IDLabel.AutoSize = True
        PATIENT_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PATIENT_IDLabel.Location = New System.Drawing.Point(57, 193)
        PATIENT_IDLabel.Name = "PATIENT_IDLabel"
        PATIENT_IDLabel.Size = New System.Drawing.Size(102, 18)
        PATIENT_IDLabel.TabIndex = 8
        PATIENT_IDLabel.Text = "PATIENT ID:"
        '
        'PATIENT_IDTextBox
        '
        Me.PATIENT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "PATIENT_ID", True))
        Me.PATIENT_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PATIENT_IDTextBox.Location = New System.Drawing.Point(303, 190)
        Me.PATIENT_IDTextBox.Name = "PATIENT_IDTextBox"
        Me.PATIENT_IDTextBox.Size = New System.Drawing.Size(220, 24)
        Me.PATIENT_IDTextBox.TabIndex = 9
        '
        'MEDICAL_CENTRE_NAMELabel
        '
        MEDICAL_CENTRE_NAMELabel.AutoSize = True
        MEDICAL_CENTRE_NAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MEDICAL_CENTRE_NAMELabel.Location = New System.Drawing.Point(57, 221)
        MEDICAL_CENTRE_NAMELabel.Name = "MEDICAL_CENTRE_NAMELabel"
        MEDICAL_CENTRE_NAMELabel.Size = New System.Drawing.Size(210, 18)
        MEDICAL_CENTRE_NAMELabel.TabIndex = 10
        MEDICAL_CENTRE_NAMELabel.Text = "MEDICAL CENTRE NAME:"
        '
        'MEDICAL_CENTRE_NAMETextBox
        '
        Me.MEDICAL_CENTRE_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "MEDICAL_CENTRE_NAME", True))
        Me.MEDICAL_CENTRE_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEDICAL_CENTRE_NAMETextBox.Location = New System.Drawing.Point(303, 220)
        Me.MEDICAL_CENTRE_NAMETextBox.Name = "MEDICAL_CENTRE_NAMETextBox"
        Me.MEDICAL_CENTRE_NAMETextBox.Size = New System.Drawing.Size(220, 24)
        Me.MEDICAL_CENTRE_NAMETextBox.TabIndex = 11
        '
        'DOC_NHSNoLabel
        '
        DOC_NHSNoLabel.AutoSize = True
        DOC_NHSNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_NHSNoLabel.Location = New System.Drawing.Point(57, 249)
        DOC_NHSNoLabel.Name = "DOC_NHSNoLabel"
        DOC_NHSNoLabel.Size = New System.Drawing.Size(112, 18)
        DOC_NHSNoLabel.TabIndex = 12
        DOC_NHSNoLabel.Text = "DOC NHSNo:"
        '
        'DOC_NHSNoTextBox
        '
        Me.DOC_NHSNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "DOC_NHSNo", True))
        Me.DOC_NHSNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_NHSNoTextBox.Location = New System.Drawing.Point(303, 249)
        Me.DOC_NHSNoTextBox.Name = "DOC_NHSNoTextBox"
        Me.DOC_NHSNoTextBox.Size = New System.Drawing.Size(220, 24)
        Me.DOC_NHSNoTextBox.TabIndex = 13
        '
        'DOC_IDLabel
        '
        DOC_IDLabel.AutoSize = True
        DOC_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOC_IDLabel.Location = New System.Drawing.Point(57, 277)
        DOC_IDLabel.Name = "DOC_IDLabel"
        DOC_IDLabel.Size = New System.Drawing.Size(71, 18)
        DOC_IDLabel.TabIndex = 14
        DOC_IDLabel.Text = "DOC ID:"
        '
        'DOC_IDTextBox
        '
        Me.DOC_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "DOC_ID", True))
        Me.DOC_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOC_IDTextBox.Location = New System.Drawing.Point(303, 277)
        Me.DOC_IDTextBox.Name = "DOC_IDTextBox"
        Me.DOC_IDTextBox.Size = New System.Drawing.Size(220, 24)
        Me.DOC_IDTextBox.TabIndex = 15
        '
        'frm_appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1295, 715)
        Me.Controls.Add(Me.AppointmentsDataGridView)
        Me.Controls.Add(Me.AppointmentsBindingNavigator)
        Me.Controls.Add(Me.lbl_appointment)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_appointment"
        Me.Text = "appointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Hospital_managementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppointmentsBindingNavigator.ResumeLayout(False)
        Me.AppointmentsBindingNavigator.PerformLayout()
        CType(Me.AppointmentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_appointment As System.Windows.Forms.Label
    Friend WithEvents Hospital_managementDataSet As hospital_management_system.hospital_managementDataSet
    Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentsTableAdapter As hospital_management_system.hospital_managementDataSetTableAdapters.appointmentsTableAdapter
    Friend WithEvents TableAdapterManager As hospital_management_system.hospital_managementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppointmentsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AppointmentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AppointmentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APPOINTMENT_REFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_NUMBERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APPOINTMENT_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PATIENT_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MEDICAL_CENTRE_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_NHSNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOC_IDTextBox As System.Windows.Forms.TextBox
End Class
