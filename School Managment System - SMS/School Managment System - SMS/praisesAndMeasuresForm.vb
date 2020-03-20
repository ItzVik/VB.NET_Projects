Imports System.IO
Public Class praisesAndMeasuresForm
    Inherits UserControl
    Private Shared _instance As praisesAndMeasuresForm

    Public Shared ReadOnly Property instance() As praisesAndMeasuresForm
        Get
            If _instance Is Nothing Then
                _instance = New praisesAndMeasuresForm

            End If
            Return _instance
        End Get

    End Property
    Private Sub praisesAndMeasuresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
