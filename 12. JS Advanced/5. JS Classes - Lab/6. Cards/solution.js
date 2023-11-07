(function () {

    let validFaces = ["2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"];

    class Card {
        constructor(face, suit) {
            if (!Object.values(Suits).includes(suit.toString().toUpperCase())) {
                throw new Error("Invalid suit");
            }

            if (!validFaces.includes(face.toUpperCase())) {
                throw new Error("Invalid face")
            }

            this.face = face;
            this.suit = suit;
        }

        get suit() {
            return this._suit;
        }

        set suit(x) {
            if (!Object.values(Suits).includes(x.toUpperCase())) {
                throw new Error("Invalid suit");
            }
            this._suit = x;
        }

        get face() {
            return this._face;
        }

        set face(x) {
            if (!validFaces.includes(x.toUpperCase())) {
                throw new Error("Invalid face")
            }

            this._face = x;
        }
    }

    let Suits = {
        SPADES: '♠',
        HEARTS: '♥',
        DIAMONDS: '♦',
        CLUBS: '♣'
    }

    return {
        Suits: Suits,
        Card: Card
    }
}())