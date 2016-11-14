Imports System.Net
Imports System.Xml

Public Class Agregar
    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        miip.Text = GetGeoLocation(myIp)
        'miip.Text = myIp()
    End Sub

    Public Function myIp() As String
        Dim strHostName As String = ""
        strHostName = System.Net.Dns.GetHostName()

        Dim ipEntry As IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        Dim addr As IPAddress() = ipEntry.AddressList
        Dim IP As String
        IP = addr(3).ToString()

        'Dim doc As New XmlDocument()
        'doc.Load("http://freegeoip.net/xml/" + IP)
        'Dim nodeLstCity As XmlNodeList = doc.GetElementsByTagName("City")
        'IP = "" + nodeLstCity(0).InnerText + "<br>" + IP
        'Return IP
    End Function

    Public Shared Function GetGeoLocation(ByVal IpAddress As String) As String

        Using client = New WebClient()
            Try
                Dim strFile = client.DownloadString(String.Format("http://freegeoip.net/xml/{0}", IpAddress))

                Dim xml As XDocument = XDocument.Parse(strFile)
                Dim nodeLstCity As XmlNodeList = xml.Elements.("City")




            Catch ex As Exception
                Return "Default"
            End Try
        End Using
    End Function
End Class