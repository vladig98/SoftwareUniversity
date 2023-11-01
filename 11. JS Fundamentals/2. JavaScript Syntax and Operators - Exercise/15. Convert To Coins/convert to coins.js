function convertToCoins(amount, coins) {
    coins.sort(function(a, b) {return b - a;});

    let result = [];

    let index = 0;

    while (amount > 0) {
        if (index == coins.length) {
            console.log("Cannot make the amount out of these coins!");
            return;
        }

        if (amount - coins[index] >= 0) {
            result.push(coins[index]);
            amount -= coins[index];
        }
        else {
            index++;
        }
    }

    console.log(result.join(", "));
}