class Vacation {

    constructor(organizer, destination, budget) {
        this.organizer = organizer;
        this.destination = destination;
        this.budget = budget;
        this.kids = {};
    }

    get numberOfChildren() {

        let count = 0;

        for (const grade in this.kids) {
            if (this.kids.hasOwnProperty(grade)) {
                const length = this.kids[grade].length;
                count += length
            }
        }
        return count;
    }

    registerChild(name, grade, budget) {
        if (this.budget > budget) {

            return `${name}'s money is not enough to go on vacation to ${this.destination}.`
        }
        if (!this.kids[grade]) {
            this.kids[grade] = [];
        }
        if (this.kids[grade].includes(`${name}-${budget}`)) {
            return `${name} is already in the list for this ${this.destination} vacation.`
        }
        this.kids[grade].push(`${name}-${budget}`)

        return this.kids[grade]
    }
    removeChild(name, grade) {
        if (!this.kids[grade]) {
            return `We couldn't find ${name} in ${grade} grade.`
        }
        if (!this.kids[grade].find(x=>x.startsWith(name))) {
            return `We couldn't find ${name} in ${grade} grade.`
        }
        let index = this.kids[grade].findIndex(x => x.startsWith(name));
        this.kids[grade].splice(index, 1);
        return this.kids[grade]
    }
    toString() {

        let output = ' ';

        if (this.numberOfChildren === 0) {
            return output = `No children are enrolled for the trip and the organization of ${this.destination} falls out...`
        }

        output = `${this.organizer} will take ${this.numberOfChildren} children on trip to ${this.destination}`

        for (const grade in Object.keys(this.kids).sort((a, b) => a - b)) {

            output += `\nGrade: ${Object.keys(this.kids)[grade]}\n`

            let count = 1;
            for (const kid of Object.values(this.kids)[grade]) {
                output += `\n${count++}. ${kid}`

            }

        }
        return output.trim();
    }

}
let vacation = new Vacation('Miss Elizabeth', 'Dubai', 2000);
vacation.registerChild('Gosho', 5, 3000);
vacation.registerChild('Lilly', 6, 1500);
vacation.registerChild('Pesho', 7, 4000);
vacation.registerChild('Tanya', 5, 5000);
vacation.registerChild('Mitko', 10, 5500)
console.log(vacation.toString());