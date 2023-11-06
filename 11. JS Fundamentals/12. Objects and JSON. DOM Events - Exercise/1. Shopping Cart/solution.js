function solve() {
    let buttons = document.getElementsByTagName("button");
    let milkButton = buttons[0];
    let breadButton = buttons[1];
    let tomatoesButton = buttons[2];
    let buyButton = buttons[3];
    let result = document.getElementsByTagName('textarea')[0];

    let cart = [];

    milkButton.addEventListener("click", function() {
        if (cart.filter(x => x["name"] == "Milk").length > 0) {
            cart.filter(x => x["name"] == "Milk")[0]["quantity"]++;
        }
        else {
            cart.push({"name": "Milk", "price": 1.09, "quantity": 1});
        }
    });

    breadButton.addEventListener("click", function() {
        if (cart.filter(x => x["name"] == "Bread").length > 0) {
            cart.filter(x => x["name"] == "Bread")[0]["quantity"]++;
        }
        else {
            cart.push({"name": "Bread", "price": 0.8, "quantity": 1});
        }
    });

    tomatoesButton.addEventListener("click", function() {
        if (cart.filter(x => x["name"] == "Tomatoes").length > 0) {
            cart.filter(x => x["name"] == "Tomatoes")[0]["quantity"]++;
        }
        else {
            cart.push({"name": "Tomatoes", "price": 0.99, "quantity": 1});
        }
    });

    buyButton.addEventListener("click", function() {
        for (let p of cart) {
            for (let i = 0; i < p["quantity"]; i++) {
                result.innerHTML += `Added ${p["name"]} for ${p["price"].toFixed(2)} to the cart\n`;
            }
        }

        result.innerHTML += `You bought ${cart.map(x => x["name"]).join(", ")} for ${cart.map(x => x["price"] * x["quantity"]).reduce((a, b) => a + b).toFixed(2)}.`;
        cart = [];
    });
}