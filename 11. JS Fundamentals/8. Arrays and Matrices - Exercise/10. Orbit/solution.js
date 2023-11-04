function solve(arr) {
    let dim1 = arr[0];
    let dim2 = arr[1];
    let s1 = arr[2];
    let s2= arr[3];

    let matrix = [];

    for (let i = 0; i < dim1; i++) {
        matrix[i] = [];
    }

    let number = 1;

    matrix[s1][s2] = number;

    while (number < dim1) {
        for (let i = s1 - number; i <= s1 + number; i++) {
            for (let j = s2 - number; j <= s2 + number; j++) {
                if (i >= 0 && i < dim1 && j >= 0 && j < dim2) {
                    if (!matrix[i][j]) {
                        matrix[i][j] = number + 1;
                    }
                }
            }
        }
        number++;
    }

    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(" "));
    }
}