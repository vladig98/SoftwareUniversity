function validate() {
    let response = document.getElementById('response');
    let input = document.getElementsByTagName('input')[0];
    let button = document.getElementsByTagName('button')[0];

    let weights = [2, 4, 8, 5, 10, 9, 7, 3, 6];

    button.addEventListener("click", function() {
        if (input.value.length == 10) {
            let arr = input.value.split('');

            let sum = 0;
            for (let i = 0; i < arr.length - 1; i++) {
                sum += Number(arr[i]) * weights[i];
            }

            if (arr[arr.length - 1] == (sum % 11) % 10) {
                response.innerHTML = "This number is Valid!";
            }
            else {
                response.innerHTML = "This number is NOT Valid!";
            }
        }
        else {
            response.innerHTML = "This number is NOT Valid!";
        }
    });
}