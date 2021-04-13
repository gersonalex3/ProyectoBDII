Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class UserController
        Inherits ApiController




        ' GET: api/User
        Public Function GetValues() As IEnumerable(Of String)
            getConexion()

            Dim da As New Oracle.ManagedDataAccess.Client.OracleDataAdapter("select * from REGION", Con)
            Dim ds As New DataSet
            da.Fill(ds)

            Return New String() {ds.Tables(0).Rows.Count}
        End Function

        ' GET: api/User/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/User
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/User/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/User/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace