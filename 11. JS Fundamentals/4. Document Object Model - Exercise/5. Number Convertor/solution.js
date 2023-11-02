function solve() {
    var select = document.getElementById("selectMenuTo");

    window.addEventListener("DOMContentLoaded", function() {
        select.children[0].disabled = true;
        select.children[0].hidden = true;

        var option = this.document.createElement("option");
        option.value = "binary";
        option.innerHTML = "Binary";

        select.appendChild(option);

        var option2 = this.document.createElement("option");
        option2.value = "headecimal";
        option2.innerHTML = "Hexadecimal";

        select.appendChild(option2);
    });
    
    let result = document.getElementById("result");

    let number = document.getElementById("input");

    let button = document.getElementsByTagName("button")[0];

    button.addEventListener("click", function() {
        if ([...select.children].filter(function (x) { return x.selected })[0].value == "binary") {
            result.value = Number(number.value).toString(2);
        }
        else {
            result.value = Number(number.value).toString(16);
        }
    });
}