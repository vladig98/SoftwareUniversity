function solve(arr) {
    let obj = {};

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split("<->").filter(Boolean).map(x => x.trim());

        obj[tokens[0]] = isNaN(Number(obj[tokens[0]])) ? Number(tokens[1]) : Number(tokens[1]) + obj[tokens[0]];
    }

    for (let key in obj) {
        console.log(`${key} : ${obj[key]}`)
    }
}