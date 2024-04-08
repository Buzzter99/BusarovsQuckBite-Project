var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
document.getElementById("sendButton").disabled = true;
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});
var initialOrderId = document.getElementById("orderId").value;
document.getElementById("sendButton").addEventListener("click", function (event) {
    var orderId = document.getElementById("orderId").value;
    var messageInput = document.getElementById("messageInput");
    var message = messageInput.value;
    if (!message.trim()) {
        alert("You must provide message for the user!");
        return;
    }
    if (orderId !== initialOrderId) {
        alert("Error occured.Please reload page and try again!");
        return;
    }
    connection.invoke("SendMessage", message, orderId).then(function () {
        messageInput.value = "";
        const element = document.createElement('div');
        element.textContent = 'Message Sent Successfully.';
        element.classList.add("alert", "alert-primary", "my-2");
        document.getElementById('SuccessMessage').appendChild(element);
    }).catch(function (err) {
        console.error("Error invoking SendMessage:", err.toString());
    });
    event.preventDefault();
});