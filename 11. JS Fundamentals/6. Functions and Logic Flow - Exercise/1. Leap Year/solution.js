function leapYear() {
    let year = document.getElementById('year');
    let h2 = year.children[0];
    let div = year.children[1];

    let input = document.getElementsByTagName('input')[0];

    let button = document.getElementsByTagName('button')[0];

    button.addEventListener("click", function() {
        let y = Number(input.value);

        h2.innerHTML = ((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0) ? "Leap Year" : "Not Leap Year";
        div.innerHTML = y;
    });
}