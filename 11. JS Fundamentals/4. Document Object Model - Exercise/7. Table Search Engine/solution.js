function solve() {
    let tds = document.getElementsByTagName("td");
    let button = document.getElementById("searchBtn");
    let searchBox = document.getElementById("searchField");

    button.addEventListener("click", function() {
        let word = searchBox.value;

        for (let i = 0; i < tds.length; i++) {
            tds[i].parentElement.classList.remove("select");
        }

        for (let i = 0; i < tds.length; i++) {
            if (tds[i].innerHTML.toLowerCase().includes(word.toLowerCase())) {
                tds[i].parentElement.classList.add("select");
            }
        }
    });
}