Public Class toolsForm
    Inherits UserControl
    Private Shared _instance As toolsForm

    Public Shared ReadOnly Property instance() As toolsForm
        Get
            If _instance Is Nothing Then
                _instance = New toolsForm

            End If
            Return _instance
        End Get

    End Property
    Private Sub toolsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
