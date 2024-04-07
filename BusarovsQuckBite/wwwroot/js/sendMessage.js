var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
document.getElementById("sendButton").disabled = true;
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});
document.getElementById("sendButton").addEventListener("click", function (event) {
    var orderId = document.getElementById("orderId").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", message, orderId).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});