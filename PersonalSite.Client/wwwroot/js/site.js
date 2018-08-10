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

window.homeFunctions(){
    LoadHome: function() {
        $('#DateTimeContainer').hide();
        document.body.style.overflow = 'hidden';

        var weddingDate = new Date("2018-10-19T17:30").getTime();

        var x = setInterval(function () {

            var now = new Date().getTime();
            var t = weddingDate - now;
            var days = Math.floor(t / (1000 * 60 * 60 * 24));
            var hours = Math.floor((t % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            var minutes = Math.floor((t % (1000 * 60 * 60)) / (1000 * 60));
            var seconds = Math.floor((t % (1000 * 60)) / 1000);

            if (seconds < 10) {
                seconds = '0' + seconds;
            }
            //document.getElementById('Countdown').innerHTML =  `${days} : ${hours} : ${minutes} : ${seconds}`

            document.getElementById('Days').innerHTML = days;
            document.getElementById('Hours').innerHTML = hours;
            document.getElementById('Minutes').innerHTML = minutes;
            document.getElementById('Seconds').innerHTML = seconds;

            $('#LoadingSpinner').fadeOut(2);
            $('#DateTimeContainer').show();

        }, 1000);

        var showHome = function () {
            document.body.style.overflow = 'hidden';

            $('#HomeContainer').show();

            $('#RegistryContainer').hide();
            $('#WeddingDetailsContainer').hide();
        }

        var showRegistry = function () {
            $('#RegistryContainer').show();

            $('#HomeContainer').hide();
            $('#WeddingDetailsContainer').hide();
        };

        var showDetails = function () {
            document.body.style.overflow = 'scroll';
            // $('#DetailsLinkContainer>a').addClass('selected');
            // $('#RegistryLinkContainer>a').removeClass('selected');

            $('#WeddingDetailsContainer').show();
            $('#HomeContainer').hide();
            $('#RegistryContainer').hide();
        }

        $(document).ready(function () {
            $('#WeddingDetailsContainer').hide();
            $('#RegistryContainer').hide();
        });
    }
}