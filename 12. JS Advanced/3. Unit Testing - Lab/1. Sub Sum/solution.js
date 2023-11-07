function solve(arr, start, end) {
    if (typeof(arr) != typeof([])) {
        console.log("NaN");
        return;
    }

    if (start < 0) {
        start = 0;
    }

    if (end >= arr.length) {
        end = arr.length - 1;
    }

    arr = arr.slice(start, end + 1);

    console.log(arr.reduce(function(a, b) { return Number(a) + Number(b) }, 0));
}