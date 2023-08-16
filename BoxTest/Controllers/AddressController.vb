Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Web.Mvc
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json

Namespace Controllers
    Public Class AddressController
        Inherits Controller

        Dim Model As New AddressViewModel

        ' GET: Address
        Function Index() As ActionResult
            Return View(Model)
        End Function
        <HttpPost()>
        Function Index(Model As AddressModel) As ActionResult
            Return View(Model)
        End Function

        <HttpPost>
        Public Async Function LookupAddress(AddressLookupModel As AddressLookupModel) As Threading.Tasks.Task(Of ActionResult)
            Dim response As HttpResponseMessage
            Dim Success As Boolean

            Success = Await APIHelper.RecaptchaValidation(AddressLookupModel.RecaptchaResponse)
            If Not Success Then
                Model.AddressLookupModel.LookupError = "Captcha validation required"
                Return View("Index", Model) ' do not continue lookup
            End If

            response = Await APIHelper.APIAddressLookupAsync(AddressLookupModel.AddressPartial)
            If response.IsSuccessStatusCode Then
                AddressLookupModel.AddressSuggestions = JSONHelper.DeserialiseSuggestedAddresses(Await response.Content.ReadAsStringAsync())
            Else
                AddressLookupModel.LookupError = $"Failed to look up address: {response.StatusCode} Error"
            End If

            Model.AddressLookupModel = AddressLookupModel
            Return View("Index", Model)
        End Function
        <HttpGet()>
        Async Function PopulateAddress(ByVal AddressId As String) As Threading.Tasks.Task(Of ActionResult)
            Dim response As HttpResponseMessage = Await APIHelper.APIGetAddressAsync(AddressId)
            If response.IsSuccessStatusCode Then
                Return Json(JSONHelper.DeserialiseSelectedAddresses(Await response.Content.ReadAsStringAsync()), JsonRequestBehavior.AllowGet)
            Else
                Model.AddressLookupModel.LookupError = $"Failed to look up address: {response.StatusCode} Error"
            End If
            Return View("Index", Model)
        End Function
    End Class
End Namespace