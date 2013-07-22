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

Imports System
Imports System.Collections.Generic
Namespace VisualBasicSamples.Common.Models

    Public Enum Classifications
        Unknown = 0
        Asset = 1
        Liability = 2
        Equity = 3
        Income = 4
        CostOfSales = 5
        Expense = 6
        OtherIncome = 7
        OtherExpense = 8
    End Enum

    Public Enum AccountTypes
        Bank = 1
        AccountReceivable = 2
        OtherCurrentAsset = 3
        FixedAsset = 4
        OtherAsset = 5
        CreditCard = 6
        AccountsPayable = 7
        OtherCurrentLiability = 8
        LongTermLiability = 9
        OtherLiability = 10
        Equity = 11
        Income = 12
        CostOfSales = 13
        Expense = 14
        OtherIncome = 15
        OtherExpense = 16
    End Enum


    Public Class AccountLink
        Public Property UID() As String
        Public Property Name() As String
        Public Property DisplayID() As String
        Public Property URI() As String
    End Class

    Public Class TaxCodeLink
        Public Property UID() As String
        Public Property Code() As String
        Public Property URI() As String
    End Class

    Public Class BankDetailsModel
        Public Property BankAccountNumber() As String
        Public Property BankAccountName() As String
        Public Property CompanyTradingName() As String
        Public Property BankCode() As String
        Public Property CreateBankFile() As Boolean
        Public Property DirectEntryUserId() As String
        Public Property IncludeSelfBalancingTransaction() As Boolean
        Public Property StatementCode() As String
        Public Property StatementReference() As String
        Public Property StatementParticulars() As String
    End Class

    Public Class AccountModel
        Public ReadOnly Property IsNew() As Boolean
            Get
                Return String.IsNullOrEmpty(UID)
            End Get
        End Property
        Public Property UID() As String
        Public Property Name() As String
        Public Property DisplayID() As String
        Public Property Classification() As Classifications
        Public Property Type() As AccountTypes
        Public Property Number() As Integer
        Public Property Description() As String
        Public Property ParentAccount() As AccountLink
        Public Property IsActive() As Boolean
        Public Property TaxCode() As TaxCodeLink
        Public Property Level() As Integer
        Public Property OpeningAccountBalance() As Decimal
        Public Property CurrentAccountBalance() As Decimal
        Public Property BankingDetails() As BankDetailsModel
        Public Property IsHeader() As Boolean
        Public Property URI() As String
        Public Property RowVersion() As String
    End Class
End Namespace
