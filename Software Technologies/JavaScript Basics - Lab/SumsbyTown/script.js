function Solve(json) {
    let towns = [];

    for (var i = 0; i < json.length; i++) {
        let obj = json[i];
        if (towns.some(x => x.town == obj.town)) {
            let element = towns.find(x => x.town == obj.town);
            element.income += obj.income;
        } else {
            towns.push({ town: obj.town, income: obj.income });
        }
    }

    towns.sort(function(a, b){
        if (a.town < b.town) { return -1; }
        if (a.town > b.town) { return 1; }
        return 0;
    });

    for (var i = 0; i < towns.length; i++) {
        console.log(`${towns[i].town} -> ${towns[i].income}`);
    }
}