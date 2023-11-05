function solve(arr) {
    let obj = {};

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(/[\-\>\:]/g).filter(Boolean).map(x => x.trim());

        if (obj[tokens[0]] == undefined) {
            obj[tokens[0]] = {"products": []};
            let o = {};
            o[tokens[1]] = Number(tokens[2]) * Number(tokens[3]);
            obj[tokens[0]]["products"].push(o);
        }
        else {
            let o = {};
            o[tokens[1]] = Number(tokens[2]) * Number(tokens[3]);
            obj[tokens[0]]["products"].push(o);
        }
    }

    for (let key in obj) {
        console.log(`Town - ${key}`);
        for (let value in obj[key]['products']) {
            for (let p in obj[key]['products'][value]) {
                console.log(`$$$${p} : ${obj[key]['products'][value][p]}`);
            }
        }
    }
}