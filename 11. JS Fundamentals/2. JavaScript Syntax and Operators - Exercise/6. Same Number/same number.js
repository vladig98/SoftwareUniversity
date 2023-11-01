function sameNumber(num) {
    let arr = num.toString().split("");
    arr = [...arr].map(x => Number(x));

    let sum = arr.reduce((a, b) => a + b, 0);

    for (let i = 0; i < arr.length - 1; i++)
    {
        if (arr[i] != arr[i + 1]) {
            console.log("false");
            console.log(sum);
            return;
        }
    }

    console.log("true");
    console.log(sum);
}