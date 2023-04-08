Public Class IPAN2
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)

                'Elimina el usuario de la base de datos
                Dim deleteQuery As String = "DELETE FROM IPAB WHERE ID = @ID"
                Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danye\Documents\Databases\baseProyecto.mdb;"
                Using connection As New OleDb.OleDbConnection(connectionString)
                    Using command As New OleDb.OleDbCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@ID", userId)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                'Elimina el usuario del DataGridView
                DataGridView1.Rows.Remove(selectedRow)
            End If
        End If
    End Sub

    Private Sub IPAN2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaseProyectoDataSet2.IPAB' table. You can move, or remove it, as needed.
        Me.IPABTableAdapter1.Fill(Me.BaseProyectoDataSet2.IPAB)
        'TODO: This line of code loads data into the 'BaseProyectoDataSet1.IPAB' table. You can move, or remove it, as needed.
        Me.IPABTableAdapter.Fill(Me.BaseProyectoDataSet1.IPAB)
        ActualizarDataGridView()

    End Sub

    Private Sub ActualizarDataGridView()
        Dim conexion As New OleDb.OleDbConnection()
        conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danye\Documents\Databases\baseProyecto.mdb;"
        conexion.Open()

        Dim comando As New OleDb.OleDbCommand("SELECT * FROM IPAB", conexion)
        Dim dt As New DataTable
        dt.Load(comando.ExecuteReader())

        DataGridView1.DataSource = dt

        conexion.Close()
    End Sub

End Class