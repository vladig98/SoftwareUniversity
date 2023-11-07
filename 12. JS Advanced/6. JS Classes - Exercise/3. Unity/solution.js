class Rat {
    constructor(name) {
        this.name = name;
        this.united = [];
    }

    unite(rat) {
        if (typeof (rat) == typeof (this)) {
            this.united.push(rat);
        }
    }

    getRats() {
        return this.united;
    }

    toString() {
        console.log(this.name);
        this.united.forEach(x => console.log(`##${x.name}`));
    }
}