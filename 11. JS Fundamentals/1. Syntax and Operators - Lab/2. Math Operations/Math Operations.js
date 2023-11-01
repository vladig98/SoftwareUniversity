function MathOperations(num1, num2, sign) {
    let number1 = Number(num1);
    let number2 = Number(num2);

    let result = 0;
    
    switch (sign) {
        case "+":
            result = number1 + number2;
            break;
        case "-":
            result = number1 - number2;
            break;
        case "*":
            result = number1 * number2;
            break;
        case "/":
            result = number1 / number2;
            break;
        case "%":
            result = number1 % number2;
            break;
        case "**":
            result = number1 ** number2;
            break;
        default:
            break;
    }

    console.log(result);
}