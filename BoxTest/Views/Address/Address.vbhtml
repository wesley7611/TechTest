@ModelType BoxTest.AddressModel

<div class="address-container">
    <div class="address-lines">
        <div class="address-line">
            <label>Address Line 1</label>
            @Html.TextBoxFor(Function(Model) Model.Line1, New With {.class = "label-placeholder", .data_label = "Address Line 1", .maxlength = 255})
        </div>
        <div class="address-line">
            <label>Address Line 2</label>
            @Html.TextBoxFor(Function(Model) Model.Line2, New With {.class = "label-placeholder", .data_label = "Address Line 2", .maxlength = 255})
        </div>
        <div class="address-line">
            <label>Address Line 3</label>
            @Html.TextBoxFor(Function(Model) Model.Line3, New With {.class = "label-placeholder", .data_label = "Address Line 3", .maxlength = 255})
        </div>
        <div class="address-line">
            <label>Address Line 4</label>
            @Html.TextBoxFor(Function(Model) Model.Line4, New With {.class = "label-placeholder", .data_label = "Address Line 4", .maxlength = 255})
        </div>
        <div class="address-line">
            <label>Town/City</label>
            @Html.TextBoxFor(Function(Model) Model.TownOrCity, New With {.class = "label-placeholder", .data_label = "Town/City", .maxlength = 255})
        </div>
        <div class="address-line">
            <label>County</label>
            @Html.TextBoxFor(Function(Model) Model.County, New With {.class = "label-placeholder", .data_label = "County", .maxlength = 255})
        </div>
        <div class="address-line">
            <label>Country</label>
            @Html.TextBoxFor(Function(Model) Model.Country, New With {.class = "label-placeholder", .data_label = "Country", .maxlength = 255})
        </div>
        <div class="address-line">
            <label>Postcode</label>
            @Html.TextBoxFor(Function(Model) Model.Postcode, New With {.class = "label-placeholder", .data_label = "Postcode", .maxlength = 255})
        </div>
    </div>
</div>
