function perfectNumber(arr) {
    let results = [];

    for (let i = 0; i < arr.length; i++) {
        let sum = 0;

        for (let j = 1; j <= Math.floor(Math.sqrt(arr[i])); j++) {
            if (arr[i] % j == 0) {
                sum += j;
                if (j != 1) {
                    sum += arr[i] / j;
                }
            }
        }

        if (sum == arr[i]) {
            results.push(arr[i]);
        }
    }

    let output = results.length > 0 ? results.join(", ") : "No perfect number";

    console.log(output);
}