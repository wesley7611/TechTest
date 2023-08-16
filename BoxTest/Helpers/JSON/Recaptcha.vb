Imports Newtonsoft.Json

<Serializable>
Public Class Recaptcha
    <JsonProperty("success")>
    Property Success As Boolean
    <JsonProperty("error-codes")>
    Property ErrorCodes As List(Of String)
End Class
