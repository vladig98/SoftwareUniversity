function FunctionalCalculating(num1, num2, operator) {
    let addition = function(num1, num2) {
        return num1 + num2;
    }
    let subtraction = function(num1, num2) {
        return num1 - num2;
    }    
    let multiplication = function(num1, num2) {
        return num1 * num2;
    }
    let division = function(num1, num2) {
        return num1 / num2;
    }

    switch (operator)
    {
        case "+":
            console.log(addition(num1, num2));
            break;
        case "-":
            console.log(subtraction(num1, num2));
            break;
        case "*":
            console.log(multiplication(num1, num2));
            break;
        case "/":
            console.log(division(num1, num2));
            break;
        default:
            break;
    }
}

