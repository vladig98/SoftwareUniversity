function greatestCD() {
    let num1 = document.getElementById('num1');
    let num2 = document.getElementById('num2');
    let result = document.getElementById('result');

    var calc = function(a, b) {
        if (!b) {
            return a;
        }
        
        return calc(b, a % b);
    }

    let output = calc(Number(num1.value), Number(num2.value));

    result.innerHTML = output;
}