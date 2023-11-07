var assert = require('assert');
var evenOrOdd = require("../../2. Even Or Odd/isOdd");

describe('Even or Odd', function () {
    describe('isOddOrEven()', function () {

        it("test if you push something other than a string: number", function () {
            const res = evenOrOdd.isOddOrEven(4);
            assert.strictEqual(res, undefined);
        })

        it("test if you push something other than a string: array of string", function () {
            const res = evenOrOdd.isOddOrEven(["hey"]);
            assert.strictEqual(res, undefined);
        })

        it("test for even length", function () {
            const res = evenOrOdd.isOddOrEven("hey!");
            assert.strictEqual(res, "even");
        })

        it("test for odd length", function () {
            const res = evenOrOdd.isOddOrEven("hey");
            assert.strictEqual(res, "odd");
        })
    });
});