//Populates address details from selected dropdown option
$(document).ready(function () {
    $('#addressSelect').change(function () {
        var selectedValue = $(this).val();

        $.ajax({
            type: 'GET',
            url: '/Address/PopulateAddress',
            data: { 'addressId': selectedValue },
            dataType: 'json',
            success: function (updatedModel) {
                $('#BuildingName').val(updatedModel.BuildingName);
                $('#BuildingNumber').val(updatedModel.BuildingNumber);
                $('#Line1').val(updatedModel.Line1);
                $('#Line2').val(updatedModel.Line2);
                $('#Line3').val(updatedModel.Line3);
                $('#Line4').val(updatedModel.Line4);
                $('#TownOrCity').val(updatedModel.TownOrCity);
                $('#County').val(updatedModel.County);
                $('#Country').val(updatedModel.Country);
                $('#Postcode').val(updatedModel.Postcode);
            },
            error: function (error) {
                console.error('Error:', error);
            }
        });
    });
});

//binds recaptcha response to model view to pass to controller
$(document).ready(function () {
    $(document).ready(function () {
        $('#btnAddressSearch').click(function (event) {
            var recaptchaResponse = grecaptcha.getResponse();
            $('.recaptchaResponse').val(recaptchaResponse);
        });
    });
});

//set if text boxes can be manually edited based on manual address setting
document.addEventListener("DOMContentLoaded", function () {
    const manualAddressCheckbox = document.getElementById("manualAddressOption");
    const addressTextboxes = document.querySelectorAll(".address-line input[type='text']");

    // Set textboxes to be read-only by default
    addressTextboxes.forEach(textbox => {
        textbox.readOnly = true;
    });
    //when manual address option is changed, update textbox read-only status
    manualAddressCheckbox.addEventListener("change", function () {
        const isManualAddress = manualAddressCheckbox.checked;

        addressTextboxes.forEach(textbox => {
            textbox.readOnly = !isManualAddress;
        });
    });
});

//Drop down for nav menu
document.addEventListener("DOMContentLoaded", function () {
    const menuToggle = document.querySelector(".menu-toggle");
    const nav = document.querySelector("nav");

    menuToggle.addEventListener("click", function () {
        nav.classList.toggle("active");
    });
});

//Hide address labels and set placeholders for mobile view
window.addEventListener("DOMContentLoaded", function () {
    const labelInputs = document.querySelectorAll(".label-placeholder");

    //create function to show/hide labels and placeholders
    function updatePlaceholders() {
        if (window.innerWidth < 768) {
            labelInputs.forEach((labelInput) => {
                const label = labelInput.getAttribute("data-label");
                labelInput.placeholder = label; //set placeholder 
                labelInput.parentNode.querySelector("label").classList.add("hidden-label"); // Hide the corresponding label
            });
        } else {
            labelInputs.forEach((labelInput) => {
                labelInput.placeholder = ""; //remove placeholder
                labelInput.parentNode.querySelector("label").classList.remove("hidden-label"); // Show the corresponding label
            });
        }
    }

    //call on load
    updatePlaceholders();

    //add listener to call on resize of window for reactive display
    window.addEventListener("resize", updatePlaceholders);
});
