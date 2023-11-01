function humanizedNumber(str) {
    let tokens = str.split(/[^a-zA-Z0-9]/g);

    tokens = tokens.filter(Boolean);

    for (let i = 0; i < tokens.length; i++) {
        if (!isNaN(Number(tokens[i]))) {
            let number = Number(tokens[i]);

            if (number % 10 == 1 && number != 11) {
                console.log(`${number}st`);
            }
            else if (number % 10 == 2 && number != 12) {
                console.log(`${number}nd`);
            }
            else if (number % 10 == 3 && number != 13) {
                console.log(`${number}rd`);
            }
            else {
                console.log(`${number}th`);
            }
        }
    }
}