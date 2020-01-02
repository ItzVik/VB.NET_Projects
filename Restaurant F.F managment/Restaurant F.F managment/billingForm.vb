Public Class billingForm

    Inherits UserControl
    Private Shared _instance As billingForm

    Public Shared ReadOnly Property instance() As billingForm
        Get
            If _instance Is Nothing Then
                _instance = New billingForm

            End If
            Return _instance
        End Get

    End Property

    Private Sub billingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
