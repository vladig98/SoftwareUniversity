function CircleArea(n) {
    if (typeof(n) != 'number') {
        console.log(`We can not calculate the circle area, because we receive a ${typeof(n)}.`);
    }
    else {
        let radius = Number(n);
        console.log((Math.PI * radius * radius).toFixed(2));
    }
}