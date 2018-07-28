window.jsFunctions = {
    validateRsvpForm: function () {

        var isValid = true;

        $('.firstname').forEach(function (nameElement) {

            if (nameElement.val().trim() === '') {
                nameElement.addClass('validation-error');
                nameElement.append('Name Required');

                isValid = false;
            }

            return isValid;
        }
    }
}