function solve(input) {

    let data = input.reduce((acc, comp) => {
        let [systemName, componentName, subcomponentName] = comp.split('|').map(x => x.trim());
        if (acc[systemName]) {
            if (acc[systemName][componentName]) {
                acc[systemName][componentName].push(subcomponentName);
            }
            else {
                acc[systemName][componentName] = [subcomponentName];
            }
        }
        else {
            acc[systemName] = { [componentName]: [subcomponentName] }
        }
        return acc;

    }, {})
    for (let [systemName, systemComponents] of Object.entries(data).sort(compareSystems)) {
        console.log(systemName);

        for (let [componentName, subComponents] of Object.entries(systemComponents).sort(compareComponents)) {
            console.log(`|||${componentName}`);

            data[systemName][componentName].forEach(subComponent => {
                console.log(`||||||${subComponent}`);
            });
        }

    }
    function compareSystems(a, b) {
        if (Object.keys(b[1]).length !== Object.keys(a[1]).length) {
            return Object.keys(b[1]).length - Object.keys(a[1]).length;
        }
        return a[0].localeCompare(b[0])
    }
    function compareComponents(a, b) {
           return Object.keys(b[1]).length - Object.keys(a[1]).length;       
    }
}
solve(['SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security'])