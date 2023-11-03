function binarySearch() {
    let arr = document.getElementById('arr');
    let num = document.getElementById('num');
    let result = document.getElementById('result');

    let numbers = [...arr.value.split(", ")].sort().filter(Boolean).map(function(x) { return Number(x) });
    let number = Number(num.value);

    let end = numbers.length - 1;
    let start = 0;

    while (start <= end) {
        let m = Math.floor((start + end) / 2);

        if (numbers[m] < number) {
            start = m + 1;
        }
        else if (numbers[m] > number) {
            end = m - 1;
        }
        else {
            result.innerHTML = `Found number ${number} at index ${m}`;
            return;
        }
    }

    result.innerHTML = `The number ${number} is not in the array.`;
}