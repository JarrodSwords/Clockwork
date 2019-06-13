var Clockwork = Clockwork || {};

Clockwork.TimezonesService = (() => {
    var getTimezones = callback => {
        makeRequest("timezones", callback);
    };

    var getServerTime = (timezoneId, callback) => {
        makeRequest(`servertime/${timezoneId}`, callback);
    };

    return {
        getTimezones,
        getServerTime
    };
})();
