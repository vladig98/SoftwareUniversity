var assert = require('assert');
var addSubtract = require("../../7. Add-Subtract/add-subtract");

describe('Add / Subtract', function () {
    describe('createCalculator()', function () {

        it("test if adding works", function () {
            const calculator = addSubtract.createCalculator();
            calculator.add(5)
            const res = calculator.get();
            assert.strictEqual(res, 5);
        })

        it("test if subtracting works", function () {
            const calculator = addSubtract.createCalculator();
            calculator.subtract(5)
            const res = calculator.get();
            assert.strictEqual(res, -5);
        })

        it("test if chaining operations works", function () {
            const calculator = addSubtract.createCalculator();
            calculator.add(5);
            calculator.add(5);
            calculator.add(5);
            calculator.add(5);
            calculator.subtract(40);
            calculator.subtract(40);
            calculator.add(100);
            const res = calculator.get();
            assert.strictEqual(res, 40);
        })
    });
});