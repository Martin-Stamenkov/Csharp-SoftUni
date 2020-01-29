function solve(input) {

    const gladiatorPool = {};

    for (const commandLine of input) {

        if (commandLine.includes('->')) {
            let [name, technique, skill] = commandLine.split(' -> ');

            if (!gladiatorPool[name]) {

                gladiatorPool[name] = {}
            }
            if (!gladiatorPool[name][technique]) {
                gladiatorPool[name][technique] = 0;
            }
            if (gladiatorPool[name][technique] < skill) {
                gladiatorPool[name][technique] = +skill
            }


        }
        else if (commandLine.includes('vs')) {
            let [gladiator1, gladiator2] = commandLine.split(' vs ');

            if (gladiatorPool.hasOwnProperty(gladiator1) && gladiatorPool.hasOwnProperty(gladiator2)) {

                let battleOn = false;

                let firstTechnique = Object.keys(gladiatorPool[gladiator1]);
                let secondTechnique = Object.keys(gladiatorPool[gladiator2]);

                for (const technique of firstTechnique) {

                    if (secondTechnique.includes(technique)) {
                        battleOn = true;
                        break;
                    }
                }
                if (battleOn) {

                    let firstGladiatorTotalSkills = Object.values(gladiatorPool[gladiator1])
                        .reduce((totalSkills, skill) => totalSkills + skill);
                    let secondGladiatorTotalSkills = Object.values(gladiatorPool[gladiator2])
                        .reduce((totalSkills, skill) => totalSkills + skill);

                    if (firstGladiatorTotalSkills > secondGladiatorTotalSkills) {
                        delete gladiatorPool[gladiator2]
                    } else if (firstGladiatorTotalSkills < secondGladiatorTotalSkills) {
                        delete gladiatorPool[gladiator1];
                    }

                }
            }
        }
        else if (commandLine == 'Ave Cesar') {


            let sortedGladiatorsByTotalSkills = Object.entries(gladiatorPool).sort((a, b) => {
                if (getGladiatorTotalSkill(b[0]) - getGladiatorTotalSkill(a[0])) {
                    return getGladiatorTotalSkill(b[0]) - getGladiatorTotalSkill(a[0]);
                }
                return a[0].localeCompare(b[0]);
            });

            for (const [gladiator, techniques] of sortedGladiatorsByTotalSkills) {

                console.log(`${gladiator}: ${getGladiatorTotalSkill(gladiator)} skill`)

                let sortedTechniqes = Object.entries(techniques).sort((a, b) => {
                    if (b[1] - a[1]) {
                        return b[1] - a[1]
                    }
                    return a[0].localeCompare(b[0])
                })

                for (const [name, skill] of sortedTechniqes) {

                    console.log(`- ${name} <!> ${skill}`);

                }

            }

        }
    }
    function getGladiatorTotalSkill(name) {

        return Object.values(gladiatorPool[name])
            .reduce((totalSkills, skill) => totalSkills + skill);
    }

}

solve(['Pesho -> Duck -> 400',
    'Julius -> Shield -> 150',
    'Gladius -> Heal -> 200',
    'Gladius -> Support -> 250',
    'Gladius -> Shield -> 250',
    'Pesho vs Gladius',
    'Gladius vs Julius',
    'Gladius vs Gosho',
    'Ave Cesar'
])