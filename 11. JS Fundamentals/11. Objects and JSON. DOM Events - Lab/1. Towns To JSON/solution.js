function solve(arr) {
    let towns = [];
    let params = arr[0].split("|").filter(Boolean).map(function(x) { return x.trim() });

    for (let i = 1; i < arr.length; i++) {
        let tokens = arr[i].split("|").filter(Boolean).map(function(x) { return x.trim() });
        let town = {};

        for (let j = 0; j < tokens.length; j++) {
            town[params[j]] = tokens[j];
        }

        towns.push(town);
    }

    console.log(towns);
}