class Computer {

    constructor(ramMemory, cpuGHz, hddMemory) {
        this.ramMemory = ramMemory;
        this.cpuGHz = cpuGHz;
        this.hddMemory = hddMemory;
        this.taskManager = [];
        this.installedPrograms = [];
    }

    installAProgram(name, requiredSpace) {

        if (this.hddMemory - requiredSpace <= 0) {

            throw Error("There is not enough space on the hard drive");
        }
        this.hddMemory -= requiredSpace;

        let newProgram = { name, requiredSpace }
        this.installedPrograms.push(newProgram);

        return newProgram;
    }
    uninstallAProgram(name) {

        let program = this.installedPrograms.find(x => x.name === name);

        if (!program) {

            throw Error("Control panel is not responding");
        }
        this.hddMemory += program.requiredSpace;
        let index = this.installedPrograms.findIndex(x => x.name === name)
        this.installedPrograms.splice(index, 1);

        return this.installedPrograms;
    }
    openAProgram(name) {

        let program = this.installedPrograms.find(x => x.name === name);
        if (!program) {

            throw Error(`The ${name} is not recognized`);
        }
        if (this.taskManager.find(x => x.name === name)) {
            throw Error(`The ${name} is already open`)
        }
        let ramUsage = (program.requiredSpace / this.ramMemory) * 1.5;
        let cpuUsage = ((program.requiredSpace / this.cpuGHz) / 500) * 1.5;


        let currentRam = 0;
        let currentCpu = 0;

        for (const program of this.taskManager) {
            currentRam += program.ramUsage;
            currentCpu += program.cpuUsage
        }
        if (currentRam + ramUsage >= 100) {
            throw Error(`${name} caused out of memory exception`)
        }
        if (currentCpu + cpuUsage >= 100) {
            throw Error(`${name} caused out of cpu exception`)
        }

        let programInTaskManager = {
            name,
            ramUsage,
            cpuUsage
        }
        this.taskManager.push(programInTaskManager);

        return programInTaskManager;
    }
    taskManagerView() {

        let openedProgram = '';
        if (this.taskManager.length === 0) {
            return 'All running smooth so far';
        }

        for (const program of this.taskManager) {

            openedProgram += `Name - ${program.name} | Usage - CPU: ${program.cpuUsage.toFixed(0)}%, RAM: ${program.ramUsage.toFixed(0)}%\n`
        }
        return openedProgram.trim();
    }

}
let computer = new Computer(4096, 7.5, 250000);

computer.installAProgram('Word', 7300);
computer.installAProgram('Excel', 10240);
computer.installAProgram('PowerPoint', 12288);
computer.installAProgram('Solitare', 1500);

computer.openAProgram('Word');
computer.openAProgram('Excel');
computer.openAProgram('PowerPoint');
computer.openAProgram('Solitare');

console.log(computer.taskManagerView());