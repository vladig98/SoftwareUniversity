function makeCard(face, suit) {
    const validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const validSuits = ['S', 'H', 'D', 'C'];

    if (!validFaces.includes(face) || !validSuits.includes(suit)) {
        return "Error";
    }

    const card = {
        face: face,
        suit: suit,
        toString: function () {
        const suitSymbol = {
            'S': '\u2660', // Spades (♠)
            'H': '\u2665', // Hearts (♥)
            'D': '\u2666', // Diamonds (♦)
            'C': '\u2663', // Clubs (♣)
        };

        return `${this.face}${suitSymbol[this.suit]}`;
        },
    };

    Object.freeze(card); // Prevent changing the card properties

    return card;
}