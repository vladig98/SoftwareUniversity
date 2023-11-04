function solve(arr) {
    let rows = [];
    let cols = [];

    for (let i = 0; i < arr.length; i++) {
        let row = 0;
        for (let j = 0; j < arr[i].length; j++) {
            row += arr[i][j];
        }
        rows.push(row);
    }

    for (let i = 0; i < arr.length; i++) {
        let col = 0;
        for (let j = 0; j < arr.length; j++) {
            col += arr[j][i];
        }
        cols.push(col);
    }

    for (let i = 0; i < rows.length; i++) {
        if (rows[i] != cols[i]) {
            console.log(false);
            return;
        }
    }

    console.log(true);
}