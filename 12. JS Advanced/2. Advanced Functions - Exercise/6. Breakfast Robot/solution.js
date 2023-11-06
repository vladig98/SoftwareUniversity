let solution = function() {
    let ingredients = {"protein": 0, "carbohydrate": 0, "fat": 0, "flavour": 0};

    let manage = function(str) {
        let tokens = str.split(" ");
        
        switch (tokens[0].toLowerCase()) {
            case "restock":
                ingredients[tokens[1]] += Number(tokens[2]);
                console.log("Success");
                break;
            case "prepare":
                switch (tokens[1].toLowerCase()) {
                    case "apple":
                        if (ingredients["carbohydrate"] >= 1 && ingredients["flavour"] >= 2) {
                            ingredients["carbohydrate"]--;
                            ingredients["flavour"] -= 2;
                            console.log("Success");
                        }
                        else {
                            console.log(`Error: not enough ${ingredients["carbohydrate"] < 1 ? "carbohydrate" : "flavour"} in stock`);
                        }
                        break;
                    case "coke":
                        if (ingredients["carbohydrate"] >= 10 && ingredients["flavour"] >= 20) {
                            ingredients["carbohydrate"] -= 10;
                            ingredients["flavour"] -= 20;
                            console.log("Success");
                        }
                        else {
                            console.log(`Error: not enough ${ingredients["carbohydrate"] < 10 ? "carbohydrate" : "flavour"} in stock`);
                        }
                        break;
                    case "burger":
                        if (ingredients["carbohydrate"] >= 5 && ingredients["fat"] >= 7 && ingredients["flavour"] >= 3) {
                            ingredients["carbohydrate"] -= 5;
                            ingredients["fat"] -= 7;
                            ingredients["flavour"] -= 3;
                            console.log("Success");
                        }
                        else {
                            console.log(`Error: not enough ${ingredients["carbohydrate"] < 5 ? "carbohydrate" : ingredients["fat"] < 7 ? "fat" : "flavour"} in stock`);
                        }
                        break;
                    case "omelet":
                        if (ingredients["carbohydrate"] >= 5 && ingredients["fat"] >= 1 && ingredients["flavour"] >= 1) {
                            ingredients["carbohydrate"] -= 5;
                            ingredients["fat"]--;
                            ingredients["flavour"]--;
                            console.log("Success");
                        }
                        else {
                            console.log(`Error: not enough ${ingredients["carbohydrate"] < 5 ? "carbohydrate" : ingredients["fat"] < 1 ? "fat" : "flavour"} in stock`);
                        }
                        break;
                    case "cheverme":
                        if (ingredients["protein"] >= 10 && ingredients["carbohydrate"] >= 10 && ingredients["fat"] >= 10 && ingredients["flavour"] >= 10) {
                            ingredients["protein"] -= 10;
                            ingredients["carbohydrate"] -= 10;
                            ingredients["fat"] -= 10;
                            ingredients["flavour"] -= 10;
                            console.log("Success");
                        }
                        else {
                            console.log(`Error: not enough ${ingredients["protein"] < 10 ? "protein" : ingredients["carbohydrate"] < 10 ? "carbohydrate" : ingredients["fat"] < 10 ? "fat" : "flavour"} in stock`);
                        }
                        break;
                    default:
                        break;
                }
                break;
            case "report":
                console.log(`protein=${ingredients["protein"]} carbohydrate=${ingredients["carbohydrate"]} fat=${ingredients["fat"]} flavour=${ingredients["flavour"]}`);
                break;
            default:
                break;
        }
    }

    return manage;
}