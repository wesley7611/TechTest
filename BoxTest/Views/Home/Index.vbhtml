@ModelType AddressModel
@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    <p><a href="https://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Getting started</h2>
        <p><a class="btn btn-default" href="@Url.Action("AutoCompleteAddress", "Address")">Address Lookup</a></p>
        <p>
            @Html.DropDownListFor(Function(Model) Model.BuildingName, Model.AddressSuggestions, New With {.class = "form control AutoPostBack"})
            @Html.TextBoxFor(Function(Model) Model.AddressPartial, New With {.class = "form-control", .maxlength = 255})
            <input type="submit" name="response" value="Accept" formaction=@Url.Action("TermsAccept") formmethod="post" class="btn btn-primary">Find Address
        </p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
    </div>
</div>
