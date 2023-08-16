Public Class AddressViewModel
    Public Sub New()
        AddressLookupModel = New AddressLookupModel
        AddressModel = New AddressModel
    End Sub
    Public Property AddressLookupModel As AddressLookupModel
    Public Property AddressModel As AddressModel
End Class
