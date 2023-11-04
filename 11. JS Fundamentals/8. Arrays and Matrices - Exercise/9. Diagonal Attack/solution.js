function solve(arr) {
    let matrix = [];

    for (let i = 0; i < arr.length; i++) {
        matrix[i] = [];
        let a = arr[i].split(" ");

        for (let j = 0; j < a.length; j++) {
            matrix[i][j] = Number(a[j]);
        }
    }

    let d1 = 0;
    let d2 = 0;

    let len = matrix.length - 1;

    for (let i = 0; i < matrix.length; i++) {
        d1 += matrix[i][i];
        d2 += matrix[i][len--];
    }

    if (d1 == d2) {
        len = matrix.length - 1;

        for (let i = 0; i < matrix.length; i++) {
            for (let j = 0; j < matrix[i].length; j++) {
                if (i != j && (i + j) != len) {
                    matrix[i][j] = d1;
                }
            }
        }

        for (let i = 0; i < matrix.length; i++) {
            console.log(matrix[i].join(" "));
        }
    }
    else {
        for (let i = 0; i < matrix.length; i++) {
            console.log(matrix[i].join(" "));
        }
    }
}