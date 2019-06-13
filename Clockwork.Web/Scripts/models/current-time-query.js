function CurrentTimeQuery({ currentTimeQueryId, time, clientIp, utcTime }) {
    var BASE_DATETIME_FORMAT = "YYYY-MM-DD HH:mm:ss";

    this.id = currentTimeQueryId;
    this.time = moment(time).format(`${BASE_DATETIME_FORMAT} Z`);
    this.clientIp = clientIp;
    this.utcTime = moment(utcTime).format(BASE_DATETIME_FORMAT);
}
