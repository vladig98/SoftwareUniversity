var assert = require('assert');
var charLookup = require("../../3. Char Lookup/lookupChar");

describe('Char Lookup', function () {
    describe('lookupChar()', function () {

        it("test for not passing a string", function () {
            const res = charLookup.lookupChar(4, 4);
            assert.strictEqual(res, undefined);
        })

        it("test for not passing an integer", function () {
            const res = charLookup.lookupChar("test", [4]);
            assert.strictEqual(res, undefined);
        })

        it("test for wrong parameters", function () {
            const res = charLookup.lookupChar(5, [4]);
            assert.strictEqual(res, undefined);
        })

        it("test for wrong index value: negative", function () {
            const res = charLookup.lookupChar("test", -1);
            assert.strictEqual(res, "Incorrect index");
        })

        it("test for wrong index value: outside of the array lenght", function () {
            const res = charLookup.lookupChar("test", 10);
            assert.strictEqual(res, "Incorrect index");
        })

        it("test for correct result", function () {
            const res = charLookup.lookupChar("test", 1);
            assert.strictEqual(res, 'e');
        })
    });
});