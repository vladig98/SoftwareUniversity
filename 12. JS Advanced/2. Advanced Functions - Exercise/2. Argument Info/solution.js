function solve() {
    let types = [];

    for (let i = 0; i < arguments.length; i++) {
        console.log(`${typeof(arguments[i])}: ${arguments[i]}`);

        if (types.filter(x => x["type"] == typeof(arguments[i])).length > 0) {
            types.filter(x => x["type"] == typeof(arguments[i]))[0]["value"]++;
        }
        else {
            types.push({"type": typeof(arguments[i]), "value": 1});
        }
    }

    types = types.sort((a, b) => b["value"] - a["value"]);

    for (let type of types) {
        console.log(`${type["type"]} = ${type["value"]}`)
    }
}