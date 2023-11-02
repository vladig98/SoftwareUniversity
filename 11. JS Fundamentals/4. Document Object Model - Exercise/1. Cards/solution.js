function solve() {
    let player1Cards = document.getElementById("player1Div").children;
    let player2Cards = document.getElementById("player2Div").children;
    let leftAnswer = document.getElementById("result").children[0];
    let rightAnswer = document.getElementById("result").children[2];
    let historyElement = document.getElementById("history");

    addClickEventsToCards1(player1Cards, leftAnswer, rightAnswer, historyElement, player2Cards);
    addClickEventsToCards2(player2Cards, leftAnswer, rightAnswer, historyElement, player1Cards);
}

function addClickEventsToCards1(playerCards, leftAnswer, rightAnswer, history, cards2) {
    for (let i = 0; i < playerCards.length; i++) {
        playerCards[i].addEventListener("click", function() {
            if (rightAnswer.innerHTML) {
                leftAnswer.innerHTML = playerCards[i].getAttribute("name") + " ";
                playerCards[i].setAttribute("src", "images/whiteCard.jpg");

                if (Number(leftAnswer.innerHTML) > Number(rightAnswer.innerHTML)) {
                    playerCards[i].style.border = "2px solid green";
                    [...cards2].filter(function(x) {
                        return x.getAttribute("name") == Number(rightAnswer.innerHTML);
                    })[0].style.border = "2px solid darkred";
                }
                else
                {
                    [...cards2].filter(function(x) {
                        return x.getAttribute("name") == Number(rightAnswer.innerHTML);
                    })[0].style.border = "2px solid green";
                    playerCards[i].style.border = "2px solid darkred";
                }

                setTimeout(function () {
                    history.innerHTML += `[${leftAnswer.innerHTML} vs ${rightAnswer.innerHTML}]`;
                    leftAnswer.innerHTML = "";
                    rightAnswer.innerHTML = "";
                }, 2000);
            }
            else {
                leftAnswer.innerHTML = playerCards[i].getAttribute("name") + " ";
                playerCards[i].setAttribute("src", "images/whiteCard.jpg");
            }
        }, {once: true});
    }
}

function addClickEventsToCards2(playerCards, leftAnswer, rightAnswer, history, cards2) {
    for (let i = 0; i < playerCards.length; i++) {
        playerCards[i].addEventListener("click", function() {
            if (leftAnswer.innerHTML) {
                rightAnswer.innerHTML = " " + playerCards[i].getAttribute("name");
                playerCards[i].setAttribute("src", "images/whiteCard.jpg");

                if (Number(leftAnswer.innerHTML) > Number(rightAnswer.innerHTML)) {
                    playerCards[i].style.border = "2px solid green";
                    [...cards2].filter(function(x) {
                        return x.getAttribute("name") == Number(leftAnswer.innerHTML);
                    })[0].style.border = "2px solid darkred";
                }
                else
                {
                    [...cards2].filter(function(x) {
                        return x.getAttribute("name") == Number(leftAnswer.innerHTML);
                    })[0].style.border = "2px solid green";
                    playerCards[i].style.border = "2px solid darkred";
                }

                setTimeout(function () {
                    history.innerHTML += `[${leftAnswer.innerHTML} vs ${rightAnswer.innerHTML}]`;
                    leftAnswer.innerHTML = "";
                    rightAnswer.innerHTML = "";
                }, 2000);
            }
            else {
                rightAnswer.innerHTML = " " + playerCards[i].getAttribute("name");
                playerCards[i].setAttribute("src", "images/whiteCard.jpg");
            }
        }, {once: true});
    }
}