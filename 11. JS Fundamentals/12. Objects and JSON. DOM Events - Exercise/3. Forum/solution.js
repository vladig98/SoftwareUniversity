function solve() {
    let inputs = document.getElementsByTagName("input");
    let usernameInput = inputs[0];
    let emailInput = inputs[2];
    let searchInput = inputs[7];

    let checkboxes = document.querySelectorAll("input[type='checkbox']");

    let buttons = document.getElementsByTagName("button");
    let submitButton = buttons[0];
    let searchButton = buttons[1];

    let table = document.getElementsByTagName("table")[0];

    submitButton.addEventListener("click", function(event) {
        event.preventDefault();
        let tr = document.createElement("tr");
        let utd = document.createElement("td");
        utd.innerHTML = usernameInput.value;
        let etd = document.createElement("td");
        etd.innerHTML = emailInput.value;
        let ttd = document.createElement("td");
        ttd.innerHTML = [...checkboxes].filter(x => x.checked).map(x => x.value).join(" ");
        tr.appendChild(utd);
        tr.appendChild(etd);
        tr.appendChild(ttd);
        table.children[1].appendChild(tr);
    });

    searchButton.addEventListener("click", function(event) {
        event.preventDefault();
        let tr = table.children[1].children;

        for (let i = 0; i < tr.length; i++) {
            if (!tr[i].innerHTML.includes(searchInput.value)) {
                tr[i].style.visibility = "hidden";
            }
            else {
                tr[i].style.visibility = "visible";
            }
        }
    });
}