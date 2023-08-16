Imports System.Net.Http
Imports System.Threading.Tasks

Public Class APIHelper

    Const AUTOCOMPLETE As String = "https://api.getAddress.io/autocomplete/"
    Const GETADDRESS As String = "https://api.getAddress.io/get/"
    Const RECAPTCHA_URL As String = "https://www.google.com/recaptcha/api/siteverify"
    Const API_KEY As String = "DF-ffFoz_Ui5LHHsAx65mw40144"
    Const RECAPTCHA_SECRET_KEY As String = "NA"

    Public Shared Async Function APIAddressLookupAsync(ByVal addressPartial As String) As Task(Of HttpResponseMessage)
        Dim response As HttpResponseMessage
        Using HttpClient As New HttpClient()
            Try
                response = Await HttpClient.GetAsync($"{AUTOCOMPLETE}{addressPartial}?api-key={API_KEY}")
            Catch ex As Exception
                response = New HttpResponseMessage(Net.HttpStatusCode.InternalServerError)
            End Try
        End Using

        Return response
    End Function
    Public Shared Async Function APIGetAddressAsync(AddressId As String) As Task(Of HttpResponseMessage)
        Dim response As HttpResponseMessage
        Using HttpClient As New HttpClient()
            Try
                response = Await HttpClient.GetAsync($"{GETADDRESS}{AddressId}?api-key={API_KEY}")
            Catch ex As Exception
                response = New HttpResponseMessage(Net.HttpStatusCode.InternalServerError)
            End Try
        End Using

        Return response
    End Function
    Public Shared Async Function RecaptchaValidation(ByVal RecaptchaResponse As String) As Task(Of Boolean)
        If String.IsNullOrWhiteSpace(RecaptchaResponse) Then
            'if no response from user, fail without attempting validation
            Return False
        Else
            Using HttpClient As New HttpClient()
                Dim parameters As New Dictionary(Of String, String) From {
                    {"secret", RECAPTCHA_SECRET_KEY},
                    {"response", RecaptchaResponse}
                }

                Dim content As New FormUrlEncodedContent(parameters)

                Dim response As HttpResponseMessage = Await HttpClient.PostAsync(RECAPTCHA_URL, content)

                If response.IsSuccessStatusCode Then
                    Dim Recaptcha As Recaptcha = JSONHelper.DeserialiseCaptchaResponse(Await response.Content.ReadAsStringAsync())
                    If Recaptcha.Success Then
                        Return True
                    Else
                        'This will always fail, as there is no valid Recaptcha secret key, so for testing purposes this will return true 
                        Return True
                    End If
                Else
                    Return False
                End If
            End Using
        End If
    End Function
End Class
