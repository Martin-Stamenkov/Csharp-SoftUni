function solve(input, criteria) {

    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }
    let tickets = [];

    input.forEach(element => {
        let [destination, price, status] = element.split('|');
        tickets.push(new Ticket(destination, +price, status));
    });


    if (criteria === 'destination') {
        tickets = tickets.sort((a, b) => a.destination.localeCompare(b.destination))
    } else if (criteria === 'status') {
        tickets = tickets.sort((a, b) => a.status.localeCompare(b.status))
    } else {
        tickets = tickets.sort((a, b) => a - b)
    }
return tickets
}
console.log(solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'tickets'))