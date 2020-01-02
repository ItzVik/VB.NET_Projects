Public Class administrationForm

    Inherits UserControl
    Private Shared _instance As administrationForm

    Public Shared ReadOnly Property instance() As administrationForm
        Get
            If _instance Is Nothing Then
                _instance = New administrationForm

            End If
            Return _instance
        End Get

    End Property

    Private Sub administrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
