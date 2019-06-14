function CurrentTimeQuery({ id, time, clientIp, utcTime, timezone, convertedTime }) {
    var BASE_DATETIME_FORMAT = "YYYY-MM-DD HH:mm:ss",
        TIMEZONE_FORMAT = `${BASE_DATETIME_FORMAT} Z`;

    this.id = id;
    this.time = moment(time).format(TIMEZONE_FORMAT);
    this.clientIp = clientIp;
    this.utcTime = moment(utcTime).format(BASE_DATETIME_FORMAT);
    this.timezoneId = timezone === null
        ? null
        : timezone.id;
    this.convertedTime = moment(convertedTime).format(BASE_DATETIME_FORMAT);
}
