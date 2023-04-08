Public Class IPAB
    Private Sub IPAB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Verifica que los campos obligatorios estén completos
        If String.IsNullOrEmpty(NumericUpDown2.Text) Or NumericUpDown2.Value = 0 Then
            MessageBox.Show("Por favor ingrese un nombre y el dinero ahorrado antes de guardar los datos.")
            Return
        End If

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danye\Documents\Databases\baseProyecto.mdb;"
        Dim conexion As New OleDb.OleDbConnection(connectionString)

        ' Abre la conexión
        conexion.Open()

        ' Haz algo con la base de datos, como insertar datos
        Dim comando As New OleDb.OleDbCommand("INSERT INTO IPAB (nombre, dinero_ahorrado, estado_civil, direccion, num_telefonico, correo_electronico) VALUES (@nombre, @dinero, @estadoCivil, @direccion, @telefono, @correo)", conexion)
        comando.Parameters.AddWithValue("@nombre", TextBox1.Text)
        comando.Parameters.AddWithValue("@dinero", NumericUpDown2.Text)
        comando.Parameters.AddWithValue("@estadoCivil", ComboBox1.Text)
        comando.Parameters.AddWithValue("@direccion", TextBox3.Text)
        comando.Parameters.AddWithValue("@telefono", NumericUpDown1.Text)
        comando.Parameters.AddWithValue("@correo", TextBox4.Text)
        comando.ExecuteNonQuery()
        MessageBox.Show("Sus datos se han guardado con exito.")
        ' Cierra la conexión
        conexion.Close()
        Me.Close()
    End Sub
End Class