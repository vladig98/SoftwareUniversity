class CheckingAccount {
    constructor(clientId, email, firstName, lastName) {
        if (!/^\d{6,6}$/g.test(clientId)) {
            throw new TypeError("Client ID must be a 6-digit number");
        }

        if (!/^[a-zA-Z0-9]{1,}@[a-zA-z.]{1,}$/g.test(email)) {
            throw new TypeError("Invalid e-mail");
        }

        if (!/^[a-zA-Z]{3,20}$/g.test(firstName)) {
            if (firstName.length < 3 || firstName.length > 20) {
                throw new TypeError("First name must be between 3 and 20 characters long");
            }
            throw new TypeError("First name must contain only Latin characters");
        }

        if (!/^[a-zA-Z]{3,20}$/g.test(lastName)) {
            if (lastName.length < 3 || lastName.length > 20) {
                throw new TypeError("Last name must be between 3 and 20 characters long");
            }
            throw new TypeError("Last name must contain only Latin characters");
        }

        this.clientId = clientId;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
        this.products = [];
    }
}