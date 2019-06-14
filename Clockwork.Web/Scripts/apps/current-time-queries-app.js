var app = new Vue({
    el: "#app",
    data: {
        queries: [],
        timezoneOptions: [],
        selectedTimezone: null
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

var populateTimezoneOptions = data => {
    data.forEach(timezone => {
        app.timezoneOptions.push(new TimezoneOption(timezone));
    });

    // select initial timezone
    app.selectedTimezone = app.timezoneOptions.length > 0
        ? app.timezoneOptions[0].value
        : null;
};

var getCurrentTime = () => {
    Clockwork.CurrentTimeQueriesService.getCurrentTime(null, appendQuery);
};

var getCurrentTimeForTimezone = () => {
    Clockwork.CurrentTimeQueriesService.getCurrentTime(app.selectedTimezone, appendQuery);
};

Clockwork.CurrentTimeQueriesService.getCurrentTimeQueries(populateQueries);
Clockwork.TimezonesService.getTimezones(populateTimezoneOptions);
