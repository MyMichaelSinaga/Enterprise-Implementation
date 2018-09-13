<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesOrderCreate
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
        Me.NavigasiTop1 = New Kertas.NavigasiTop()
        Me.MenuSales1 = New Kertas.MenuSales()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.namaPelanggan = New System.Windows.Forms.TextBox()
        Me.alamatPelanggan = New System.Windows.Forms.TextBox()
        Me.teleponPelanggan = New System.Windows.Forms.TextBox()
        Me.jumlahBarang = New System.Windows.Forms.TextBox()
        Me.totalHarga = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NavigasiTop2 = New Kertas.NavigasiTop()
        Me.SuspendLayout()
        '
        'NavigasiTop1
        '
        Me.NavigasiTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.NavigasiTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavigasiTop1.Location = New System.Drawing.Point(0, 0)
        Me.NavigasiTop1.Name = "NavigasiTop1"
        Me.NavigasiTop1.Size = New System.Drawing.Size(712, 40)
        Me.NavigasiTop1.TabIndex = 0
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
        'tanggal
        '
        Me.tanggal.CustomFormat = "yyyy-MM-dd"
        Me.tanggal.Location = New System.Drawing.Point(375, 62)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(200, 20)
        Me.tanggal.TabIndex = 2
        '
        'namaPelanggan
        '
        Me.namaPelanggan.Location = New System.Drawing.Point(375, 102)
        Me.namaPelanggan.Name = "namaPelanggan"
        Me.namaPelanggan.Size = New System.Drawing.Size(200, 20)
        Me.namaPelanggan.TabIndex = 3
        '
        'alamatPelanggan
        '
        Me.alamatPelanggan.Location = New System.Drawing.Point(375, 144)
        Me.alamatPelanggan.Name = "alamatPelanggan"
        Me.alamatPelanggan.Size = New System.Drawing.Size(200, 20)
        Me.alamatPelanggan.TabIndex = 4
        '
        'teleponPelanggan
        '
        Me.teleponPelanggan.Location = New System.Drawing.Point(375, 188)
        Me.teleponPelanggan.Name = "teleponPelanggan"
        Me.teleponPelanggan.Size = New System.Drawing.Size(200, 20)
        Me.teleponPelanggan.TabIndex = 5
        '
        'jumlahBarang
        '
        Me.jumlahBarang.Location = New System.Drawing.Point(375, 235)
        Me.jumlahBarang.Name = "jumlahBarang"
        Me.jumlahBarang.Size = New System.Drawing.Size(200, 20)
        Me.jumlahBarang.TabIndex = 6
        '
        'totalHarga
        '
        Me.totalHarga.Location = New System.Drawing.Point(375, 280)
        Me.totalHarga.Name = "totalHarga"
        Me.totalHarga.ReadOnly = True
        Me.totalHarga.Size = New System.Drawing.Size(200, 20)
        Me.totalHarga.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Create Sales Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Alamat Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Telepon Pelanggan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Jumlah Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total Harga"
        '
        'NavigasiTop2
        '
        Me.NavigasiTop2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.NavigasiTop2.Location = New System.Drawing.Point(0, 0)
        Me.NavigasiTop2.Name = "NavigasiTop2"
        Me.NavigasiTop2.Size = New System.Drawing.Size(712, 40)
        Me.NavigasiTop2.TabIndex = 16
        '
        'SalesOrderCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 443)
        Me.Controls.Add(Me.NavigasiTop2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.totalHarga)
        Me.Controls.Add(Me.jumlahBarang)
        Me.Controls.Add(Me.teleponPelanggan)
        Me.Controls.Add(Me.alamatPelanggan)
        Me.Controls.Add(Me.namaPelanggan)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.MenuSales1)
        Me.Controls.Add(Me.NavigasiTop1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesOrderCreate"
        Me.Text = "SalesOrderCreate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NavigasiTop1 As Kertas.NavigasiTop
    Friend WithEvents MenuSales1 As Kertas.MenuSales
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents namaPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents alamatPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents teleponPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents jumlahBarang As System.Windows.Forms.TextBox
    Friend WithEvents totalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NavigasiTop2 As Kertas.NavigasiTop
End Class
