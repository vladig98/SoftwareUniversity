function LargestNumber(a, b, c) {
    let number1 = Number(a);
    let number2 = Number(b);
    let number3 = Number(c);

    console.log(`The largest number is ${Math.max(number1, Math.max(number2, number3))}.`);
}