function getBrowserType(eventToBeHandled, arguments) { // arguments are not used, but i leave them, cause this is the idea of the exercise
    var currentWindow = window;
    var browser = currentWindow.navigator.appCodeName;
    var isMozilla = browser === "Mozilla";
    if (isMozilla) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
