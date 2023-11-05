function solve(arr) {
    let text = arr[0];
    let words = text.split(/\W/g).filter(Boolean).map(x => x.trim());

    let map = new Map();

    for (let i = 0; i < words.length; i++) {
        if (map.has(words[i].toLowerCase())) {
            map.set(words[i].toLowerCase(), map.get(words[i].toLowerCase()) + 1);
        }
        else {
            map.set(words[i].toLowerCase(), 1);
        }
    }

    for (let [key, value] of map) {
        console.log(`\'${key}\' -> ${value} times`);
    }
}