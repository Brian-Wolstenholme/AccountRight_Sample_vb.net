'  Copyright:   Copyright 2013 MYOB Technology Pty Ltd. All rights reserved.
'  Website:     http://www.myob.com
'  Author:      MYOB
'  E-mail:      info@myob.com
'
' Documentation, code and sample applications provided by MYOB Australia are for 
' information purposes only. MYOB Technology Pty Ltd and its suppliers make no 
' warranties, either express or implied, in this document. 
'
' Information in this document or code, including website references, is subject
' to change without notice. Unless otherwise noted, the example companies, 
' organisations, products, domain names, email addresses, people, places, and 
' events are fictitious. 
'
' The entire risk of the use of this documentation or code remains with the user. 
' Complying with all applicable copyright laws is the responsibility of the user. 
'
' Copyright 2013 MYOB Technology Pty Ltd. All rights reserved.

Imports System.Web
Imports System.Net
Imports MYOB.AccountRight.SDK
Imports MYOB.AccountRight.SDK.Services
Imports MYOB.AccountRight.SDK.Contracts
Imports System.Runtime.CompilerServices



Public Class InvoiceForm
    Inherits FormBase

#Region "Designer Code"

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents v As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grdServiceLines As System.Windows.Forms.DataGridView
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents bsServiceInvoice As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RowId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccount As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colJob As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colTax As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents RowVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents textTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents labelTotal As System.Windows.Forms.Label
    Friend WithEvents textTax As System.Windows.Forms.TextBox
    Friend WithEvents labelTax As System.Windows.Forms.Label
    Friend WithEvents textSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents labelSubtotal As System.Windows.Forms.Label
    Friend WithEvents chkTaxInclusive As System.Windows.Forms.CheckBox
    Friend WithEvents lblInvoice As System.Windows.Forms.Label


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkTaxInclusive = New System.Windows.Forms.CheckBox()
        Me.bsServiceInvoice = New System.Windows.Forms.BindingSource(Me.components)
        Me.textTotalAmount = New System.Windows.Forms.TextBox()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.textTax = New System.Windows.Forms.TextBox()
        Me.labelTax = New System.Windows.Forms.Label()
        Me.textSubtotal = New System.Windows.Forms.TextBox()
        Me.labelSubtotal = New System.Windows.Forms.Label()
        Me.grdServiceLines = New System.Windows.Forms.DataGridView()
        Me.RowId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccount = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJob = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colTax = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RowVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.v = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cmboCustomer = New System.Windows.Forms.ComboBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.bsServiceInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdServiceLines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.BackColor = System.Drawing.Color.Transparent
        Me.lblInvoice.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.Location = New System.Drawing.Point(15, 3)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(153, 18)
        Me.lblInvoice.TabIndex = 4
        Me.lblInvoice.Text = "Invoice - Service Layout"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 562)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(10, 25)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(760, 490)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel1.Controls.Add(Me.chkTaxInclusive)
        Me.Panel1.Controls.Add(Me.textTotalAmount)
        Me.Panel1.Controls.Add(Me.labelTotal)
        Me.Panel1.Controls.Add(Me.textTax)
        Me.Panel1.Controls.Add(Me.labelTax)
        Me.Panel1.Controls.Add(Me.textSubtotal)
        Me.Panel1.Controls.Add(Me.labelSubtotal)
        Me.Panel1.Controls.Add(Me.grdServiceLines)
        Me.Panel1.Controls.Add(Me.dtDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtInvoiceNo)
        Me.Panel1.Controls.Add(Me.v)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.cmboCustomer)
        Me.Panel1.Controls.Add(Me.lblCustomer)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(14, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 480)
        Me.Panel1.TabIndex = 6
        '
        'chkTaxInclusive
        '
        Me.chkTaxInclusive.AutoSize = True
        Me.chkTaxInclusive.Checked = True
        Me.chkTaxInclusive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTaxInclusive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsServiceInvoice, "IsTaxInclusive", True))
        Me.chkTaxInclusive.Location = New System.Drawing.Point(550, 9)
        Me.chkTaxInclusive.Name = "chkTaxInclusive"
        Me.chkTaxInclusive.Size = New System.Drawing.Size(89, 17)
        Me.chkTaxInclusive.TabIndex = 16
        Me.chkTaxInclusive.Text = "Tax Inclusive"
        Me.chkTaxInclusive.UseVisualStyleBackColor = True
        '
        'bsServiceInvoice
        '
        Me.bsServiceInvoice.DataSource = GetType(MYOB.AccountRight.SDK.Contracts.Version2.Sale.ServiceInvoice)
        '
        'textTotalAmount
        '
        Me.textTotalAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsServiceInvoice, "TotalAmount", True))
        Me.textTotalAmount.Enabled = False
        Me.textTotalAmount.Location = New System.Drawing.Point(550, 432)
        Me.textTotalAmount.Name = "textTotalAmount"
        Me.textTotalAmount.Size = New System.Drawing.Size(130, 20)
        Me.textTotalAmount.TabIndex = 15
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.BackColor = System.Drawing.Color.Transparent
        Me.labelTotal.Location = New System.Drawing.Point(471, 435)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(73, 13)
        Me.labelTotal.TabIndex = 14
        Me.labelTotal.Text = "Total Amount:"
        Me.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textTax
        '
        Me.textTax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsServiceInvoice, "TotalTax", True))
        Me.textTax.Enabled = False
        Me.textTax.Location = New System.Drawing.Point(550, 406)
        Me.textTax.Name = "textTax"
        Me.textTax.Size = New System.Drawing.Size(130, 20)
        Me.textTax.TabIndex = 13
        '
        'labelTax
        '
        Me.labelTax.AutoSize = True
        Me.labelTax.BackColor = System.Drawing.Color.Transparent
        Me.labelTax.Location = New System.Drawing.Point(516, 409)
        Me.labelTax.Name = "labelTax"
        Me.labelTax.Size = New System.Drawing.Size(28, 13)
        Me.labelTax.TabIndex = 12
        Me.labelTax.Text = "Tax:"
        Me.labelTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textSubtotal
        '
        Me.textSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsServiceInvoice, "Subtotal", True))
        Me.textSubtotal.Enabled = False
        Me.textSubtotal.Location = New System.Drawing.Point(550, 380)
        Me.textSubtotal.Name = "textSubtotal"
        Me.textSubtotal.Size = New System.Drawing.Size(130, 20)
        Me.textSubtotal.TabIndex = 11
        '
        'labelSubtotal
        '
        Me.labelSubtotal.AutoSize = True
        Me.labelSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.labelSubtotal.Location = New System.Drawing.Point(495, 383)
        Me.labelSubtotal.Name = "labelSubtotal"
        Me.labelSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.labelSubtotal.TabIndex = 10
        Me.labelSubtotal.Text = "Subtotal:"
        Me.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdServiceLines
        '
        Me.grdServiceLines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdServiceLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdServiceLines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RowId, Me.colDescription, Me.colAccount, Me.colAmount, Me.colJob, Me.colTax, Me.RowVersion})
        Me.grdServiceLines.Location = New System.Drawing.Point(19, 149)
        Me.grdServiceLines.Name = "grdServiceLines"
        Me.grdServiceLines.Size = New System.Drawing.Size(713, 208)
        Me.grdServiceLines.TabIndex = 9
        '
        'RowId
        '
        Me.RowId.DataPropertyName = "RowId"
        Me.RowId.HeaderText = "RowId"
        Me.RowId.Name = "RowId"
        Me.RowId.Visible = False
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "Description"
        Me.colDescription.FillWeight = 200.0!
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Width = 200
        '
        'colAccount
        '
        Me.colAccount.DataPropertyName = "AccountUID"
        Me.colAccount.HeaderText = "Account"
        Me.colAccount.Name = "colAccount"
        Me.colAccount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colAccount.Width = 150
        '
        'colAmount
        '
        Me.colAmount.DataPropertyName = "Total"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle1
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        '
        'colJob
        '
        Me.colJob.DataPropertyName = "JobUID"
        Me.colJob.HeaderText = "Job"
        Me.colJob.Name = "colJob"
        Me.colJob.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colJob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colTax
        '
        Me.colTax.DataPropertyName = "TaxUID"
        Me.colTax.HeaderText = "Tax"
        Me.colTax.Name = "colTax"
        Me.colTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RowVersion
        '
        Me.RowVersion.DataPropertyName = "RowVersion"
        Me.RowVersion.HeaderText = "RowVersion"
        Me.RowVersion.Name = "RowVersion"
        Me.RowVersion.Visible = False
        '
        'dtDate
        '
        Me.dtDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsServiceInvoice, "Date", True))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(550, 84)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(130, 20)
        Me.dtDate.TabIndex = 8
        Me.dtDate.Value = New Date(2013, 8, 9, 23, 56, 56, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(511, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsServiceInvoice, "Number", True))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(550, 54)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(130, 20)
        Me.txtInvoiceNo.TabIndex = 6
        '
        'v
        '
        Me.v.AutoSize = True
        Me.v.BackColor = System.Drawing.Color.White
        Me.v.Location = New System.Drawing.Point(482, 57)
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(62, 13)
        Me.v.TabIndex = 5
        Me.v.Text = "Invoice No:"
        Me.v.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(133, 57)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsServiceInvoice, "ShipToAddress", True))
        Me.txtAddress.Location = New System.Drawing.Point(188, 54)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(249, 89)
        Me.txtAddress.TabIndex = 3
        '
        'cmboCustomer
        '
        Me.cmboCustomer.DisplayMember = "UID"
        Me.cmboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboCustomer.FormattingEnabled = True
        Me.cmboCustomer.Location = New System.Drawing.Point(184, 6)
        Me.cmboCustomer.Name = "cmboCustomer"
        Me.cmboCustomer.Size = New System.Drawing.Size(254, 21)
        Me.cmboCustomer.TabIndex = 1
        Me.cmboCustomer.ValueMember = "UID"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(127, 9)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(752, 480)
        Me.ShapeContainer2.TabIndex = 2
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape2.BackColor = System.Drawing.Color.White
        Me.RectangleShape2.FillColor = System.Drawing.Color.White
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(8, 40)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(735, 326)
        '
        'btnRecord
        '
        Me.btnRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecord.Location = New System.Drawing.Point(616, 527)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnRecord.TabIndex = 7
        Me.btnRecord.Text = "Record"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn1.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Total"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RowVersion"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "RowVersion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RowVersion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RowVersion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblInvoice)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "InvoiceForm"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.lblInvoice, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.btnRecord, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bsServiceInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdServiceLines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub
#End Region

    ' This delegate enables asynchronous calls to return to UI thread
    Delegate Sub SetCustomersCallback(customers As Version2.PagedCollection(Of Version2.Contact.Customer))
    Delegate Sub SetAccountsCallback(customers As Version2.PagedCollection(Of Version2.GeneralLedger.Account))
    Delegate Sub SetJobsCallback(customers As Version2.PagedCollection(Of Version2.GeneralLedger.Job))
    Delegate Sub SetTaxCodesCallback(customers As Version2.PagedCollection(Of Version2.GeneralLedger.TaxCode))
    Delegate Sub SetSaveCallback(newURI As String)

    Private _Invoice As Version2.Sale.Invoice
    Private _PrereqCount As Integer = 0

    Private Sub InvoiceForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        chkTaxInclusive.Checked = True
        dtDate.Value = Date.Now

        LoadCustomers()
        LoadAccounts()
        LoadJobs()
        LoadTaxCodes()
        ShowSpinner()
    End Sub


    Public Overloads Sub Show(invoice As Version2.Sale.Invoice)
        _Invoice = invoice

        MyBase.Show()
    End Sub

    Private Sub DoBind()
        _PrereqCount += 1
        If _PrereqCount = 4 Then
            BindInvoice()
            HideSpinner()
        End If
    End Sub

    Private Sub BindInvoice()

        If Not IsNothing(_Invoice) Then
            Dim serviceInvoiceSvc = New Sale.ServiceInvoiceService(myConfiguration, Nothing, myOAuthKeyService)
            Dim serviceInvoice = serviceInvoiceSvc.Get(myCompanyFile, _Invoice.UID, myCredentials)

            'Set the default value
            Dim customer As Version2.Contact.Customer
            Dim customers = cmboCustomer.DataSource
            For i = 0 To customers.Length
                customer = customers(i)
                If customer.UID = serviceInvoice.Customer.UID Then
                    cmboCustomer.SelectedIndex = i
                    Exit For
                End If
            Next

            bsServiceInvoice.DataSource = serviceInvoice
            grdServiceLines.DataSource = FlattenLines(serviceInvoice.Lines.ToArray())

        End If
    End Sub


#Region "Customer List"

    Private Sub LoadCustomers()
        Dim customerSvc = New Contact.CustomerService(myConfiguration, Nothing, myOAuthKeyService)
        customerSvc.GetRange(myCompanyFile, Nothing, myCredentials, AddressOf OnCustomerComplete, AddressOf OnError)
    End Sub

    ''' <summary>
    ''' Method called on Async complete
    ''' </summary>
    ''' <param name="statusCode"></param>
    ''' <param name="customers"></param>
    ''' <remarks></remarks>
    Private Sub OnCustomerComplete(statusCode As System.Net.HttpStatusCode, customers As Version2.PagedCollection(Of Version2.Contact.Customer))
        'Invoke the SetDataSource method on the UI thread
        Dim d As New SetCustomersCallback(AddressOf SetCustomerDataSource)
        Me.Invoke(d, New Object() {customers})
    End Sub

    ''' <summary>
    ''' Method to set the datasource
    ''' </summary>
    ''' <param name="customers">Pages collection of invoices</param>
    ''' <remarks></remarks>
    Private Sub SetCustomerDataSource(customers As Version2.PagedCollection(Of Version2.Contact.Customer))
        'Fill the dropdown
        cmboCustomer.DataSource = customers.Items
        DoBind()

    End Sub



    ''' <summary>
    ''' Formats the display of the items in combobox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmboCustomer_Format(sender As Object, e As ListControlConvertEventArgs) Handles cmboCustomer.Format
        Dim customer As Version2.Contact.Customer = e.ListItem

        If customer.IsIndividual Then
            e.Value = customer.DisplayID + ": " + customer.FirstName + " " + customer.LastName
        Else
            e.Value = customer.DisplayID + ": " + customer.CompanyName
        End If
    End Sub

    Private Sub cmboCustomer_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmboCustomer.SelectedIndexChanged
        If Not cmboCustomer.SelectedItem Is Nothing Then
            Dim customer As Version2.Contact.Customer = cmboCustomer.SelectedItem
            txtAddress.Text = customer.Addresses(0).Street + vbCrLf + customer.Addresses(0).City + vbCrLf + customer.Addresses(0).PostCode
        Else
            txtAddress.Text = ""
        End If
    End Sub

#End Region

#Region "Account List"


    ''' <summary>
    ''' Call API to return a list of Income Accounts only
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadAccounts()
        Dim accountSvc = New GeneralLedger.AccountService(myConfiguration, Nothing, myOAuthKeyService)
        accountSvc.GetRange(myCompanyFile, "$filter=Classification eq 'Income' and IsHeader eq false", myCredentials, AddressOf OnAccountComplete, AddressOf OnError)
    End Sub

    ''' <summary>
    ''' Method called on Async complete
    ''' </summary>
    ''' <param name="statusCode"></param>
    ''' <param name="accounts"></param>
    ''' <remarks></remarks>
    Private Sub OnAccountComplete(statusCode As System.Net.HttpStatusCode, accounts As Version2.PagedCollection(Of Version2.GeneralLedger.Account))
        'Invoke the SetDataSource method on the UI thread
        Dim d As New SetAccountsCallback(AddressOf SetAccountDataSource)
        Me.Invoke(d, New Object() {accounts})
    End Sub

    ''' <summary>
    ''' Method to set the datasource
    ''' </summary>
    ''' <param name="accounts">Pages collection of invoices</param>
    ''' <remarks></remarks>
    Private Sub SetAccountDataSource(accounts As Version2.PagedCollection(Of Version2.GeneralLedger.Account))
        'Fill the dropdown
        colAccount.DataSource = accounts.Items
        colAccount.DisplayMember = "Name"
        colAccount.ValueMember = "UID"
        colAccount.ValueType = GetType(Guid)
        DoBind()
    End Sub

#End Region

#Region "Job List"

    Private Sub LoadJobs()
        Dim jobSvc = New GeneralLedger.JobService(myConfiguration, Nothing, myOAuthKeyService)
        jobSvc.GetRange(myCompanyFile, "$filter=IsHeader eq false", myCredentials, AddressOf OnJobComplete, AddressOf OnError)
    End Sub

    ''' <summary>
    ''' Method called on Async complete
    ''' </summary>
    ''' <param name="statusCode"></param>
    ''' <param name="jobs"></param>
    ''' <remarks></remarks>
    Private Sub OnJobComplete(statusCode As System.Net.HttpStatusCode, jobs As Version2.PagedCollection(Of Version2.GeneralLedger.Job))
        'Invoke the SetDataSource method on the UI thread
        Dim d As New SetJobsCallback(AddressOf SetJobDataSource)
        Me.Invoke(d, New Object() {jobs})
    End Sub

    ''' <summary>
    ''' Method to set the datasource
    ''' </summary>
    ''' <param name="jobs">Pages collection of invoices</param>
    ''' <remarks></remarks>
    Private Sub SetJobDataSource(jobs As Version2.PagedCollection(Of Version2.GeneralLedger.Job))
        'Fill the dropdown
        colJob.DataSource = jobs.Items
        colJob.DisplayMember = "Name"
        colJob.ValueMember = "UID"
        colJob.ValueType = GetType(Guid)

        DoBind()
    End Sub



#End Region

#Region "TaxCode List"

    Private Sub LoadTaxCodes()
        Dim taxCodeSvc = New GeneralLedger.TaxCodeService(myConfiguration, Nothing, myOAuthKeyService)
        taxCodeSvc.GetRange(myCompanyFile, Nothing, myCredentials, AddressOf OnTaxCodeComplete, AddressOf OnError)
    End Sub

    ''' <summary>
    ''' Method called on Async complete
    ''' </summary>
    ''' <param name="statusCode"></param>
    ''' <param name="taxCodes"></param>
    ''' <remarks></remarks>
    Private Sub OnTaxCodeComplete(statusCode As System.Net.HttpStatusCode, taxCodes As Version2.PagedCollection(Of Version2.GeneralLedger.TaxCode))
        'Invoke the SetDataSource method on the UI thread
        Dim d As New SetTaxCodesCallback(AddressOf SetTaxCodesDataSource)
        Me.Invoke(d, New Object() {taxCodes})
    End Sub

    ''' <summary>
    ''' Method to set the datasource
    ''' </summary>
    ''' <param name="taxCodes">Pages collection of invoices</param>
    ''' <remarks></remarks>
    Private Sub SetTaxCodesDataSource(taxCodes As Version2.PagedCollection(Of Version2.GeneralLedger.TaxCode))
        'Fill the dropdown
        colTax.DataSource = taxCodes.Items
        colTax.DisplayMember = "Code"
        colTax.ValueMember = "UID"
        colJob.ValueType = GetType(Guid)

        DoBind()
    End Sub



#End Region


    Private Sub btnRecord_Click(sender As System.Object, e As System.EventArgs) Handles btnRecord.Click
        Dim serviceInvoiceSvc = New Sale.ServiceInvoiceService(myConfiguration, Nothing, myOAuthKeyService)
        Dim serviceInvoice = New Version2.Sale.ServiceInvoice()

        If IsNothing(_Invoice) Then
            Dim customerLnk = New Version2.Contact.CustomerLink()
            customerLnk.UID = cmboCustomer.SelectedValue
            serviceInvoice.Customer = customerLnk
            serviceInvoice.ShipToAddress = txtAddress.Text
            serviceInvoice.Number = txtInvoiceNo.Text
            serviceInvoice.Date = dtDate.Value
            serviceInvoice.IsTaxInclusive = chkTaxInclusive.Checked

            Dim Lines = New List(Of Version2.Sale.ServiceInvoiceLine)
            For Each row As DataGridViewRow In grdServiceLines.Rows

                If Not row.IsNewRow Then

                    Dim line = New Version2.Sale.ServiceInvoiceLine
                    line.Type = "Transaction"
                    line.Description = row.Cells("colDescription").Value
                    line.Total = row.Cells("colAmount").Value

                    If IsNothing(row.Cells("colAccount").Value) Then
                        MessageBox.Show("you must select an account on each row")
                        Exit Sub
                    Else
                        Dim accountlnk = New Version2.GeneralLedger.AccountLink
                        accountlnk.UID = row.Cells("colAccount").Value
                        line.Account = accountlnk
                    End If

                    If IsNothing(row.Cells("colTax").Value) Then
                        MessageBox.Show("you must select a taxcode on each row")
                        Exit Sub
                    Else
                        Dim taxcodelnk = New Version2.GeneralLedger.TaxCodeLink
                        taxcodelnk.UID = row.Cells("colTax").Value
                        line.TaxCode = taxcodelnk
                    End If

                    If Not IsNothing(row.Cells("colJob").Value) Then
                        Dim joblnk = New Version2.GeneralLedger.JobLink
                        joblnk.UID = row.Cells("colJob").Value
                        line.Job = joblnk
                    End If

                    Lines.Add(line)

                End If
            Next


            serviceInvoice.Lines = Lines
            serviceInvoiceSvc.Insert(myCompanyFile, serviceInvoice, myCredentials, AddressOf onSaveComplete, AddressOf OnError)
            ShowSpinner()

        End If

    End Sub

    ''' <summary>
    ''' Method called on Async complete
    ''' </summary>
    ''' <param name="statusCode"></param>
    ''' <param name="newURI"></param>
    ''' <remarks></remarks>
    Private Sub onSaveComplete(statusCode As System.Net.HttpStatusCode, newURI As String)
        'Invoke the SetDataSource method on the UI thread
        Dim d As New SetSaveCallback(AddressOf SaveCallback)
        Me.Invoke(d, New Object() {newURI})
    End Sub

    Private Sub SaveCallback(newURI As String)
        MessageBox.Show("Saved: " + vbCrLf + newURI)
        HideSpinner()

        If Not IsNothing(Me.Owner) Then
            CType(Me.Owner, InvoiceListForm).RefreshData()
        End If
        Me.Close()
    End Sub

    Private Function FlattenLines(serviceInvoiceLines() As Version2.Sale.ServiceInvoiceLine) As flatServiceinvoiceLine()
        Dim flattenedLines = New List(Of flatServiceinvoiceLine)

        For Each line In serviceInvoiceLines
            Dim flatLine = New flatServiceinvoiceLine
            flatLine.RowId = line.RowID
            flatLine.Description = line.Description
            flatLine.AccountUID = line.Account.UID
            flatLine.Total = line.Total
            If Not IsNothing(line.Job) Then
                flatLine.JobUID = line.Job.UID
            End If
            flatLine.TaxUID = line.TaxCode.UID
            flatLine.RowVersion = line.RowVersion
            flattenedLines.Add(flatLine)
        Next

        Return flattenedLines.ToArray
    End Function

    Private Structure flatServiceinvoiceLine
        Public Property RowId As Integer
        Public Property Description As String
        Public Property AccountUID As Guid
        Public Property Total As String
        Public Property JobUID As Guid
        Public Property TaxUID As Guid
        Public Property RowVersion As String
    End Structure

    Private Sub grdServiceLines_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdServiceLines.DataError
        If (TypeOf (e.Exception) Is ArgumentException) Then
            'ignore error for binding
            e.ThrowException = False
        Else
            e.ThrowException = True
        End If
    End Sub
End Class

