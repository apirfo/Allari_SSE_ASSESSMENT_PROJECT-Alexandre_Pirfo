$(document).ready(function () {
    setInterval(function time(){
        let dateNow = new Date();

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

function delay(time) {
    return new Promise(resolve => setTimeout(resolve, time));
}

function updateData() {
    $("#propertiesTableContainer").css("display", "none");
    $("#loaingPropertiesTableData").css("display", "block");
    $.get("/home/updatedata", async function (data) {
        console.log(data);

        await delay(1000);

        if (data && Array.isArray(data) && data.length > 0) {
            const tableElement = $("#propertiesTableBody");
            tableElement.empty();

            data.forEach(property => {
                var newTableRow = $("<tr></tr>");
                newTableRow.append($("<td></td>").text(property.name));
                newTableRow.append($("<td></td>").text(property.owner.name));
                newTableRow.append($("<td></td>").text(property.owner.phone));
                newTableRow.append($("<td></td>").text(property.owner.email));
                newTableRow.append($("<td></td>").text(property.province + ", " + property.state + ", " + property.country));
                tableElement.append(newTableRow);
            });

            $("#loaingPropertiesTableData").css("display", "none");
            $("#propertiesTableContainer").css("display", "block");
        }

        
        

        
    })
}