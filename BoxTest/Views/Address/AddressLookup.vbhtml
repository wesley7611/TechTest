@ModelType BoxTest.AddressLookupModel

<div class="search-container">
    @Using (Html.BeginForm("LookupAddress", "Address", FormMethod.Post))
        @Code
            @<div Class="search-container">
                <div Class="search-box">
                    <div Class="search-input">
                        @Html.TextBoxFor(Function(Model) Model.AddressPartial, New With {.id = "textbox-with-button", .placeholder = "Search Postcode", .maxlength = 255})
                        <Button type="submit" value="Search" id="btnAddressSearch" Class="searchButton">Search</Button>
                    </div>
                    <div Class="address-dropdown">
                        @Html.DropDownListFor(Function(Model) Model.AddressID, Model.AddressSuggestions, New With {.class = "form-control", .id = "addressSelect"})
                    </div>
                </div>
                <div Class="captcha">
                    <div Class="g-recaptcha" data-sitekey="6LdfgygTAAAAAFR9LY0ewUWPbK-UTDQ037xQmiIb"></div>
                    @Html.TextBoxFor(Function(Model) Model.RecaptchaResponse, New With {.class = "recaptchaResponse"})
                </div>
                @If Model.LookupError IsNot Nothing Then
                    @<div class="error-message">
                        @Model.LookupError
                    </div>
                End If
            </div>
        End Code
    End Using

    <div Class="manual-address-option">
        <Label>
            <input type="checkbox" id="manualAddressOption">
            Manually Enter Address
        </Label>
    </div>
</div>