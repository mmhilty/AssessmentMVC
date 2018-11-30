
$(document).ready(function () {
    hideGuestChoiceFoodChoiceFunction();
    hideGuestNameFunction();
    hideFoodDescriptionFunction();
})



function showGuestChoiceFoodChoiceFunction() {
    document.getElementById("guestchoice").style.display = "block";
    document.getElementById("dishchoice").style.display = "block";
    document.getElementById("datechoice").style.display = "block";
}
function hideGuestChoiceFoodChoiceFunction() {
    document.getElementById("guestchoice").style.display = "none";
    document.getElementById("dishchoice").style.display = "none";
    document.getElementById("datechoice").style.display = "none";
}

function showGuestNameFunction() {
    document.getElementById("guestnameinput").style.display = "block";
}
function hideGuestNameFunction() {
    document.getElementById("guestnameinput").style.display = "none";
}

function showFoodDescriptionFunction() {
    document.getElementById("dishdecriptioninput").style.display = "block";
}
function hideFoodDescriptionFunction() {
    document.getElementById("dishdecriptioninput").style.display = "none";
}

function submitAllForms() {
    document.getElementById("attendchoiceid").submit();
    document.getElementById("guestchoice").submit();
    document.getElementById("datechoice").submit();
    document.getElementById("guestnameinput").submit();
    document.getElementById("dishchoice").submit();
    document.getElementById("dishdecriptioninput").submit();

}

function makeAUser(userObj) {
    var attendeeInstance = Object.create('@Model.');


}