class Organization {

    constructor(name, budget) {
        this.name = name;
        this.budget = Number(budget);
        this.employees = [];

        this.marketing = +this.budget * 0.40,
            this.finance = +this.budget * 0.25,
            this.production = +this.budget * 0.35

    }

    get departmentsBudget() {
        return {
            marketing: this.marketing,
            finance: this.finance,
            production: this.production
        }
    }

    add(employeeName, department, salary) {

        if (this.departmentsBudget[department] >= salary) {

            let employee = {
                employeeName: employeeName,
                department: department,
                salary: salary
            }
            switch (department) {
                case "marketing": this.marketing -= +salary; break;
                case "finance": this.finance -= +salary; break;
                case "production": this.production -= +salary; break;
            }
            this.employees.push(employee);
            return `Welcome to the ${department} team Mr./Mrs. ${employeeName}.`
        } else {
            return `The salary that ${department} department can offer to you Mr./Mrs. ${employeeName} is $${this.departmentsBudget[department]}.`;
        }
    }
    leaveOrganization(employeeName) {

        let employee = this.employees.find(x => x.employeeName === employeeName);
        if (!employee) {

            return `Mr./Mrs. ${employeeName} is not working in ${this.name}.`

        } else {
                switch (employee.department) {
                    case "marketing": this.marketing += employee.salary; break;
                    case "finance": this.finance += employee.salary; break;
                    case "production": this.production += employee.salary; break;
                }

                let index = this.employees.indexOf(employee);
                this.employees.splice(index, 1);

                return `It was pleasure for ${this.name} to work with Mr./Mrs. ${employeeName}.`

        }
    }
    employeeExists(employeeName) {
        let employee = this.employees.find(x => x.employeeName === employeeName);
        if (employee) {
            return `Mr./Mrs. ${employeeName} is part of the ${employee.department} department.`
        } else {
            return `Mr./Mrs. ${employeeName} is not working in ${this.name}.`
        }

    }
    status() {

        const marketing = []
        const production = []
        const finance = []

        for (const employee of this.employees) {
            if (employee.department === 'marketing') {
                marketing.push(employee);
            }
            if (employee.department === 'production') {
                production.push(employee);
            }
            if (employee.department === 'finance') {
                finance.push(employee);
            }
        }
        let sortedMarketingEmployees = marketing.sort((a, b) => b.salary - a.salary)
        let sortedProductionEmployees = production.sort((a, b) => b.salary - a.salary)
        let sortedFinanceEmployees = finance.sort((a, b) => b.salary - a.salary)

        let result = `${this.name.toUpperCase()} DEPARTMENTS:`
        result += `\nMarketing | Employees: ${marketing.length}: ${sortedMarketingEmployees.map(e => e.employeeName).join(', ')} |  Remaining Budget: ${this.departmentsBudget['marketing']}`;
        result += `\nFinance | Employees: ${finance.length}: ${sortedFinanceEmployees.map(e => e.employeeName).join(', ')} |  Remaining Budget: ${this.departmentsBudget['finance']} `
        result += `\nProduction | Employees: {productionEmployeesCount}: ${sortedProductionEmployees.map(e => e.employeeName).join(', ')} |  Remaining Budget: ${this.departmentsBudget['production']}`
        return result;
    }

}



let organization = new Organization('SoftUni', 20000);

console.log(organization.add('Peter', 'marketing', 1200));
console.log(organization.add('Valio', 'marketing', 3200));
console.log(organization.add('Robert', 'production', 2000));
console.log(organization.add('Nikolay', 'production', 2050));
console.log(organization.add('Ryan', 'finance', 2000));
console.log(organization.add('Gosho', 'finance', 1000));
console.log(organization.status());
