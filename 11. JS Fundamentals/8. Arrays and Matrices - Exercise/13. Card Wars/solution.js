function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let cards = JSON.parse(arr.value);

  let player1 = cards[0];
  let player2 = cards[1];

  for (let i = 0; i < player1.length; i++) {
    if (player1[i].toString().toLowerCase() == "j") {
      player1[i] = 11;
    }
    if (player1[i].toString().toLowerCase() == "q") {
      player1[i] = 12;
    }
    if (player1[i].toString().toLowerCase() == "k") {
      player1[i] = 13;
    }
    if (player1[i].toString().toLowerCase() == "a") {
      player1[i] = 14;
    }
  }

  for (let i = 0; i < player2.length; i++) {
    if (player2[i].toString().toLowerCase() == "j") {
      player2[i] = 11;
    }
    if (player2[i].toString().toLowerCase() == "q") {
      player2[i] = 12;
    }
    if (player2[i].toString().toLowerCase() == "k") {
      player2[i] = 13;
    }
    if (player2[i].toString().toLowerCase() == "a") {
      player2[i] = 14;
    }
  }

  for (let i = 0; i < 20; i++) {
    if (player1.length <= 0) {
      end(player1, player2, result);
      return;
    }

    if (player2.length <= 0) {
      end(player1, player2, result);
      return;
    }

    let cardP1 = player1.shift();
    let cardP2 = player2.shift();

    if (cardP1 < cardP2) {
      player2.push(cardP1);
      player2.push(cardP2);
    }
    else if (cardP1 > cardP2) {
      player1.push(cardP1);
      player1.push(cardP2);
    }
    else {
      let war = [[cardP1], [cardP2]];

      while (true) {
        war[0].push(player1.shift());
        war[1].push(player2.shift());
        cardP1 = player1.shift();
        cardP2 = player2.shift();
        if (cardP1 < cardP2) {
          for (let i = 0; i < war[0].length; i++) {
            player2.push(war[0][i]);
          }
          for (let i = 0; i < war[1].length; i++) {
            player2.push(war[1][i]);
          }
          player2.push(cardP1);
          player2.push(cardP2);
          break;
        }
        else if (cardP1 > cardP2) {
          for (let i = 0; i < war[0].length; i++) {
            player1.push(war[0][i]);
          }
          for (let i = 0; i < war[1].length; i++) {
            player1.push(war[1][i]);
          }
          player1.push(cardP1);
          player1.push(cardP2);
          break;
        }
        else {
          war[0].push(cardP1);
          war[1].push(cardP2);
        }
      }
    }
  }

  end(player1, player2, result);

  function end(player1, player2, result) {
    for (let i = 0; i <player1.length; i++) {
      if (player1[i] == 11) {
        player1[i] = "J";
      }
      if (player1[i] == 12) {
        player1[i] = "Q";
      }
      if (player1[i] == 13) {
        player1[i] = "K";
      }
      if (player1[i] == 14) {
        player1[i] = "A";
      }
    }
  
    for (let i = 0; i <player2.length; i++) {
      if (player2[i] == 11) {
        player2[i] = "J";
      }
      if (player2[i] == 12) {
        player2[i] = "Q";
      }
      if (player2[i] == 13) {
        player2[i] = "K";
      }
      if (player2[i] == 14) {
        player2[i] = "A";
      }
    }
  
    let p = document.createElement("p");
    p.innerHTML = `First -> ${player1.join(", ")}`;
  
    let p1 = document.createElement("p");
    p1.innerHTML = `Second -> ${player2.join(", ")}`;
  
    result.appendChild(p);
    result.appendChild(p1);
  }
}