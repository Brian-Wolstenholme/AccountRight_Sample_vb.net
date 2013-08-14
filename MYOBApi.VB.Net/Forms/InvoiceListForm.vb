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

Public Class InvoiceListForm
    Inherits FormBase

#Region "Designer code"
    Friend WithEvents tabOpen As System.Windows.Forms.TabPage
    Friend WithEvents tabAll As System.Windows.Forms.TabPage
    Friend WithEvents gridAllInvoices As System.Windows.Forms.DataGridView
    Friend WithEvents tabClosed As System.Windows.Forms.TabPage
    Friend WithEvents tabCredit As System.Windows.Forms.TabPage
    Friend WithEvents gridOpenInvoices As System.Windows.Forms.DataGridView
    Friend WithEvents gridCreditInvoices As System.Windows.Forms.DataGridView
    Friend WithEvents gridClosedInvoices As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As MYOBApi.VB.Net.DataGridViewCardLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As MYOBApi.VB.Net.DataGridViewCardLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As MYOBApi.VB.Net.DataGridViewCardLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPageRight As System.Windows.Forms.Button
    Friend WithEvents textPage As System.Windows.Forms.TextBox
    Friend WithEvents btnPageLeft As System.Windows.Forms.Button
    Friend WithEvents InvoiceType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPurchaseOrderNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Customer As MYOBApi.VB.Net.DataGridViewCardLinkColumn
    Friend WithEvents PromisedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDueAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents URI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RowVersion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl




    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.gridAllInvoices = New System.Windows.Forms.DataGridView()
        Me.tabOpen = New System.Windows.Forms.TabPage()
        Me.gridOpenInvoices = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New MYOBApi.VB.Net.DataGridViewCardLinkColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabCredit = New System.Windows.Forms.TabPage()
        Me.gridCreditInvoices = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New MYOBApi.VB.Net.DataGridViewCardLinkColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabClosed = New System.Windows.Forms.TabPage()
        Me.gridClosedInvoices = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New MYOBApi.VB.Net.DataGridViewCardLinkColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPageRight = New System.Windows.Forms.Button()
        Me.textPage = New System.Windows.Forms.TextBox()
        Me.btnPageLeft = New System.Windows.Forms.Button()
        Me.InvoiceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPurchaseOrderNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer = New MYOBApi.VB.Net.DataGridViewCardLinkColumn()
        Me.PromisedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDueAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.URI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RowVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tabAll.SuspendLayout()
        CType(Me.gridAllInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOpen.SuspendLayout()
        CType(Me.gridOpenInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCredit.SuspendLayout()
        CType(Me.gridCreditInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClosed.SuspendLayout()
        CType(Me.gridClosedInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabAll)
        Me.TabControl1.Controls.Add(Me.tabOpen)
        Me.TabControl1.Controls.Add(Me.tabCredit)
        Me.TabControl1.Controls.Add(Me.tabClosed)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 509)
        Me.TabControl1.TabIndex = 0
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.gridAllInvoices)
        Me.tabAll.Location = New System.Drawing.Point(4, 22)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAll.Size = New System.Drawing.Size(752, 483)
        Me.tabAll.TabIndex = 0
        Me.tabAll.Text = "All Invoices"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'gridAllInvoices
        '
        Me.gridAllInvoices.AllowUserToAddRows = False
        Me.gridAllInvoices.AllowUserToDeleteRows = False
        Me.gridAllInvoices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridAllInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridAllInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAllInvoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceType, Me.Number, Me.InvoiceDate, Me.CustomerPurchaseOrderNumber, Me.Customer, Me.PromisedDate, Me.BalanceDueAmount, Me.Status, Me.UID, Me.URI, Me.RowVersion})
        Me.gridAllInvoices.Location = New System.Drawing.Point(3, 3)
        Me.gridAllInvoices.Name = "gridAllInvoices"
        Me.gridAllInvoices.Size = New System.Drawing.Size(746, 477)
        Me.gridAllInvoices.TabIndex = 0
        '
        'tabOpen
        '
        Me.tabOpen.Controls.Add(Me.gridOpenInvoices)
        Me.tabOpen.Location = New System.Drawing.Point(4, 22)
        Me.tabOpen.Name = "tabOpen"
        Me.tabOpen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOpen.Size = New System.Drawing.Size(752, 483)
        Me.tabOpen.TabIndex = 1
        Me.tabOpen.Text = "Open Invoices"
        Me.tabOpen.UseVisualStyleBackColor = True
        '
        'gridOpenInvoices
        '
        Me.gridOpenInvoices.AllowUserToAddRows = False
        Me.gridOpenInvoices.AllowUserToDeleteRows = False
        Me.gridOpenInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridOpenInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOpenInvoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.gridOpenInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridOpenInvoices.Location = New System.Drawing.Point(3, 3)
        Me.gridOpenInvoices.Name = "gridOpenInvoices"
        Me.gridOpenInvoices.Size = New System.Drawing.Size(746, 477)
        Me.gridOpenInvoices.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InvoiceType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 56
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 55
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CustomerPurchaseOrderNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CustomerPurchaseOrderNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 184
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Customer"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.Width = 76
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PromisedDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Promised Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 101
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "BalanceDueAmount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.HeaderText = "Balance Due"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 94
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Status"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 62
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 51
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "URI"
        Me.DataGridViewTextBoxColumn10.HeaderText = "URI"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 51
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "RowVersion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "RowVersion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 89
        '
        'tabCredit
        '
        Me.tabCredit.Controls.Add(Me.gridCreditInvoices)
        Me.tabCredit.Location = New System.Drawing.Point(4, 22)
        Me.tabCredit.Name = "tabCredit"
        Me.tabCredit.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCredit.Size = New System.Drawing.Size(752, 483)
        Me.tabCredit.TabIndex = 3
        Me.tabCredit.Text = "Returns & Credits"
        Me.tabCredit.UseVisualStyleBackColor = True
        '
        'gridCreditInvoices
        '
        Me.gridCreditInvoices.AllowUserToAddRows = False
        Me.gridCreditInvoices.AllowUserToDeleteRows = False
        Me.gridCreditInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridCreditInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCreditInvoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.gridCreditInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCreditInvoices.Location = New System.Drawing.Point(3, 3)
        Me.gridCreditInvoices.Name = "gridCreditInvoices"
        Me.gridCreditInvoices.Size = New System.Drawing.Size(746, 477)
        Me.gridCreditInvoices.TabIndex = 2
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "InvoiceType"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 56
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Number"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Number"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 69
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Date"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn14.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 55
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CustomerPurchaseOrderNumber"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CustomerPurchaseOrderNumber"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 184
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Customer"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn16.Width = 76
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PromisedDate"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Promised Date"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 101
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "BalanceDueAmount"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn18.HeaderText = "Balance Due"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 94
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Status"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn19.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 62
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "UID"
        Me.DataGridViewTextBoxColumn20.HeaderText = "UID"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 51
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "URI"
        Me.DataGridViewTextBoxColumn21.HeaderText = "URI"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 51
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "RowVersion"
        Me.DataGridViewTextBoxColumn22.HeaderText = "RowVersion"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Visible = False
        Me.DataGridViewTextBoxColumn22.Width = 89
        '
        'tabClosed
        '
        Me.tabClosed.Controls.Add(Me.gridClosedInvoices)
        Me.tabClosed.Location = New System.Drawing.Point(4, 22)
        Me.tabClosed.Name = "tabClosed"
        Me.tabClosed.Size = New System.Drawing.Size(752, 483)
        Me.tabClosed.TabIndex = 2
        Me.tabClosed.Text = "Closed Invoices"
        Me.tabClosed.UseVisualStyleBackColor = True
        '
        'gridClosedInvoices
        '
        Me.gridClosedInvoices.AllowUserToAddRows = False
        Me.gridClosedInvoices.AllowUserToDeleteRows = False
        Me.gridClosedInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridClosedInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClosedInvoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
        Me.gridClosedInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridClosedInvoices.Location = New System.Drawing.Point(0, 0)
        Me.gridClosedInvoices.Name = "gridClosedInvoices"
        Me.gridClosedInvoices.Size = New System.Drawing.Size(752, 483)
        Me.gridClosedInvoices.TabIndex = 3
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "InvoiceType"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 56
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Number"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Number"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 69
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Date"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn25.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 55
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CustomerPurchaseOrderNumber"
        Me.DataGridViewTextBoxColumn26.HeaderText = "CustomerPurchaseOrderNumber"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Visible = False
        Me.DataGridViewTextBoxColumn26.Width = 184
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Customer"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn27.Width = 76
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "PromisedDate"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Promised Date"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        Me.DataGridViewTextBoxColumn28.Width = 101
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "BalanceDueAmount"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn29.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn29.HeaderText = "Balance Due"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 94
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Status"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn30.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn30.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 62
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "UID"
        Me.DataGridViewTextBoxColumn31.HeaderText = "UID"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Visible = False
        Me.DataGridViewTextBoxColumn31.Width = 51
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "URI"
        Me.DataGridViewTextBoxColumn32.HeaderText = "URI"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Visible = False
        Me.DataGridViewTextBoxColumn32.Width = 51
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "RowVersion"
        Me.DataGridViewTextBoxColumn33.HeaderText = "RowVersion"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Visible = False
        Me.DataGridViewTextBoxColumn33.Width = 89
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Location = New System.Drawing.Point(616, 527)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnPageRight)
        Me.Panel1.Controls.Add(Me.textPage)
        Me.Panel1.Controls.Add(Me.btnPageLeft)
        Me.Panel1.Location = New System.Drawing.Point(16, 528)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 22)
        Me.Panel1.TabIndex = 4
        '
        'btnPageRight
        '
        Me.btnPageRight.Location = New System.Drawing.Point(115, 0)
        Me.btnPageRight.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPageRight.Name = "btnPageRight"
        Me.btnPageRight.Size = New System.Drawing.Size(30, 20)
        Me.btnPageRight.TabIndex = 2
        Me.btnPageRight.Text = ">"
        Me.btnPageRight.UseVisualStyleBackColor = True
        '
        'textPage
        '
        Me.textPage.BackColor = System.Drawing.Color.White
        Me.textPage.Location = New System.Drawing.Point(31, 0)
        Me.textPage.Name = "textPage"
        Me.textPage.ReadOnly = True
        Me.textPage.Size = New System.Drawing.Size(84, 20)
        Me.textPage.TabIndex = 1
        Me.textPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPageLeft
        '
        Me.btnPageLeft.Location = New System.Drawing.Point(0, 0)
        Me.btnPageLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPageLeft.Name = "btnPageLeft"
        Me.btnPageLeft.Size = New System.Drawing.Size(30, 20)
        Me.btnPageLeft.TabIndex = 0
        Me.btnPageLeft.Text = "<"
        Me.btnPageLeft.UseVisualStyleBackColor = True
        '
        'InvoiceType
        '
        Me.InvoiceType.DataPropertyName = "InvoiceType"
        Me.InvoiceType.HeaderText = "Type"
        Me.InvoiceType.Name = "InvoiceType"
        Me.InvoiceType.Width = 56
        '
        'Number
        '
        Me.Number.DataPropertyName = "Number"
        Me.Number.HeaderText = "Number"
        Me.Number.Name = "Number"
        Me.Number.Width = 69
        '
        'InvoiceDate
        '
        Me.InvoiceDate.DataPropertyName = "Date"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.InvoiceDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.InvoiceDate.HeaderText = "Date"
        Me.InvoiceDate.Name = "InvoiceDate"
        Me.InvoiceDate.Width = 55
        '
        'CustomerPurchaseOrderNumber
        '
        Me.CustomerPurchaseOrderNumber.DataPropertyName = "CustomerPurchaseOrderNumber"
        Me.CustomerPurchaseOrderNumber.HeaderText = "CustomerPurchaseOrderNumber"
        Me.CustomerPurchaseOrderNumber.Name = "CustomerPurchaseOrderNumber"
        Me.CustomerPurchaseOrderNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CustomerPurchaseOrderNumber.Visible = False
        Me.CustomerPurchaseOrderNumber.Width = 165
        '
        'Customer
        '
        Me.Customer.DataPropertyName = "Customer"
        Me.Customer.HeaderText = "Customer"
        Me.Customer.Name = "Customer"
        Me.Customer.ReadOnly = True
        Me.Customer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Customer.Width = 76
        '
        'PromisedDate
        '
        Me.PromisedDate.DataPropertyName = "PromisedDate"
        Me.PromisedDate.HeaderText = "Promised Date"
        Me.PromisedDate.Name = "PromisedDate"
        Me.PromisedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PromisedDate.Visible = False
        Me.PromisedDate.Width = 82
        '
        'BalanceDueAmount
        '
        Me.BalanceDueAmount.DataPropertyName = "BalanceDueAmount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.BalanceDueAmount.DefaultCellStyle = DataGridViewCellStyle2
        Me.BalanceDueAmount.HeaderText = "Balance Due"
        Me.BalanceDueAmount.Name = "BalanceDueAmount"
        Me.BalanceDueAmount.Width = 94
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Status.DefaultCellStyle = DataGridViewCellStyle3
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 62
        '
        'UID
        '
        Me.UID.DataPropertyName = "UID"
        Me.UID.HeaderText = "UID"
        Me.UID.Name = "UID"
        Me.UID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UID.Visible = False
        Me.UID.Width = 32
        '
        'URI
        '
        Me.URI.DataPropertyName = "URI"
        Me.URI.HeaderText = "URI"
        Me.URI.Name = "URI"
        Me.URI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.URI.Visible = False
        Me.URI.Width = 32
        '
        'RowVersion
        '
        Me.RowVersion.DataPropertyName = "RowVersion"
        Me.RowVersion.HeaderText = "RowVersion"
        Me.RowVersion.Name = "RowVersion"
        Me.RowVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RowVersion.Visible = False
        Me.RowVersion.Width = 70
        '
        'InvoiceListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "InvoiceListForm"
        Me.Text = "Invoice List"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.tabAll.ResumeLayout(False)
        CType(Me.gridAllInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOpen.ResumeLayout(False)
        CType(Me.gridOpenInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCredit.ResumeLayout(False)
        CType(Me.gridCreditInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClosed.ResumeLayout(False)
        CType(Me.gridClosedInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub
#End Region

    ' This delegate enables asynchronous calls to return to UI thread
    Delegate Sub SetDataSourceCallback(invoices As Version2.PagedCollection(Of Version2.Sale.Invoice))

    Private PageSize As Integer = 500
    Private CurrentPage As Integer = 1
    Private TotalPages As Integer = 0

    ''' <summary>
    ''' On Form load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub InvoiceListForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub

    ''' <summary>
    ''' Refresh the data from the API by sending Async calls
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RefreshData()
        Me.ShowSpinner()

        Dim pageFilter As String = String.Format("$top={0}&$skip={1}&$orderby=Date desc", PageSize, PageSize * (CurrentPage - 1))

        Dim invoiceSvc = New Sale.InvoiceService(myConfiguration, Nothing, myOAuthKeyService)
        invoiceSvc.GetRange(myCompanyFile, pageFilter, myCredentials, AddressOf OnComplete, AddressOf OnError)
    End Sub


    ''' <summary>
    ''' Method called on Async complete
    ''' </summary>
    ''' <param name="statusCode"></param>
    ''' <param name="invoices"></param>
    ''' <remarks></remarks>
    Private Sub OnComplete(statusCode As System.Net.HttpStatusCode, invoices As Version2.PagedCollection(Of Version2.Sale.Invoice))
        'Invoke the SetDataSource method on the UI thread
        Dim d As New SetDataSourceCallback(AddressOf SetDataSource)
        Me.Invoke(d, New Object() {invoices})
    End Sub


    ''' <summary>
    ''' Method to set the datasource
    ''' </summary>
    ''' <param name="invoices">Pages collection of invoices</param>
    ''' <remarks></remarks>
    Private Sub SetDataSource(invoices As Version2.PagedCollection(Of Version2.Sale.Invoice))
        TotalPages = Math.Ceiling(CDbl(invoices.Count / PageSize))

        btnPageLeft.Enabled = (CurrentPage > 1)
        btnPageRight.Enabled = (CurrentPage < TotalPages)
        textPage.Text = String.Format("Page {0} of {1}", CurrentPage, TotalPages)


        'Fill the four grids
        gridAllInvoices.DataSource = invoices.Items
        gridOpenInvoices.DataSource = invoices.Items.Where(Function(s) s.Status = Version2.Sale.SaleStatus.Open).ToArray
        gridCreditInvoices.DataSource = invoices.Items.Where(Function(s) s.Status = Version2.Sale.SaleStatus.Credit).ToArray
        gridClosedInvoices.DataSource = invoices.Items.Where(Function(s) s.Status = Version2.Sale.SaleStatus.Closed).ToArray

        Me.HideSpinner()
    End Sub

    Private Sub btnPageLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnPageLeft.Click
        CurrentPage -= 1
        RefreshData()
    End Sub

    Private Sub btnPageRight_Click(sender As System.Object, e As System.EventArgs) Handles btnPageRight.Click
        CurrentPage += 1
        RefreshData()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Dim frmInvoice As New InvoiceForm()
        frmInvoice.Initialise(myConfiguration, myCompanyFile, myCredentials, myOAuthKeyService)
        frmInvoice.Show(Me)
    End Sub



    Private Sub gridAllInvoices_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridAllInvoices.CellContentDoubleClick
        'Get the selected company file
        Dim invoice As Version2.Sale.Invoice = CType(gridAllInvoices.DataSource, Version2.Sale.Invoice())(e.RowIndex)

        Select Case invoice.InvoiceType
            Case Version2.Sale.InvoiceLayoutType.Service
                'load the Invoice List
                Dim frmInvoice As New InvoiceForm()
                frmInvoice.Initialise(myConfiguration, myCompanyFile, myCredentials, myOAuthKeyService)
                frmInvoice.Show(invoice)
            Case Else
                MessageBox.Show("Only Service Invoices Have been implemented")
        End Select


    End Sub



End Class
