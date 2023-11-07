var assert = require('assert');
var paymentPackage = require("../../8. Payment Package/PaymentPackage");

describe('Payment Package', function () {

    describe("constructor testing", function () {
        it("initializing empty", function () {
            assert.throws(() => { new paymentPackage.PaymentPackage() }, Error);
        });

        it("initializing with values", function () {
            let payment = new paymentPackage.PaymentPackage("HR", 1500);
            assert.strictEqual(payment.name, "HR");
            assert.strictEqual(payment.value, 1500);
        });
    });

    describe("testing get and set for name", function () {
        let payment = new paymentPackage.PaymentPackage("HR", 1500);

        it("test get", function () {
            assert.strictEqual(payment.name, "HR");
        })

        it("test set with invalid value", function () {
            assert.throws(() => { payment.name(2) }, Error);
        })

        it("test set with an empty string", function () {
            assert.throws(() => { payment.name("") }, Error);
        })

        it("test set with valid value", function () {
            payment.name = "Marketing";
            assert.strictEqual(payment.name, "Marketing");
        })
    })

    describe("testing get and set for value", function () {
        let payment = new paymentPackage.PaymentPackage("HR", 1500);

        it("test get", function () {
            assert.strictEqual(payment.value, 1500);
        })

        it("test set with invalid value", function () {
            assert.throws(() => { payment.value("0") }, Error);
        })

        it("test set with a negative number", function () {
            assert.throws(() => { payment.value(-5) }, Error);
        })

        it("test set with valid value", function () {
            payment.value = 20;
            assert.strictEqual(payment.value, 20);
        })
    })


    describe("testing get and set for VAT", function () {
        let payment = new paymentPackage.PaymentPackage("HR", 1500);

        it("test get", function () {
            assert.strictEqual(payment.VAT, 20);
        })

        it("test set with invalid value", function () {
            assert.throws(() => { payment.VAT("0") }, Error);
        })

        it("test set with a negative number", function () {
            assert.throws(() => { payment.VAT(-5) }, Error);
        })

        it("test set with valid value", function () {
            payment.VAT = 10;
            assert.strictEqual(payment.VAT, 10);
        })
    })

    describe("testing get and set for active", function () {
        let payment = new paymentPackage.PaymentPackage("HR", 1500);

        it("test get", function () {
            assert.strictEqual(payment.active, true);
        })

        it("test set with invalid value", function () {
            assert.throws(() => { payment.VAT("0") }, Error);
        })

        it("test set with valid value", function () {
            payment.active = false;
            assert.strictEqual(payment.active, false);
        })
    })

    describe("test toString", function () {
        it("test toString", function () {
            let payment = new paymentPackage.PaymentPackage("HR", 1500);
            let res = `Package: HR\n- Value (excl. VAT): 1500\n- Value (VAT 20%): 1800`;

            assert.strictEqual(res, payment.toString());
        })
    })
});