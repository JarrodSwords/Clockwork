var Clockwork = Clockwork || {};

Clockwork.CurrentTimeQueriesService = (() => {
    var getCurrentTime = callback => {
        makeRequest("currenttime", callback);
    };

    var getCurrentTimeQueries = callback => {
        makeRequest("currenttimequeries", callback);
    };

    return {
        getCurrentTime,
        getCurrentTimeQueries
    };
})();
