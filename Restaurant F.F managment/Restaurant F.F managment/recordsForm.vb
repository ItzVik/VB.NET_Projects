Public Class recordsForm
    Inherits UserControl
    Private Shared _instance As recordsForm

    Public Shared ReadOnly Property instance() As recordsForm
        Get
            If _instance Is Nothing Then
                _instance = New recordsForm

            End If
            Return _instance
        End Get

    End Property
    Private Sub recordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
