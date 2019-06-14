function CurrentTimeQuery({ id, time, clientIp, utcTime, timezone, convertedTime }) {
    var DATETIME_FORMAT = "YYYY-MM-DD HH:mm:ss";

    this.id = id;
    this.time = moment(time).format(DATETIME_FORMAT);
    this.clientIp = clientIp;
    this.utcTime = moment(utcTime).format(DATETIME_FORMAT);
    this.timezoneId = timezone === null
        ? null
        : timezone.id;
    this.convertedTime = moment(convertedTime).format(DATETIME_FORMAT);
}
