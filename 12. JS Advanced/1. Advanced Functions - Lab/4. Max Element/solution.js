function solve(arr) {
    console.log(arr.reduce((a, b) => a > b ? a : b));
}