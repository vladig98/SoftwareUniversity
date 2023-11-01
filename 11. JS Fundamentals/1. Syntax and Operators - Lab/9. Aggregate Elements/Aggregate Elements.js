function AggregateElements(arr) {
    console.log([...arr].reduce((a, b) => a + b, 0));
    console.log([...arr].reduce((a, b) => a + 1/b, 0));
    console.log([...arr].join(''));
}