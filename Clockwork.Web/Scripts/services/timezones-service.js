var Clockwork = Clockwork || {};

Clockwork.TimezonesService = (() => {
    var getTimezones = callback => {
        makeRequest("timezones", callback);
    };

    return {
        getTimezones
    };
})();
