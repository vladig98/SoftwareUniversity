function createExtensible() {
    const instance = {
        extend(template) {
            for (let prop in template) {
                if (template.hasOwnProperty(prop)) {
                    if (typeof template[prop] === 'function') {
                        // If the property is a function, add it to the prototype
                        instance.constructor.prototype[prop] = template[prop];
                    } else {
                        // Otherwise, add it to the instance
                        instance[prop] = template[prop];
                    }
                }
            }
        }
    };

    return instance;
}