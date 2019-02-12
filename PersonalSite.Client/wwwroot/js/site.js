//window.waitForElementToDisplay = function (selector, time) {
//    console.log('waiting..');
//    if (document.querySelector(selector) !== null) {
//        alert("The element is displayed, you can put your code instead of this alert.")
//        return;
//    }
//    else {
//        setTimeout(function () {
//            waitForElementToDisplay(selector, time);
//        }, time);
//    }
//};

window.homeFunctions = {

    initializeSlideshow: function () {
        console.log('initializing slideshow');
        var timer = setInterval(myTimer, 1000);

        function myTimer() {
            console.log('waiting..');

            if (document.querySelector('.carousel-item') !== null) {
                console.log('found');
                slides();
                window.clearInterval(timer);
            }
        }

        function slides() {
            $('.carousel').carousel({
                interval: 3000
            });
        }
    }
};

window.auth = {

    getAccessToken: function () {
        return window.sessionStorage.getItem('jwt');
    },
    
    storeAccessToken: function(token) {
        console.log(token);

        window.sessionStorage.setItem("jwt", token);
    }
};