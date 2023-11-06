function solve(arr) {
    let str = "";

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(" ").filter(Boolean).map(x => x.trim());

        switch (tokens[0].toLowerCase()) {
            case "append":
                str += tokens[1];
                break;
            case "removestart":
                let number = Number(tokens[1]);
                let letters = str.split("");
                for (let j = 0; j < number; j++) {
                    letters.shift();
                }
                str = letters.join("");
                break;
            case "removeend":
                let number2 = Number(tokens[1]);
                let letters2 = str.split("");
                for (let k = 0; k < number2; k++) {
                    letters2.pop();
                }
                str = letters2.join("");
                break;
            case "print":
                console.log(str);
                break;
            default:
                break;
        }
    }
}