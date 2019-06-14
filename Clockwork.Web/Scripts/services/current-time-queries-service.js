var Clockwork = Clockwork || {};

Clockwork.CurrentTimeQueriesService = (() => {
    var getCurrentTime = (timezoneId, callback) => {
        var body = timezoneId
            ? JSON.stringify({ timezoneId })
            : null;

        makeRequest(
            "currenttime",
            callback,
            body ? "POST" : null,
            null,
            body
        );
    };

    var getCurrentTimeQueries = callback => {
        makeRequest("currenttimequeries", callback);
    };

    return {
        getCurrentTime,
        getCurrentTimeQueries
    };
})();
