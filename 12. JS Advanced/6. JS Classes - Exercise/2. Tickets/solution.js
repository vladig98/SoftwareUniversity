function solve(arr, sorting) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let tickets = [];

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split("|").filter(Boolean);
        tickets.push(new Ticket(tokens[0], Number(tokens[1]), tokens[2]));
    }

    tickets.sort((a, b) => (a[sorting] > b[sorting]) ? 1 : ((b[sorting] > a[sorting]) ? -1 : 0))

    return tickets;
}