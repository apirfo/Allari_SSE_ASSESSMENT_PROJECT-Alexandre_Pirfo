$(document).ready(function () {
    setInterval(function time(){
        let dateNow = new Date();

        console.log('oi');

        $("#clockHeaderHours").html(dateNow.getHours().toLocaleString('en-US', { minimumIntegerDigits: 2, useGrouping: false }));
        $("#clockHeaderMinuts").html(dateNow.getMinutes().toLocaleString('en-US', { minimumIntegerDigits: 2, useGrouping: false }));
        $("#clockHeaderSeconds").html(dateNow.getSeconds().toLocaleString('en-US', { minimumIntegerDigits: 2, useGrouping: false }));
    });

});

let mousePos = { x: undefined, y: undefined };

window.addEventListener('mousemove', (event) => {
    mousePos = { x: event.clientX, y: event.clientY };
    $("#mouseXPosition").html(mousePos.x);
    $("#mouseYPosition").html(mousePos.y);
});