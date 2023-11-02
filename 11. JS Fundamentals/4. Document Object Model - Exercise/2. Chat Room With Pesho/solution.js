function solve() {
    let meButton = document.getElementsByTagName("button")[0];
    let peshoButton = document.getElementsByTagName("button")[1];
    let chatWindow = document.getElementById("chatChronology");

    let meText = document.getElementsByTagName("input")[0];
    let peshoText = document.getElementsByTagName("input")[1];

    meButton.addEventListener("click", function() {
        let div = document.createElement("div");
        let span = document.createElement("span");
        let p = document.createElement("p");

        span.innerHTML = "Me";
        p.innerHTML = meText.value;

        div.appendChild(span);
        div.appendChild(p);

        div.style.textAlign = "left";

        chatWindow.appendChild(div);

        meText.value = "";
    });

    peshoButton.addEventListener("click", function() {
        let div = document.createElement("div");
        let span = document.createElement("span");
        let p = document.createElement("p");

        span.innerHTML = "Pesho";
        p.innerHTML = peshoText.value;

        div.appendChild(span);
        div.appendChild(p);

        div.style.textAlign = "right";

        chatWindow.appendChild(div);

        peshoText.value = "";
    });
}