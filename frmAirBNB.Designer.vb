<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBNB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picAirBNB = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblPricePerNight = New System.Windows.Forms.Label()
        Me.lblNumberOfNights = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picAirBNB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAirBNB
        '
        Me.picAirBNB.Image = Global.WeeklyAssignment4.My.Resources.Resources.airbnb
        Me.picAirBNB.Location = New System.Drawing.Point(6, 4)
        Me.picAirBNB.Name = "picAirBNB"
        Me.picAirBNB.Size = New System.Drawing.Size(396, 443)
        Me.picAirBNB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirBNB.TabIndex = 0
        Me.picAirBNB.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(469, 20)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(276, 36)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Orlando AirBnB"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPricePerNight
        '
        Me.lblPricePerNight.AutoSize = True
        Me.lblPricePerNight.Font = New System.Drawing.Font("Cooper Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerNight.Location = New System.Drawing.Point(495, 62)
        Me.lblPricePerNight.Name = "lblPricePerNight"
        Me.lblPricePerNight.Size = New System.Drawing.Size(0, 23)
        Me.lblPricePerNight.TabIndex = 2
        Me.lblPricePerNight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumberOfNights
        '
        Me.lblNumberOfNights.AutoSize = True
        Me.lblNumberOfNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumberOfNights.Location = New System.Drawing.Point(455, 153)
        Me.lblNumberOfNights.Name = "lblNumberOfNights"
        Me.lblNumberOfNights.Size = New System.Drawing.Size(185, 25)
        Me.lblNumberOfNights.TabIndex = 3
        Me.lblNumberOfNights.Text = "Number of Nights:"
        Me.lblNumberOfNights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(676, 154)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(37, 26)
        Me.txtNights.TabIndex = 4
        Me.txtNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCost.Location = New System.Drawing.Point(455, 225)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(138, 25)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "Cost of Stay:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(671, 225)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(77, 25)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Label1"
        Me.lblTotal.Visible = False
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold)
        Me.btnCost.Location = New System.Drawing.Point(415, 345)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(117, 30)
        Me.btnCost.TabIndex = 7
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(545, 345)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 30)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(676, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAirBNB
        '
        Me.AcceptButton = Me.btnCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(803, 452)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.lblNumberOfNights)
        Me.Controls.Add(Me.lblPricePerNight)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picAirBNB)
        Me.Name = "frmAirBNB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirBNB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAirBNB As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPricePerNight As Label
    Friend WithEvents lblNumberOfNights As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
