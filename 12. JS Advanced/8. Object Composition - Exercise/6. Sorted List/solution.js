function solve() {
    let numbers = [];

    class List {
        size = numbers.length;

        add = function (element) {
            numbers.push(element);
            numbers.sort((a, b) => a - b);
            this.size = numbers.length;
        }

        remove = function (index) {
            if (index >= this.size || index < 0) {
                return
            }

            numbers.splice(index, 1);
            this.size = numbers.length;
        }

        get = function (index) {
            if (index >= this.size || index < 0) {
                return
            }
            return numbers[index];
        }

        get size() {
            return this.size;
        }

        set size(value) {
            this.size = value;
        }
    }

    return new List();
}