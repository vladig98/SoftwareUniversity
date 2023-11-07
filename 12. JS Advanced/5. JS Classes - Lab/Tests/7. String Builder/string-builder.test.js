var assert = require('assert');
var stringBuilder = require("../../7. String Builder/string-builder");

describe('String Builder', function () {

    describe("constructor testing", function () {
        it("initializing empty", function () {
            let builder = new stringBuilder.StringBuilder();
            assert.equal(typeof (builder._stringArray), typeof ([]));
            assert.equal(builder._stringArray.length, [].length);
        });

        it("initializing with value", function () {
            let builder = new stringBuilder.StringBuilder("value");
            assert.equal(typeof (builder._stringArray), typeof (["v", "a", "l", "u", "e"]));
            assert.equal(builder._stringArray.length, ["v", "a", "l", "u", "e"].length);
        });
    });

    describe("append()", function () {
        it("null parameter", function () {
            let builder = new stringBuilder.StringBuilder("value");
            assert.throws(builder.append, TypeError, "Argument must be string");
        })

        it("check if appends", function () {
            let builder = new stringBuilder.StringBuilder("value");
            builder.append('New');
            assert.equal(typeof (builder._stringArray), typeof (["v", "a", "l", "u", "e", "N", "e", "w"]));
        })
    });

    describe("prepend()", function () {
        it("null parameter", function () {
            let builder = new stringBuilder.StringBuilder("value");
            assert.throws(builder.prepend, TypeError, "Argument must be string");
        })

        it("check if prepends", function () {
            let builder = new stringBuilder.StringBuilder("Value");
            builder.prepend('new');
            assert.equal(typeof (builder._stringArray), typeof (["n", "e", "w", "V", "a", "l", "u", "e"]));
        })
    });

    describe("insertAt()", function () {
        it("null parameter", function () {
            let builder = new stringBuilder.StringBuilder("value");
            assert.throws(builder.insertAt, TypeError, "Argument must be string");
        })

        it("check if it inserts at index", function () {
            let builder = new stringBuilder.StringBuilder("vaue");
            builder.insertAt('l', 2);
            assert.equal(typeof (builder._stringArray), typeof (["V", "a", "l", "u", "e"]));
        })
    });

    describe("remove()", function () {
        it("check if it removes", function () {
            let builder = new stringBuilder.StringBuilder("value");
            builder.remove(2, 1);
            assert.equal(typeof (builder._stringArray), typeof (["V", "a", "u", "e"]));
        })
    });

    describe("toString()", function () {
        it("check if toString returns correctly", function () {
            let builder = new stringBuilder.StringBuilder("value");
            let res = builder.toString();
            assert.equal("value", res);
        })
    });
});