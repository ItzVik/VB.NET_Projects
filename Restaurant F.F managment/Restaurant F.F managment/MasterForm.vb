Public Class MasterForm
    Inherits UserControl
    Private Shared _instance As MasterForm

    Public Shared ReadOnly Property instance() As MasterForm
        Get
            If _instance Is Nothing Then
                _instance = New MasterForm

            End If
            Return _instance
        End Get

    End Property
   
    Private Sub MasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
