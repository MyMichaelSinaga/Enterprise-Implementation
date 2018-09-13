<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffSales
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuSales1 = New Kertas.MenuSales()
        Me.NavigasiTop1 = New Kertas.NavigasiTop()
        Me.Invoice = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idInvoice = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.TextBox()
        Me.jumlahKertas = New System.Windows.Forms.TextBox()
        Me.idGoodIssue = New System.Windows.Forms.TextBox()
        Me.deskripsi = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Invoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(196, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(466, 266)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Daftar Invoice"
        '
        'MenuSales1
        '
        Me.MenuSales1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.MenuSales1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuSales1.Location = New System.Drawing.Point(0, 40)
        Me.MenuSales1.Name = "MenuSales1"
        Me.MenuSales1.Size = New System.Drawing.Size(160, 403)
        Me.MenuSales1.TabIndex = 1
        '
        'NavigasiTop1
        '
        Me.NavigasiTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.NavigasiTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavigasiTop1.Location = New System.Drawing.Point(0, 0)
        Me.NavigasiTop1.Name = "NavigasiTop1"
        Me.NavigasiTop1.Size = New System.Drawing.Size(1081, 40)
        Me.NavigasiTop1.TabIndex = 0
        '
        'Invoice
        '
        Me.Invoice.Controls.Add(Me.Button1)
        Me.Invoice.Controls.Add(Me.deskripsi)
        Me.Invoice.Controls.Add(Me.idGoodIssue)
        Me.Invoice.Controls.Add(Me.jumlahKertas)
        Me.Invoice.Controls.Add(Me.tanggal)
        Me.Invoice.Controls.Add(Me.idInvoice)
        Me.Invoice.Controls.Add(Me.Label6)
        Me.Invoice.Controls.Add(Me.Label5)
        Me.Invoice.Controls.Add(Me.Label4)
        Me.Invoice.Controls.Add(Me.Label3)
        Me.Invoice.Controls.Add(Me.Label2)
        Me.Invoice.Location = New System.Drawing.Point(724, 47)
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Size = New System.Drawing.Size(316, 328)
        Me.Invoice.TabIndex = 4
        Me.Invoice.TabStop = False
        Me.Invoice.Text = "Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Deskripsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jumlah_kertas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Id Good Issue"
        '
        'idInvoice
        '
        Me.idInvoice.Location = New System.Drawing.Point(87, 27)
        Me.idInvoice.Name = "idInvoice"
        Me.idInvoice.ReadOnly = True
        Me.idInvoice.Size = New System.Drawing.Size(223, 20)
        Me.idInvoice.TabIndex = 6
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(87, 59)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        Me.tanggal.Size = New System.Drawing.Size(223, 20)
        Me.tanggal.TabIndex = 7
        '
        'jumlahKertas
        '
        Me.jumlahKertas.Location = New System.Drawing.Point(87, 207)
        Me.jumlahKertas.Name = "jumlahKertas"
        Me.jumlahKertas.ReadOnly = True
        Me.jumlahKertas.Size = New System.Drawing.Size(223, 20)
        Me.jumlahKertas.TabIndex = 8
        '
        'idGoodIssue
        '
        Me.idGoodIssue.Location = New System.Drawing.Point(87, 243)
        Me.idGoodIssue.Name = "idGoodIssue"
        Me.idGoodIssue.ReadOnly = True
        Me.idGoodIssue.Size = New System.Drawing.Size(223, 20)
        Me.idGoodIssue.TabIndex = 9
        '
        'deskripsi
        '
        Me.deskripsi.Location = New System.Drawing.Point(87, 95)
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.ReadOnly = True
        Me.deskripsi.Size = New System.Drawing.Size(223, 96)
        Me.deskripsi.TabIndex = 11
        Me.deskripsi.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Konfirmasi Invoice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StaffSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 443)
        Me.Controls.Add(Me.Invoice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuSales1)
        Me.Controls.Add(Me.NavigasiTop1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffSales"
        Me.Text = "StaffSales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Invoice.ResumeLayout(False)
        Me.Invoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NavigasiTop1 As Kertas.NavigasiTop
    Friend WithEvents MenuSales1 As Kertas.MenuSales
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Invoice As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents deskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents idGoodIssue As System.Windows.Forms.TextBox
    Friend WithEvents jumlahKertas As System.Windows.Forms.TextBox
    Friend WithEvents tanggal As System.Windows.Forms.TextBox
    Friend WithEvents idInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
