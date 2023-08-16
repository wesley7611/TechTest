Imports Newtonsoft.Json

Public Class JSONHelper

    Public Shared Function DeserialiseSelectedAddresses(ByVal JSONAddress As String) As AddressModel
        Return JsonConvert.DeserializeObject(Of AddressModel)(JSONAddress)
    End Function
    Public Shared Function DeserialiseSuggestedAddresses(ByVal JSONAddress As String) As List(Of SelectListItem)
        Dim SuggestedAddresses As List(Of AddressSuggestionCollection.Suggestion) = JsonConvert.DeserializeObject(Of AddressSuggestionCollection)(JSONAddress).Suggestions
        Dim SuggestedAddressListItems As New List(Of SelectListItem)
        For Each Suggestion In SuggestedAddresses
            SuggestedAddressListItems.Add(New SelectListItem() With {.Text = Suggestion.Address, .Value = Suggestion.ID})
        Next
        Return SuggestedAddressListItems
    End Function
    Public Shared Function DeserialiseCaptchaResponse(ByVal JSONAddress As String) As Recaptcha
        Dim RecaptchaResponse As Recaptcha = JsonConvert.DeserializeObject(Of Recaptcha)(JSONAddress)
        Return RecaptchaResponse
    End Function
End Class
