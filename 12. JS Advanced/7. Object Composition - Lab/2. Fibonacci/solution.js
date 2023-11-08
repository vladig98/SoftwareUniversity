function getFibonator() {
    let num1 = 0;
    let num2 = 0;

    function fib() {
        let res = num1 + num2;

        res = res == 0 ? 1 : res;

        num1 = num2;
        num2 = res;
        return res;
    }

    return fib;
}