var CLOCKWORK_API_ROOT = "http://127.0.0.1:5000/api";

var makeRequest = (target, callback = () => { }, httpMethod, apiRoot, body) => {
    apiRoot = apiRoot || CLOCKWORK_API_ROOT;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var result = JSON.parse(this.responseText);
            callback(result);
        }
    };
    xhttp.open(httpMethod || "GET", `${apiRoot}/${target}`, true);
    xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.send(body);
};
