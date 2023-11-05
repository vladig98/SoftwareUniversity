function solve(arr) {
    let text = arr[0];

    let words = text.split(/\W/g).filter(Boolean);
    let obj = {};

    for (let i = 0; i < words.length; i++) {
        obj[words[i]] = isNaN(Number(obj[words[i]])) ? 1 : obj[words[i]] + 1;
    }

    console.log(obj);
}