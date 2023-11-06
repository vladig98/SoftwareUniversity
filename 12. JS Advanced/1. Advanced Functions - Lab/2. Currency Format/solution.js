function solve(func) {
    let separator = ",";
    let symbol = "$";
    let symbolFirst = true;

    let newFunc = function(value) {
        return func(separator, symbol, symbolFirst, value);
    }

    return newFunc;
}