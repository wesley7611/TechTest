@ModelType AddressViewModel
@Code
    ViewData("Title") = "Home Page"
End Code
<div class="container">
    <h1>Select Address</h1>

    @Html.Partial("AddressLookup", Model.AddressLookupModel)
    @Html.Partial("Address", Model.AddressModel)
</div>
