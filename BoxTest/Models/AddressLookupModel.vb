Public Class AddressLookupModel
    Dim mAddressSugestions As List(Of SelectListItem)
    Public Sub New()
        mAddressSugestions = New List(Of SelectListItem)
    End Sub
    Public Property AddressSuggestions As List(Of SelectListItem)
        Get
            Return mAddressSugestions
        End Get
        Set(value As List(Of SelectListItem))
            mAddressSugestions = value
        End Set
    End Property
    Public Property AddressPartial As String
    Public Property AddressID As String
    Public Property RecaptchaResponse As String
    Public Property LookupError As String
End Class
