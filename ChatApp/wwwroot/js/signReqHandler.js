﻿
var connection = new signalR.HubConnectionBuilder().withUrl('/Home/Index').build();

connection.on('receiveMessage', addMessageToChat);

connection.start().catch(error => {
    console.error(error);
});

function sendMessageToHub(message) {
    connection.invoke('sendMessage', message);
}
