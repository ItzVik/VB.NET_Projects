Public Class dashboardForm
    Inherits UserControl
    Private Shared _instance As dashboardForm

    Public Shared ReadOnly Property instance() As dashboardForm
        Get
            If _instance Is Nothing Then
                _instance = New dashboardForm

            End If
            Return _instance
        End Get

    End Property

    Private Sub dashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
