var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
connection.on("ReceiveMessage", function (message) {
    var div = document.createElement("div");
    div.classList.add("alert", "alert-primary", "my-2");
    document.getElementById("OrderList").appendChild(div);
    div.textContent = `${message}`;
    
});
connection.start().then(function () {
    const order = document.getElementById('orderId').value;
    connection.invoke("AddToGroup", "orderId_"+order).catch(function (err) {
        return console.error(err.toString());
    });
}).catch(function (err) {
    return console.error(err.toString());
});