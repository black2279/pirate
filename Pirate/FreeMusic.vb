Imports System
Imports System.IO
Imports System.Net
Imports HtmlAgilityPack
Imports System.Text.RegularExpressions
Imports Jurassic

Public Class FreeMusic
    Private _session As Session
    Private _engine As Jurassic.ScriptEngine

#Region "Public functions"

    Public Sub ResetSession()
        _session = New Session()
    End Sub

    Public Sub Login(ByVal username As String, ByVal password As String)
        If String.IsNullOrEmpty(username) Then
            Throw New ArgumentNullException("username", "Please enter a username.")
        End If
        If String.IsNullOrEmpty(password) Then
            Throw New ArgumentNullException("password", "Please enter a password.")
        End If

        _session = New Session(username, password)
        _session.TryLogin()

        If Not _session.IsLoggedIn Then
            Dim message = "Unable To log in." & Environment.NewLine & Environment.NewLine &
                          "Please check that you have entered your login and password correctly." & Environment.NewLine &
                          "- Is the Caps Lock safely turned off?" & Environment.NewLine &
                          "- Maybe you are using the wrong input language? (e.g. German vs. English)" &
                          Environment.NewLine &
                          "- Try typing your password in a text editor and pasting it into the ""Password"" field." &
                          Environment.NewLine & Environment.NewLine &
                          "If you then have checked everything thoroughly, but still cannot log In, please go to: https://vk.com/restore"
            Throw New Exception(message)
        Else
            ' Save username/password settings
            My.Settings.AuthUser = username
            My.Settings.AuthPass = password
            'Initialize script engine
            _engine = New Jurassic.ScriptEngine()
            LoadScript()
        End If
    End Sub

    Public Function Search(ByVal query As String, Optional ByVal offset As Integer = 1) As List(Of Song)
        Dim data As String = "act=search&offset=" & offset &
                             "&q=" & System.Web.HttpUtility.UrlEncode(query)
        Dim result As String = PostRequest("https://m.vk.com/audio", data)

        ' Parse songs
        Dim songs As List(Of Song) = ParseSongs(result)

        ' Return songs
        Return songs
    End Function

    Public Function FetchDetail(ByVal song As Song) As Song
        Try
            ' Make request
            Dim request As HttpWebRequest = WebRequest.Create(song.Url)
            request.Method = "HEAD"

            ' Get response
            Using response As HttpWebResponse = request.GetResponse
                Dim length As Integer = response.Headers("Content-Length")

                ' Set details for song
                song.Size = length
                song.Bitrate = MapBitrate(Math.Round(song.Size * 8 / song.Duration / 1000))

                ' Return songs
                Return song
            End Using

        Catch ex As Exception
            ' Return the song without any details
            Return song
        End Try
    End Function

#End Region

#Region "Private functions"

    Private Function ParseSongs(ByVal response As String) As List(Of Song)

        ' Create list for the results
        Dim songs As New List(Of Song)
        ' Get only html tag content
        Dim rx As New Regex("(<\s*html[^>]*>)(.*?)(<\s*/\s*html>)", RegexOptions.Singleline)
        Dim m As Match = rx.Match(response)

        If m.Success Then

            Dim str_html As String = "<html>" + Trim(m.Groups(2).ToString()) + "</html>"
            Dim doc As HtmlDocument = New HtmlDocument()

            doc.LoadHtml(str_html)

            'Get songs Html Nodes by XPath Expression
            Dim songs_nodes = doc.DocumentNode.SelectNodes("//div[@class='audio_item  ai_has_btn']")

            If Not IsNothing(songs_nodes) Then

                For Each s As HtmlNode In songs_nodes
                    'Retrive song info by XPath Expressions
                    Dim artist As String = s.SelectSingleNode(".//span[@class='ai_artist']").InnerText
                    Dim title As String = s.SelectSingleNode(".//span[@class='ai_title']").InnerText
                    Dim duration As Integer = s.SelectSingleNode(".//div[@class='ai_dur']").GetAttributeValue("data-dur", -1)
                    Dim url As String = s.SelectSingleNode(".//input[@type='hidden']").GetAttributeValue("value", "no-url")

                    songs.Add(New Song() With {
                            .Artist = WebUtility.HtmlDecode(artist),
                            .Title = WebUtility.HtmlDecode(title),
                            .Duration = duration,
                            .Url = _engine.Evaluate("var vkid=" + My.Settings.UserId + "; e( '" + url + "' )")
                    })

                Next
            End If
        End If

        Return songs
    End Function

    Private Function PostRequest(url As String, data As String) As String
        ' Make request
        Dim request As HttpWebRequest = WebRequest.Create(url)
        request.Method = "POST"
        request.Headers.Add("Accept-Encoding", "gzip, deflate")
        request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8"
        request.ContentLength = data.Length
        request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate

        ' Set request settings
        request.Headers(HttpRequestHeader.Cookie) = "remixsid=" & _session.Guid & ";"
        Dim buffer() As Byte = System.Text.Encoding.UTF8.GetBytes(data)
        Using rs As Stream = request.GetRequestStream
            rs.Write(buffer, 0, buffer.Length)
        End Using

        Dim result = String.Empty

        ' Get response
        Using response As HttpWebResponse = request.GetResponse
            Using _
                responseStream =
                    New StreamReader(response.GetResponseStream, System.Text.Encoding.GetEncoding("utf-8"))
                result = responseStream.ReadToEnd
            End Using
        End Using

        Return result
    End Function

#End Region

#Region "Private helpers"

    Private Function MapBitrate(ByVal bitrate As Integer)
        Dim mappings() As Integer = {8, 16, 24, 32, 40, 48, 56, 64, 80, 96, 112, 128, 144, 160, 192, 224, 256, 320}
        For Each map As Integer In mappings
            If (bitrate * 0.9) < map And (bitrate * 1.1) > map Then
                Return map
            End If
        Next
        Return bitrate
    End Function

    Private Sub LoadScript()
        _engine.Evaluate(My.Resources.vk)
    End Sub

#End Region

#Region "Public properties"

    Public ReadOnly Property IsLoggedIn() As Boolean
        Get
            Return _session IsNot Nothing AndAlso _session.IsLoggedIn
        End Get
    End Property

#End Region

#Region "Public subclasses"

    Public Class Song
        Public RowId As Integer = 0
        Public Quantity As Integer = 1
        Public Artist As String = "-"
        Public Title As String = "-"
        Public Duration As Integer = 0
        Public Size As Integer = 0
        Public Bitrate As Integer = 0
        Public Url As String = "-"
    End Class

#End Region
End Class
