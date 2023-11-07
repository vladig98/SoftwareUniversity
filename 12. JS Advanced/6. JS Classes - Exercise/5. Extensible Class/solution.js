class BaseClass {
    constructor() {
        this.id = BaseClass.getNextId(); // Autoincremented ID for each instance
    }

    // Static property to keep track of the last assigned ID
    static lastId = 0;

    // Static method to generate the next unique ID
    static getNextId() {
        return ++BaseClass.lastId;
    }

    // Method to extend the instance with properties from the template
    extend(template) {
        for (let prop in template) {
            if (template.hasOwnProperty(prop)) {
                if (typeof template[prop] === 'function') {
                    // If the property is a function, add it to the prototype
                    BaseClass.prototype[prop] = template[prop];
                } else {
                    // Otherwise, add it to the instance
                    this[prop] = template[prop];
                }
            }
        }
    }
}