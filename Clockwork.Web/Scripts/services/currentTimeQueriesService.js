var Clockwork = Clockwork || {};

Clockwork.CurrentTimeQueriesService = (() => {
    var getCurrentTime = () => {
        makeRequest("http://127.0.0.1:5000/api/currenttime", data => {
            var query = new CurrentTimeQuery(data);
            app.currentTimeQueries.push(query);
        })
    };

    var getCurrentTimeQueries = () => {
        makeRequest("http://127.0.0.1:5000/api/currenttimequeries", data => {
            data.forEach(query => {
                app.currentTimeQueries.push(new CurrentTimeQuery(query));
            });
        })
    };

    return {
        getCurrentTime,
        getCurrentTimeQueries
    };
})();
