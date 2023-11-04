function solve(arr) {
    let number = 1;
    let a = [];

    for (let i = 0; i < arr.length; i++) {
        if (arr[i].toLowerCase() == "add") {
            a.push(number++);
        }
        else {
            a.pop();
            number++;
        }
    }

    if (a.length == 0) {
        console.log("Empty");
    }
    else {
        for (let i = 0; i < a.length; i++) {
            console.log(a[i]);
        }
    }
}