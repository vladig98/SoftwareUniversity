function solve(dim1, dim2) {
    let matrix = [];

    for (let i = 0; i < dim1; i++) {
        matrix[i] = [];
    }

    let number = 1;

    for (let k = 0; k < dim1; k++) {

        for (let i = k; i < dim1 - k; i++) {
            for (let j = k; j < dim2 - k; j++) {
                matrix[i][j] = number++;
            }
            i = dim1;
        }

        for (let i = k + 1; i < dim1 - k; i++) {
            matrix[i][dim2 - 1 - k] = number++;
        }

        for (let i = dim1 - (k + 2); i >= k; i--) {
            matrix[dim2 - 1 - k][i] = number++;
        }

        for (let i = dim2 - (k + 2); i > k; i--) {
            matrix[i][k] = number++;
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(" "));
    }
}