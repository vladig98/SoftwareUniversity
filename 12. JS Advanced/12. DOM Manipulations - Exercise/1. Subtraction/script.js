function subtract() {
    let firstNumber = document.getElementById('firstNumber');
    let secondNumber = document.getElementById('secondNumber')
    let result = document.getElementById('result');

    result.innerHTML = Number(firstNumber.value) - Number(secondNumber.value)
}