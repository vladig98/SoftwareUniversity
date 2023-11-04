function solve(arr) {
    arr = arr.sort(function(a, b) {
        if (a.length < b.length) {
            return -1;
        }
        else if (a.length > b.length) {
            return 1;
        }
        else {a.length == b.length} {
            if (a.toLowerCase() < b.toLowerCase()) {
                return -1;
            }
            else if (a.toLowerCase() > b.toLowerCase()) {
                return 1;
            }
            else {a.toLowerCase() == b.toLowerCase()} {
                return 0;
            }
        }
    });

    for (let i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
}