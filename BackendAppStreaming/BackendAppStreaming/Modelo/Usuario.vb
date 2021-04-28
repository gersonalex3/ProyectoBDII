
Imports System.Data.Odbc

Module Usuario

    Public Conexion As OdbcConnection
    Public comando As New OdbcCommand

    Public Sub AbrirConexion()
        Conexion = New OdbcConnection
        Conexion.ConnectionString = ConfigurationManager.ConnectionStrings("cnConexion").ConnectionString
        Conexion.Open()
    End Sub

    Public Sub ObtenerLink(id As Int32)

        AbrirConexion()



    End Sub

End Module
