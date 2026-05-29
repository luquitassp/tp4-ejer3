<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtIngreso1 = New TextBox()
        txtIngreso2 = New TextBox()
        txtIngreso3 = New TextBox()
        lblMostrar1 = New Label()
        lblMostrar2 = New Label()
        lblMostrar3 = New Label()
        cmdEjecutar = New Button()
        SuspendLayout()
        ' 
        ' txtIngreso1
        ' 
        txtIngreso1.Location = New Point(38, 29)
        txtIngreso1.Name = "txtIngreso1"
        txtIngreso1.Size = New Size(210, 27)
        txtIngreso1.TabIndex = 0
        ' 
        ' txtIngreso2
        ' 
        txtIngreso2.Location = New Point(40, 84)
        txtIngreso2.Name = "txtIngreso2"
        txtIngreso2.Size = New Size(206, 27)
        txtIngreso2.TabIndex = 1
        ' 
        ' txtIngreso3
        ' 
        txtIngreso3.Location = New Point(38, 139)
        txtIngreso3.Name = "txtIngreso3"
        txtIngreso3.Size = New Size(204, 27)
        txtIngreso3.TabIndex = 2
        ' 
        ' lblMostrar1
        ' 
        lblMostrar1.AutoSize = True
        lblMostrar1.Location = New Point(39, 196)
        lblMostrar1.Name = "lblMostrar1"
        lblMostrar1.Size = New Size(0, 20)
        lblMostrar1.TabIndex = 3
        ' 
        ' lblMostrar2
        ' 
        lblMostrar2.AutoSize = True
        lblMostrar2.Location = New Point(41, 248)
        lblMostrar2.Name = "lblMostrar2"
        lblMostrar2.Size = New Size(0, 20)
        lblMostrar2.TabIndex = 4
        ' 
        ' lblMostrar3
        ' 
        lblMostrar3.AutoSize = True
        lblMostrar3.Location = New Point(42, 300)
        lblMostrar3.Name = "lblMostrar3"
        lblMostrar3.Size = New Size(0, 20)
        lblMostrar3.TabIndex = 5
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(42, 350)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(80, 36)
        cmdEjecutar.TabIndex = 6
        cmdEjecutar.Text = "ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmdEjecutar)
        Controls.Add(lblMostrar3)
        Controls.Add(lblMostrar2)
        Controls.Add(lblMostrar1)
        Controls.Add(txtIngreso3)
        Controls.Add(txtIngreso2)
        Controls.Add(txtIngreso1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIngreso1 As TextBox
    Friend WithEvents txtIngreso2 As TextBox
    Friend WithEvents txtIngreso3 As TextBox
    Friend WithEvents lblMostrar1 As Label
    Friend WithEvents lblMostrar2 As Label
    Friend WithEvents lblMostrar3 As Label
    Friend WithEvents cmdEjecutar As Button

End Class
