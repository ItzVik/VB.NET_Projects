Public Class reportsForm
    Inherits UserControl
    Private Shared _instance As reportsForm

    Public Shared ReadOnly Property instance() As reportsForm
        Get
            If _instance Is Nothing Then
                _instance = New reportsForm

            End If
            Return _instance
        End Get

    End Property
    Private Sub reportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
