Imports System.IO
Public Class Expense
    Inherits UserControl
    Private Shared _instance As Expense

    Public Shared ReadOnly Property instance() As Expense
        Get
            If _instance Is Nothing Then
                _instance = New Expense

            End If
            Return _instance
        End Get

    End Property
    Private Sub Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
