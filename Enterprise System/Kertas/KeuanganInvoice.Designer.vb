﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeuanganInvoice
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.idPO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idInvoice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.deskripsi = New System.Windows.Forms.RichTextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuKeuangan1 = New Kertas.MenuKeuangan()
        Me.NavigasiTop1 = New Kertas.NavigasiTop()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(186, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(515, 245)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Daftar Invoice"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.idPO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.idInvoice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tanggal)
        Me.GroupBox1.Controls.Add(Me.deskripsi)
        Me.GroupBox1.Controls.Add(Me.jumlah)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(726, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 361)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Good Receipt"
        '
        'idPO
        '
        Me.idPO.Location = New System.Drawing.Point(74, 24)
        Me.idPO.Name = "idPO"
        Me.idPO.ReadOnly = True
        Me.idPO.Size = New System.Drawing.Size(221, 20)
        Me.idPO.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Id PO"
        '
        'idInvoice
        '
        Me.idInvoice.Location = New System.Drawing.Point(74, 66)
        Me.idInvoice.Name = "idInvoice"
        Me.idInvoice.ReadOnly = True
        Me.idInvoice.Size = New System.Drawing.Size(221, 20)
        Me.idInvoice.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Id Invoice"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Kirim"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(74, 118)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(221, 20)
        Me.tanggal.TabIndex = 5
        '
        'deskripsi
        '
        Me.deskripsi.Location = New System.Drawing.Point(74, 158)
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Size = New System.Drawing.Size(221, 96)
        Me.deskripsi.TabIndex = 4
        Me.deskripsi.Text = ""
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(89, 272)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        Me.jumlah.Size = New System.Drawing.Size(206, 20)
        Me.jumlah.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jumlah Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal"
        '
        'MenuKeuangan1
        '
        Me.MenuKeuangan1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.MenuKeuangan1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuKeuangan1.Location = New System.Drawing.Point(0, 40)
        Me.MenuKeuangan1.Name = "MenuKeuangan1"
        Me.MenuKeuangan1.Size = New System.Drawing.Size(160, 403)
        Me.MenuKeuangan1.TabIndex = 1
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
        'KeuanganInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuKeuangan1)
        Me.Controls.Add(Me.NavigasiTop1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KeuanganInvoice"
        Me.Text = "KeuanganInvoice"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NavigasiTop1 As Kertas.NavigasiTop
    Friend WithEvents MenuKeuangan1 As Kertas.MenuKeuangan
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents deskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents idPO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
