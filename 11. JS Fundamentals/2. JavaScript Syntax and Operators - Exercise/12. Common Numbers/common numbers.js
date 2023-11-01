function commonNumbers(arr1, arr2, arr3) {
    let arr = [];

    for (let i = 0; i < arr1.length; i++) {
        if (arr2.includes(arr1[i]) && arr3.includes(arr1[i])) {
            arr.push(arr1[i]);
        }
    }

    arr.sort();

    console.log(`The common elements are ${arr.join(", ")}.`);
    console.log(`Average: ${arr.reduce((a, b) => a + b) / arr.length}`);
    console.log(`Median: ${arr.length % 2 == 0 ? (arr[arr.length / 2] + arr[arr.length / 2 - 1]) / 2 : arr[Math.floor(arr.length / 2)]}`);
}