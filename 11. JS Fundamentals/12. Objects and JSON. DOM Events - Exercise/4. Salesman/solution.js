function solve() {
  let textares = document.getElementsByTagName('textarea');
  let loadProductsArea = textares[0];
  let buyProductsArea = textares[1];
  let logArea = textares[2];

  let buttons = document.getElementsByTagName('button');
  let loadButton = buttons[0];
  let buyButton = buttons[1];
  let endDayButton = buttons[2];

  let storage = [];
  let profit = 0;

  loadButton.addEventListener("click", function() {
    let products = JSON.parse(loadProductsArea.value);

    for (let i = 0; i < products.length; i++) {
      if (storage.filter(x => x["name"] == products[i]["name"]).length > 0) {
        storage.filter(x => x["name"] == products[i]["name"])[0]["price"] = products[i]["price"];
        storage.filter(x => x["name"] == products[i]["name"])[0]["quantity"] += products[i]["quantity"];
      }
      else {
        storage.push(products[i]);
      }

      logArea.innerHTML += `Successfully added ${products[i]["quantity"]} ${products[i]["name"]}. Price: ${products[i]["price"].toFixed(2)}\n`;
    }
  }, {once: true});

  buyButton.addEventListener("click", function() {
    let order = JSON.parse(buyProductsArea.value);

    if (storage.filter(x => x["name"] == order["name"]).length > 0) {
      if (storage.filter(x => x["name"] == order["name"])[0]["quantity"] >= order["quantity"]) {
        storage.filter(x => x["name"] == order["name"])[0]["quantity"] -= order["quantity"];
        profit += order["quantity"] * storage.filter(x => x["name"] == order["name"])[0]["price"];
        logArea.innerHTML += `${order["quantity"]} ${order["name"]} sold for ${(order["quantity"] * storage.filter(x => x["name"] == order["name"])[0]["price"]).toFixed(2)}.\n`;
      }
      else {
        logArea.innerHTML += "Cannot complete order.\n";
      }
    }
    else {
      logArea.innerHTML += "Cannot complete order.\n";
    }
  }, {once: true});

  endDayButton.addEventListener("click", function() {
    logArea.innerHTML += `Profit: ${profit.toFixed(2)}.`;
  }, {once: true});
}