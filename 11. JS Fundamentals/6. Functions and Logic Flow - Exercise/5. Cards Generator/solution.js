function solve() {
    let from = document.getElementById('from');
    let to = document.getElementById('to');
    let cards = document.getElementById("cards");

    let select = document.getElementsByTagName("select")[0];
    let button = document.getElementsByTagName('button')[0];

    button.addEventListener("click", function() {
        let start = 0;
        if (from.value.toLowerCase() == "j") {
            start = 11;
        }
        else if (from.value.toLowerCase() == "q") {
            start = 12;
        }
        else if (from.value.toLowerCase() == "k") {
            start = 13;
        }
        else if (from.value.toLowerCase() == "a") {
            start = 14;
        }
        else {
            start = Number(from.value);
        }

        let end = 0;

        if (to.value.toLowerCase() == "j") {
            end = 11;
        }
        else if (to.value.toLowerCase() == "q") {
            end = 12;
        }
        else if (to.value.toLowerCase() == "k") {
            end = 13;
        }
        else if (to.value.toLowerCase() == "a") {
            end = 14;
        }
        else {
            end = Number(to.value);
        }

        let options = select.children;

        let selectedOption = [...options].filter(function(x) { return x.selected })[0];

        let suit = selectedOption.innerHTML.split(" ")[1];

        for (let i = start; i <= end; i++) {
            let card = document.createElement('div');
            card.classList.add("card");
            let suitp = document.createElement("p");
            suitp.innerHTML = suit;
            let valuep = document.createElement("p");

            if (i == 11) {
                valuep.innerHTML = "J";
            }
            else if (i == 12) {
                valuep.innerHTML = "Q";
            }
            else if (i == 13) {
                valuep.innerHTML = "K";
            }
            else if (i == 14) {
                valuep.innerHTML = "A";
            }
            else {
                valuep.innerHTML = i;
            }

            card.appendChild(suitp);
            card.appendChild(valuep);
            card.appendChild(suitp.cloneNode(true));

            cards.appendChild(card);
        }
    });
}