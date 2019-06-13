var makeRequest = (target, callback = () => { }, httpMethod) => {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var result = JSON.parse(this.responseText);
            callback(result);
        }
    };
    xhttp.open(httpMethod || "GET", target, true);
    xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.send();
};
