function solve(arr) {
    let elements = [];

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(" ");

        switch (tokens[0]) {
            case "add":
                elements.push(tokens[1]);
                break;
            case "remove":
                for (let j = 0; j < elements.filter(x => x == tokens[1]).length; j++) {
                    let index = elements.indexOf(tokens[1]);
                    elements.splice(index, 1);
                    j--;
                }
                break;
            case "print":
                console.log(elements.join(","));
                break;
            default:
                break;
        }
    }
}