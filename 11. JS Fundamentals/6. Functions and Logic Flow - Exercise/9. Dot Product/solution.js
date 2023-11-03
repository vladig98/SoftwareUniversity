function solve() {
    let mat1 = document.getElementById('mat1');
    let mat2 = document.getElementById('mat2');
    let result = document.getElementById('result');

    let right = JSON.parse(mat1.value);
    let left = JSON.parse(mat2.value);

    let matrix = [];

    for (let i = 0; i < right.length; i++) {
        matrix[i] = [];
        for (let j = 0; j < left.length; j++) {
            let sum = 0;
            for (let k = 0; k < left[j].length; k++) {
                sum += right[i][k] * left[j][k];
            }
            matrix[i].push(sum);
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        let p = document.createElement("p");
        p.innerHTML = matrix[i].join(" ");
        result.appendChild(p);
    }
}