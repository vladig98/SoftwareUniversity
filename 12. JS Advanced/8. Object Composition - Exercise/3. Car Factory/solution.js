function solve(obj) {
    let engines = {
        small: { power: 90, volume: 1800 },
        normal: { power: 120, volume: 2400 },
        master: { power: 200, volume: 3500 }
    }

    let carriagge = {
        hatchback: { type: "hatchback", color: obj.color },
        coupe: { type: "coupe", color: obj.color }
    }

    let car = {
        model: obj.model,
        engine: obj.power <= engines.small.power ? engines.small : obj.power <= engines.normal.power ? engines.normal : engines.master,
        carriage: carriagge[obj.carriage],
        wheels: obj.wheelsize % 2 == 0 ? Array(4).fill(obj.wheelsize - 1) : Array(4).fill(obj.wheelsize)
    }

    return car;
}