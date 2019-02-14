var paypal = require('paypal-checkout');
var client = require('braintree-web/client');
var paypalCheckout = require('braintree-web/paypal-checkout');

var renderPayPalButton = function () {
    paypal.Button.render({
        braintree: braintree,
        // Other configuration
    }, '#PayPal-Button');
};