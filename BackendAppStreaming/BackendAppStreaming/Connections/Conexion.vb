
Imports Oracle.ManagedDataAccess.Client
Module Conexion
    Public Con As OracleConnection

    Public Sub getConexion()
        Con = New OracleConnection
        Con.ConnectionString = "User Id=northwind;Password=northwind;Data Source=localhost:1521/orcl; "
        Con.Open()
    End Sub
End Module
