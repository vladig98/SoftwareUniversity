function solve(arr) {
    let rotations = Number(arr.pop());
    rotations %= 4;

    for (let i = 0; i < rotations; i++) {
        arr.unshift(arr.pop());
    }

    console.log(arr.join(" "));
}