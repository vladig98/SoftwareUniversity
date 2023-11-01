function coffeeMachine(arr) {
    let profit = 0;

    for (let i = 0; i < arr.length; i++) {
        let tokens = [...arr[i].split(", ")];

        for (let j = 0; j < tokens.length; j++) {
            let coins = tokens[j++];
            let drinkType = tokens[j++];
            let coffeeType = drinkType.toString().toLowerCase() == "coffee" ? tokens[j++] : null;
            let milk = isNaN(Number(tokens[j])) ? tokens[j++] : null;
            let sugar = tokens[j];

            let drinkPrice = 0;

            switch (drinkType.toLowerCase())
            {
                case "coffee":
                    switch (coffeeType.toLowerCase()) {
                        case "caffeine":
                            drinkPrice = 0.8;
                            break;
                        case "decaf":
                            drinkPrice = 0.9;
                            break;
                        default:
                            break;
                    }
                    break;
                case "tea":
                    drinkPrice = 0.8;
                    break;
                default:
                    break;
            }

            drinkPrice += milk == null ? 0 : Math.round(drinkPrice * 0.1 * 10) / 10;
            drinkPrice += sugar != 0 ? 0.1 : 0;

            if (coins >= drinkPrice) {
                console.log(`You ordered ${drinkType}. Price: ${drinkPrice.toFixed(2)}$ Change: ${(coins - drinkPrice).toFixed(2)}$`);
                profit += drinkPrice;
            }
            else {
                console.log(`Not enough money for ${drinkType}. Need ${(drinkPrice - coins).toFixed(2)}$ more`);
            }
            //console.log(`coins: ${coins} drink: ${drinkType} coffeeType: ${coffeeType} milk: ${milk} sugar: ${sugar}`);
        }
    }

    console.log(`Income Report: ${profit.toFixed(2)}$`);
}