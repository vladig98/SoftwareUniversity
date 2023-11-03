function getNext() {
    let num = document.getElementById('num');
    let result = document.getElementById('result');

    let number = Number(num.value);
    result.innerHTML = "";
    result.innerHTML += number + " ";

    while (number > 1) {
        if (number % 2 == 0) {
            number /= 2;
        }
        else {
            number *= 3;
            number++;
        }

        result.innerHTML += number + " ";
    }
}