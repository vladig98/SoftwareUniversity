function solve(number) {
    for (var i = 1; i <= number; i++) {
        if (i == i.toString().split("").reverse().join("")) {
            console.log(i);
        }
    }
}