Imports Newtonsoft.Json

Public Class AddressModel
    <JsonProperty("postcode")>
    Public Property Postcode As String
    <JsonProperty("latitude")>
    Public Property Latitutde As Single
    <JsonProperty("longitude")>
    Public Property Longitude As Single
    <JsonProperty("formatted_address")>
    Public Property FormattedAddress As String()
    <JsonProperty("thoroughfare")>
    Public Property Thoroughfare As String
    <JsonProperty("building_name")>
    Public Property BuildingName As String
    <JsonProperty("sub_building_name")>
    Public Property SubBuildingName As String
    <JsonProperty("sub_building_number")>
    Public Property SubBuildingNumber As String
    <JsonProperty("building_number")>
    Public Property BuildingNumber As String
    <JsonProperty("line_1")>
    Public Property Line1 As String
    <JsonProperty("line_2")>
    Public Property Line2 As String
    <JsonProperty("line_3")>
    Public Property Line3 As String
    <JsonProperty("line_4")>
    Public Property Line4 As String
    <JsonProperty("locality")>
    Public Property Locality As String
    <JsonProperty("town_or_city")>
    Public Property TownOrCity As String
    <JsonProperty("county")>
    Public Property County As String
    <JsonProperty("district")>
    Public Property District As String
    <JsonProperty("country")>
    Public Property Country As String
    <JsonProperty("residential")>
    Public Property Residential As Boolean
End Class
