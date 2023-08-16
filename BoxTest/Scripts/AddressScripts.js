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
$(document).ready(function () {
    $(document).ready(function () {
        $('#btnAddressSearch').click(function (event) {
            var recaptchaResponse = grecaptcha.getResponse();
            $('.recaptchaResponse').val(recaptchaResponse);
        });
    });
});

document.addEventListener("DOMContentLoaded", function () {
    const menuToggle = document.querySelector(".menu-toggle");
    const nav = document.querySelector("nav");

    menuToggle.addEventListener("click", function () {
        nav.classList.toggle("active");
    });
});
document.addEventListener("DOMContentLoaded", function () {
    const manualAddressCheckbox = document.getElementById("manualAddressOption");
    const addressTextboxes = document.querySelectorAll(".address-line input[type='text']");

    // Set textboxes to be read-only by default
    addressTextboxes.forEach(textbox => {
        textbox.readOnly = true;
    });

    manualAddressCheckbox.addEventListener("change", function () {
        const isManualAddress = manualAddressCheckbox.checked;

        addressTextboxes.forEach(textbox => {
            textbox.readOnly = !isManualAddress;
        });
    });
});
window.addEventListener("DOMContentLoaded", function () {
    const labelInputs = document.querySelectorAll(".label-placeholder");

    function updatePlaceholders() {
        if (window.innerWidth < 768) {
            labelInputs.forEach((labelInput) => {
                const label = labelInput.getAttribute("data-label");
                labelInput.placeholder = label; // 
                labelInput.parentNode.querySelector("label").classList.add("hidden-label"); // Hide the corresponding label
            });
        } else {
            labelInputs.forEach((labelInput) => {
                labelInput.placeholder = ""; 
                labelInput.parentNode.querySelector("label").classList.remove("hidden-label"); // Show the corresponding label
            });
        }
    }

    updatePlaceholders();

    window.addEventListener("resize", updatePlaceholders);
});
