Imports Newtonsoft.Json

<Serializable>
Public Class AddressSuggestionCollection

    <JsonProperty("suggestions")>
    Public Property Suggestions As List(Of Suggestion)

    <Serializable>
    Public Class Suggestion
        <JsonProperty("address")>
        Public Property Address As String
        <JsonProperty("url")>
        Public Property Url As String
        <JsonProperty("id")>
        Public Property ID As String
    End Class

End Class
