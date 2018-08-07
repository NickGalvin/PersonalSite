window.rsvpFunctions = {

    validateRsvp: function () {
        var isValid = true;

        Array.from(document.getElementsByClassName('attendee')).forEach(function (attendeeElement) {

            //Hide the messages and re-validate
            attendeeElement.querySelector('.attendance-message').innerHTML = "";
            attendeeElement.querySelector('.name-message').innerHTML = "";

            var nameElement = attendeeElement.querySelector('.name');

            //Remove class before re-validating. If still not correct it will show the error again.
            nameElement.classList.remove('border-danger');

            if (nameElement.value.trim() === '') {
                nameElement.classList.add('border-danger');
                var nameLabel = attendeeElement.querySelector('.name-label');
                attendeeElement.querySelector('.name-message').innerHTML = "Name is Required";


                isValid = false;
            }

            var attendanceSelect = attendeeElement.querySelector('.attendance');

            //Remove class before re-validating. If still not correct it will show the error again.
            attendanceSelect.classList.remove('border-danger');

            if (attendanceSelect.selectedIndex === 0) {

                attendanceSelect.classList.add('border-danger');
                attendeeElement.querySelector('.attendance-message').innerHTML = "Please Select a Valid Response";
                isValid = false;
            }

            return isValid;
        })
    },

    showSpinner: function () {
        $('#RsvpForm').hide();
        $('#LoadingSpinner').show();
    },

    hideSpinner: function () {
        $('#RsvpForm').show();
        $('#LoadingSpinner').hide();
    },

    showSuccess: function () {
        prompt('RSVP Submitted! See you at the reception!')
    },


    initializeTable: function () {
        $('#RsvpTable').DataTable();
    }
}