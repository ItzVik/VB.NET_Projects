Public Class HomeForm

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        SidePanel.Height = btnUser.Height
        SidePanel.Top = btnUser.Top
        If Not Panel3.Controls.Contains(UserForm.Instance) Then
            Panel3.Controls.Add(UserForm.Instance)
            UserForm.Instance.Dock = DockStyle.Fill
            UserForm.Instance.BringToFront()
            UserForm.Instance.Visible = True
        End If
        UserForm.Instance.BringToFront()
        UserForm.Instance.Visible = True
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        SidePanel.Height = btnCategory.Height
        SidePanel.Top = btnCategory.Top
        If Not Panel3.Controls.Contains(CategoryForm.Instance) Then
            Panel3.Controls.Add(CategoryForm.Instance)
            CategoryForm.Instance.Dock = DockStyle.Fill
            CategoryForm.Instance.BringToFront()
            CategoryForm.Instance.Visible = True
        End If
        CategoryForm.Instance.BringToFront()
        CategoryForm.Instance.Visible = True
    End Sub

    Private Sub btnMenuItem_Click(sender As Object, e As EventArgs) Handles btnMenuItem.Click
        SidePanel.Height = btnMenuItem.Height
        SidePanel.Top = btnMenuItem.Top
        If Not Panel3.Controls.Contains(MenuItemForm.Instance) Then
            Panel3.Controls.Add(MenuItemForm.Instance)
            MenuItemForm.Instance.Dock = DockStyle.Fill
            MenuItemForm.Instance.BringToFront()
            MenuItemForm.Instance.Visible = True
        End If
        MenuItemForm.Instance.BringToFront()
        MenuItemForm.Instance.Visible = True
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        SidePanel.Height = btnOrder.Height
        SidePanel.Top = btnOrder.Top
        If Not Panel3.Controls.Contains(OrderForm.Instance) Then
            Panel3.Controls.Add(OrderForm.Instance)
            OrderForm.Instance.Dock = DockStyle.Fill
            OrderForm.Instance.BringToFront()
            OrderForm.Instance.Visible = True
        End If
        OrderForm.Instance.BringToFront()
        OrderForm.Instance.Visible = True
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        SidePanel.Height = btnBill.Height
        SidePanel.Top = btnBill.Top
        If Not Panel3.Controls.Contains(BillForm.Instance) Then
            Panel3.Controls.Add(BillForm.Instance)
            BillForm.Instance.Dock = DockStyle.Fill
            BillForm.Instance.BringToFront()
            BillForm.Instance.Visible = True
        End If
        BillForm.Instance.BringToFront()
        BillForm.Instance.Visible = True
    End Sub
End Class