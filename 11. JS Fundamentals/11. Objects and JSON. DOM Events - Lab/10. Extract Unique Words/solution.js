function solve(arr) {
    let words = [];

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(/\W/g).filter(Boolean).map(x => x.trim());

        for (let j = 0; j < tokens.length; j++) {
            if (!words.includes(tokens[j].toLowerCase())) {
                words.push(tokens[j].toLowerCase());
            }
        }
    }

    console.log(words.join(", "));
}