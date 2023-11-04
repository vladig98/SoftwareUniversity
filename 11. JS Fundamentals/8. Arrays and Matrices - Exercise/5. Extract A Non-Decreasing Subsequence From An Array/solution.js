function solve(arr) {
    let max = arr[0] - 1;
    arr = arr.filter(function(a) {
            if (a > max) {
                max = a;
                return true;
            }
            else {
                return false;
            }
        });

    for (let i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
}