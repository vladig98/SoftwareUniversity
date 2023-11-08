function solve(arr) {
    let objs = [];

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(" ");

        switch (tokens[0]) {
            case "create":
                if (tokens.length == 2) {
                    objs.push({ name: tokens[1], inheritedProperties: [] });
                } else {
                    let extend = objs.filter(x => x.name == tokens[3])[0];
                    let index = objs.indexOf(extend);

                    objs.push({ name: tokens[1], inheritedProperties: [index] });
                }
                break;
            case "set":
                objs.filter(x => x.name == tokens[1])[0][tokens[2]] = tokens[3];
                break;
            case "print":
                let obj = objs.filter(x => x.name == tokens[1])[0];
                let keys = Object.keys(obj).filter(x => x != "name" && x != "inheritedProperties");
                let values = keys.map(x => obj[x]);

                let result = [];

                for (let j = 0; j < keys.length; j++) {
                    result.push(`${keys[j]}:${values[j]}`);
                }

                for (let j = 0; j < obj.inheritedProperties.length; j++) {
                    let el = objs[obj.inheritedProperties[j]];
                    let elk = Object.keys(el).filter(x => x != "name" && x != "inheritedProperties");;
                    let elv = elk.map(x => el[x]);

                    for (let z = 0; z < elk.length; z++) {
                        result.push(`${elk[z]}:${elv[z]}`);
                    }
                }

                console.log(result.join(", "));
                break;
            default:
                break;
        }
    }
}