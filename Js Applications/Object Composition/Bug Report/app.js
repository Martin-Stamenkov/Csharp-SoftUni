function solve() {

    let id = 0;
    let reports = [];

    let bug = {
        selector: '',
        report: function (author, description, reproducible, severity) {
            let bugReport = {
                ID: id++,
                author,
                description,
                reproducible,
                severity,
                status: "Open"
            }
            reports.push(bugReport)
            this.print();
            
        },
        setStatus: function (id, newStatus) {
            let current = reports.find(x => x.ID === id)
            current.status = newStatus;
            this.print();
        },
        remove: function (id) {

            reports = reports.filter(x => x.ID !== id)
            this.print();
        },
        sort: function (method) {
            if (method === 'author') {
                reports.sort((a, b) => a.author.localeCompare(b.author))
            } else if (method === 'severity') {
                reports.sort((a, b) => a.severity - b.severity)
            } else {
                reports.sort((a, b) => a.ID - b.ID);
            }
            this.print();
        },
        output: function (selector) {
            this.selector = selector
            this.print();

        },
        print() {
            let selector = document.querySelector(this.selector)
            selector.innerHTML = ' '

            reports.forEach(element => {
                selector.innerHTML += `<div id="report_${element.ID}" class="report">` +
                    '<div class="body">' +
                    `<p>${element.description}</p>` +
                    '</div>' +
                    '<div class="title">' +
                    `<span class="author">Submitted by: ${element.author}</span>` +
                    `<span class="status">${element.status} | ${element.severity}</span>` +
                    '</div>' +
                    '</div>';
            });

        }
    }
    return bug

}