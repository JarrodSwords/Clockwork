var app = new Vue({
    el: "#current-time-queries",
    data: {
        queries: []
    }
});

var populateQueries = data => {
    data.forEach(query => {
        app.queries.push(new CurrentTimeQuery(query));
    });
};

var appendQuery = data => {
    var query = new CurrentTimeQuery(data);
    app.queries.push(query);
};

var getCurrentTime = () => {
    Clockwork.CurrentTimeQueriesService.getCurrentTime(appendQuery);
}

Clockwork.CurrentTimeQueriesService.getCurrentTimeQueries(populateQueries);
