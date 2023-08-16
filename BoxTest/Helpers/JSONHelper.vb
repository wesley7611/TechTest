Imports Newtonsoft.Json

Public Class JSONHelper
    Const testAddress As String = "{""postcode"":""B23 5HA"",""latitude"":52.53572845458984,""longitude"":-1.854326844215393,""formatted_address"":[""18 Chipstead Road"","""","""",""Birmingham"",""West Midlands""],""thoroughfare"":""Chipstead Road"",""building_name"":"""",""sub_building_name"":"""",""sub_building_number"":"""",""building_number"":""18"",""line_1"":""18 Chipstead Road"",""line_2"":"""",""line_3"":"""",""line_4"":"""",""locality"":"""",""town_or_city"":""Birmingham"",""county"":""West Midlands"",""district"":""Birmingham"",""country"":""England"",""residential"":true}"

    Public Shared Function DeserialiseSelectedAddresses(ByVal JSONAddress As String) As AddressModel
        ' JSONAddress = testAddress ' to remove after testing
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
