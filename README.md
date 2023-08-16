# TechTest
Technical Test: Box

MVC project using .NET Framework - VB.NET

Single Address page with postcode entry box, address selection dropdown, ReCaptcha Validation, submit button and address form.

Also contains a nav menu, but this does not contain any active links

Submitting a postcode or partial address will populate the dropdown with a list of matching addresses

Selecting an option will populate the address form with the details of the selected address.

A checkbox will allow manual entry of the address. When chcked, the address form will no longer be read-only.

Page is adaptive display, and will change layout when resized to be viewed on smaller screens.

Server size makes use of APIs to lookup address and validate recaptcha. However, the serverside Recaptcha validation does not work, as it appears to need a private key to validate the client response. CLientside validation works, however.

