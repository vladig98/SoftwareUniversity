var assert = require('assert');
var mathEnforcer = require("../../4. Math Enforcer/mathEnforcer");

describe('Math Enforcer', function () {
    const enf = mathEnforcer.mathEnforcer;

    describe('addFive()', function () {
        it("test for incorrect parameter type", function () {
            const res = enf.addFive("str");
            assert.strictEqual(res, undefined);
        })

        it("test for correct result", function () {
            const res = enf.addFive(10);
            assert.strictEqual(res, 15);
        })
    });

    describe('subtractTen()', function () {
        it("test for incorrect parameter type", function () {
            const res = enf.subtractTen("str");
            assert.strictEqual(res, undefined);
        })

        it("test for correct result", function () {
            const res = enf.subtractTen(20);
            assert.strictEqual(res, 10);
        })
    });

    describe('sum()', function () {
        it("test for incorrect parameter type", function () {
            const res = enf.sum("str", "b");
            assert.strictEqual(res, undefined);
        })

        it("test for incorrect parameter type", function () {
            const res = enf.sum("str", 3);
            assert.strictEqual(res, undefined);
        })

        it("test for incorrect parameter type", function () {
            const res = enf.sum(3, "b");
            assert.strictEqual(res, undefined);
        })

        it("test for correct result", function () {
            const res = enf.sum(20, 20);
            assert.strictEqual(res, 40);
        })
    });
});