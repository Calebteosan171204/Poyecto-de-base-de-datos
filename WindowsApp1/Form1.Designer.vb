<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdmSolidariaMexicanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPABToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegurosSuraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarjetaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlgoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmSolidariaMexicanaToolStripMenuItem, Me.IPABToolStripMenuItem, Me.QualitasToolStripMenuItem, Me.SegurosSuraToolStripMenuItem, Me.TarjetaDeToolStripMenuItem, Me.AlgoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdmSolidariaMexicanaToolStripMenuItem
        '
        Me.AdmSolidariaMexicanaToolStripMenuItem.Name = "AdmSolidariaMexicanaToolStripMenuItem"
        Me.AdmSolidariaMexicanaToolStripMenuItem.Size = New System.Drawing.Size(147, 20)
        Me.AdmSolidariaMexicanaToolStripMenuItem.Text = "Adm Solidaria Mexicana"
        '
        'IPABToolStripMenuItem
        '
        Me.IPABToolStripMenuItem.Name = "IPABToolStripMenuItem"
        Me.IPABToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.IPABToolStripMenuItem.Text = "IPAB"
        '
        'QualitasToolStripMenuItem
        '
        Me.QualitasToolStripMenuItem.Name = "QualitasToolStripMenuItem"
        Me.QualitasToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.QualitasToolStripMenuItem.Text = "Qualitas"
        '
        'SegurosSuraToolStripMenuItem
        '
        Me.SegurosSuraToolStripMenuItem.Name = "SegurosSuraToolStripMenuItem"
        Me.SegurosSuraToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.SegurosSuraToolStripMenuItem.Text = "SegurosSura"
        '
        'TarjetaDeToolStripMenuItem
        '
        Me.TarjetaDeToolStripMenuItem.Name = "TarjetaDeToolStripMenuItem"
        Me.TarjetaDeToolStripMenuItem.Size = New System.Drawing.Size(142, 20)
        Me.TarjetaDeToolStripMenuItem.Text = "Tarjeta de Credito BBVA"
        '
        'AlgoToolStripMenuItem
        '
        Me.AlgoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdadaToolStripMenuItem, Me.DadToolStripMenuItem, Me.DadToolStripMenuItem1})
        Me.AlgoToolStripMenuItem.Name = "AlgoToolStripMenuItem"
        Me.AlgoToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.AlgoToolStripMenuItem.Text = "al;go"
        '
        'AdadaToolStripMenuItem
        '
        Me.AdadaToolStripMenuItem.Name = "AdadaToolStripMenuItem"
        Me.AdadaToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.AdadaToolStripMenuItem.Text = "adada"
        '
        'DadToolStripMenuItem
        '
        Me.DadToolStripMenuItem.Name = "DadToolStripMenuItem"
        Me.DadToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DadToolStripMenuItem.Text = "dad"
        '
        'DadToolStripMenuItem1
        '
        Me.DadToolStripMenuItem1.Name = "DadToolStripMenuItem1"
        Me.DadToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.DadToolStripMenuItem1.Text = "dad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.brandi_redd_aJTiW00qqtI_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdmSolidariaMexicanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IPABToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QualitasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegurosSuraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarjetaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlgoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DadToolStripMenuItem1 As ToolStripMenuItem
End Class
