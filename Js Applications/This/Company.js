class Company {

    constructor() {
        this.departments = [];
    }
    addEmployee(username, salary, position, department) {
        if (!username || !salary || !position || !department || Number(salary) < 0) {
            throw new Error('Invalid input!')
        }
        let currentDepartment = this.departments.find(x => x.name === department)
        if (!currentDepartment) {
            this.departments.push({ name: department, employees: [] });
        }
        this.departments.find(x => x.name === department).employees.push({ username, salary, position });
        return `New employee is hired. Name: ${username}. Position: ${position}`
    }
    bestDepartment() {

        let best = this.departments.sort((a, b) => this.getAverage(b) - this.getAverage(a))[0]

        let result = `Best Department is: ${best.name}\n`;
        result += `Average salary: ${this.getAverage(best).toFixed(2)}\n`
        best.employees.sort((a, b) => a.salary === b.salary ? a.username.localeCompare(b.username) : b.salary - a.salary)
            .forEach(employee => {
                result += `${employee.username} ${employee.salary} ${employee.position}\n`
            });
        return result.trim()

    }
    getAverage(department) {
        return department.employees.reduce((acc, curr) => acc + curr.salary, 0) / department.employees.length;
    }

}
let c = new Company();
console.log(c.addEmployee("Stanimir", 2000, "engineer", "Construction"));
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());