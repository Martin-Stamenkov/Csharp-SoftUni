function extendClass(classToExtend) {
    classToExtend.prototype.species = 'Robot'
    classToExtend.prototype.toSpeciesString = function(){
        return `I am a ${this.species}. ${this.toString()}`
    }
}
