Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Web

Public Class Session
    Private Class LoginParams
        Public Property ip_h As String = ""
        Public Property lg_h As String = ""
        Public Property remixlhk As String = ""

        Public ReadOnly Property IsValid() As Boolean
            Get
                Return Not String.IsNullOrEmpty(ip_h) AndAlso Not String.IsNullOrEmpty(lg_h) AndAlso Not String.IsNullOrEmpty(remixlhk)
            End Get
        End Property

        Public Sub New()
            ' Make request
            Dim request As HttpWebRequest = CType(WebRequest.Create("https://vk.com"), HttpWebRequest)
            request.Method = "GET"

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim cookie As String = ((response.Headers("Set-Cookie").Split(New String() {"remixlhk="}, StringSplitOptions.None)(1)).Split(";"))(0)

            If cookie <> "" Then
                remixlhk = cookie
            End If

            Dim responseStream = New StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("windows-1251"))
            Dim result As String = responseStream.ReadToEnd()

            ' Fetch login parameters

            ip_h = FetchParam("ip_h", result)
            lg_h = FetchParam("lg_h", result)
            responseStream.Close()
            response.Close()

            If Not IsValid Then
                Throw New ApplicationException("There was a problem fetching required login parameters")
            End If

        End Sub

        Private Shared Function FetchParam(ByVal paramName As String, ByVal data As String) As String
            Dim htmlElementStart As Integer = data.IndexOf("<form method=""post"" action=""https://login.vk.com")
            If htmlElementStart <> -1 Then
                Dim html As String = data.Substring(htmlElementStart, data.IndexOf(">"c, htmlElementStart) - htmlElementStart)
                Dim startPos As Integer = html.IndexOf(paramName & "=")
                If startPos <> -1 Then
                    startPos += paramName.Length + 1
                    Dim endPos As Integer = html.IndexOf("&"c, startPos)
                    Dim result As String = html.Substring(startPos, endPos - startPos)
                    Return result
                End If
            End If
            Return ""
        End Function
    End Class

    Private Params As LoginParams

    Public Property Username As String = ""
    Public Property Password As String = ""
    Public Property Guid As String = ""

    Public ReadOnly Property IsLoggedIn() As Boolean
        Get
            Return Not String.IsNullOrEmpty(Guid) AndAlso Guid <> "DELETED"
        End Get
    End Property

    Public Sub New()
        Reset()
    End Sub

    Public Sub New(ByVal username As String, ByVal password As String)
        Me.New()
        Me.Username = username
        Me.Password = password
    End Sub

    Public Sub Reset()
        Params = New LoginParams()
        Username = ""
        Password = ""
        Guid = ""
        My.Settings.AuthUser = ""
        My.Settings.AuthPass = ""
    End Sub

    Public Function TryLogin() As Boolean

        If Not Params.IsValid Then
            Return False
        End If

        ' Make request
        Dim request As HttpWebRequest = WebRequest.Create("https://login.vk.com")
        request.Method = "POST"
        request.CookieContainer = New CookieContainer()
        request.CookieContainer.Add(New Uri("https://login.vk.com"), New Cookie("remixlhk", Params.remixlhk))

        ' Create POST content and send
        Dim postData = New StringBuilder("act=login&role=al_frame&expire=&captcha_sid=&captcha_key=&_origin=https%3A%2F%2Fvk.com")
        postData.AppendFormat("&ip_h={0}", Params.ip_h)
        postData.AppendFormat("&lg_h={0}", Params.lg_h)
        postData.AppendFormat("&email={0}", HttpUtility.UrlEncode(Username))
        postData.AppendFormat("&pass={0}", HttpUtility.UrlEncode(Password))

        Dim postBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(postData.ToString())

        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = postBytes.Length

        Using requestStream As Stream = request.GetRequestStream()
            requestStream.Write(postBytes, 0, postBytes.Length)

            ' Get response and login cookie
            Using response As HttpWebResponse = request.GetResponse()
                Dim cookie As String = (((response.Headers("Set-Cookie")).Split(New String() {"remixsid="}, StringSplitOptions.None)(1)).Split(";"))(0)

                If cookie <> "" Then
                    Guid = cookie
                End If
            End Using
        End Using

        Return IsLoggedIn
    End Function
End Class