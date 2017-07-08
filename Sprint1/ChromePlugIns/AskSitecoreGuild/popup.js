// POST the data to the server using XMLHttpRequest
function askQuestion() {
    // Cancel the form submit
    event.preventDefault();

    // The URL to POST our data to
    var postUrl = 'http://localhost/AskSitecoreGuildServices/questions/Ask';

    // Set up an asynchronous AJAX POST request
    var xhr = new XMLHttpRequest();
    xhr.open('POST', postUrl, true);

    // Prepare the data to be POSTed by URLEncoding each field's contents
    var question = encodeURIComponent(document.getElementById('question').value);
    var vipId = encodeURIComponent(document.getElementById('vipId').innerText);

    var params = 'question=' + question +
                 '&vipId=' + vipId;

    // Replace any instances of the URLEncoded space char with +
    params = params.replace(/%20/g, '+');

    // Set correct header for form data 
    xhr.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');

    // Handle request state change events
    xhr.onreadystatechange = function () {
        // If the request completed
        if (xhr.readyState == 4) {
            statusDisplay.innerHTML = '';
            if (xhr.status == 200) {
                // If it was a success, display the answer
                statusDisplay.innerHTML = xhr.responseText;
            } else {
                // Show what went wrong
                statusDisplay.innerHTML = 'Error asking question: ' + xhr.statusText;
            }
        }
    };

    // Send the request and set status
    xhr.send(params);
    statusDisplay.innerHTML = 'Finding possible answers...';
}

// When the popup HTML has loaded
window.addEventListener('load', function (evt) {
    // Cache a reference to the status display SPAN
    statusDisplay = document.getElementById('status-display');
    // Handle the bookmark form submit event with our addBookmark function
    document.getElementById('askQuestion').addEventListener('submit', askQuestion);
});
