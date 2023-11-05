function solve(arr) {
    let obj = {};

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split("|").filter(Boolean).map(x => x.trim());

        if (obj[tokens[0]] == undefined) {
            obj[tokens[0]] = {"products": []};
            let o = {};
            o[tokens[1]] = Number(tokens[2]);
            obj[tokens[0]]["products"].push(o);
        }
        else {
            if (obj[tokens[0]]["products"].filter(x => Object.keys(x) == tokens[1]).length > 0) {
                obj[tokens[0]]["products"].filter(x => Object.keys(x) == tokens[1])[0][tokens[1]] = Number(tokens[2]);
            }
            else {
                let o = {};
                o[tokens[1]] = Number(tokens[2]);
                obj[tokens[0]]["products"].push(o);
            }
        }
    }

    let result = [];

    for (let key in obj) {
        for (let el in obj[key]["products"]) {
            for (let o in obj[key]["products"][el]) {
                let town = key;
                let value = obj[key]["products"][el][o];
                let product = o;

                if (result.filter(x => x.split("->").filter(Boolean).map(x => x.trim())[0] == o).length != 0) {
                    for (let key2 in obj) {
                        for (let el2 in obj[key2]["products"]) {
                            for (let o2 in obj[key2]["products"][el2]) {
                                if (o == o2) {
                                    if (obj[key2]["products"][el2][o2] < obj[key]["products"][el][o]) {
                                        town = key2;
                                        value = obj[key2]["products"][el2][o2];
                                        product = o2;
                                    }
                                }
                            }
                        }
                    }

                    let element = result.filter(x => x.split("->").filter(Boolean).map(x => x.trim())[0] == o)[0];
                    let index = result.indexOf(element);
                    result[index] = `${product} -> ${value} (${town})`;
                }
                else {
                    result.push(`${product} -> ${value} (${town})`)
                }
            }
        }
    }

    for (let r of result) {
        console.log(r);
    }
}