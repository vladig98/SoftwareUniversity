class SortedList {
    size = 0;

    constructor() {
        this.numbers = [];
    }

    add(element) {
        this.numbers.push(element);
        this.numbers.sort((a, b) => a - b);
        this.size = this.numbers.length;
    }

    remove(index) {
        if (index >= 0 && index < this.numbers.length) {
            this.numbers.splice(index, 1);
            this.size = this.numbers.length;
        }
    }

    get(index) {
        if (index >= 0 && index < this.numbers.length) {
            return this.numbers[index];
        }
    }

    get size() {
        return this._size;
    }

    set size(value) {
        this._size = value;
    }
}