function solve(arr) {
    let obj = {};

    for (let i = 0; i < arr.length; i += 2) {
        obj[arr[i]] = isNaN(Number(obj[arr[i]])) ? Number(arr[i + 1]) : Number(arr[i + 1]) + obj[arr[i]];
    }

    console.log(obj);
}