Public Class frmAirBNB
    Const _cdecCost As Decimal = 79D

    Private Sub frmAirBNB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPricePerNight.Text = "Only " & _cdecCost.ToString("c") & " per night"
        txtNights.Clear()
        txtNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        lblTotal.Text = ""
        txtNights.Focus()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCost As Decimal

        strNumNights = txtNights.Text
        intNumNights = Convert.ToInt32(strNumNights)
        decTotalCost = intNumNights * _cdecCost
        lblTotal.Text = decTotalCost.ToString("c")
        lblTotal.Visible = True
    End Sub
End Class
