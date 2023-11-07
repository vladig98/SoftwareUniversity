function solve() {
    class Person {
        constructor(firstName, lastName, age, email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }

        toString() {
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
        }
    }

    let people = [];

    people.push(new Person("Maria", "Petrova", 22, "mp@yahoo.com"));
    people.push(new Person("SoftUni"));
    people.push(new Person("Stephan", "Nikolov", 25));
    people.push(new Person("Petar", "Kolev", 24, "ptr@gmail.com"));

    return people;
}