var assert = require('assert');
var rgbToHex = require("../../6. RGB To Hex/rgb-to-hex");

describe('RGB To Hex', function () {
    describe('rgbToHexColor()', function () {

        const tests = [
            { r: "stamat", g: 1, b: 1, expected: undefined },
            { r: 1, g: "stamat", b: 1, expected: undefined },
            { r: 1, g: 1, b: "stamat", expected: undefined },
            { r: 300, g: 1, b: 1, expected: undefined },
            { r: 1, g: 300, b: 1, expected: undefined },
            { r: 1, g: 1, b: 300, expected: undefined },
            { r: -2, g: 1, b: 1, expected: undefined },
            { r: 1, g: -2, b: 1, expected: undefined },
            { r: 1, g: 1, b: -2, expected: undefined },
            { r: 1, g: 1, b: 1, expected: "#010101" },
            { r: 50, g: 150, b: 255, expected: "#3296FF" }
        ];


        tests.forEach(({ r, g, b, expected }) => {
            it(`test if colors are converted to HEX and if we get undefinied on incorrect values`, function () {
                const res = rgbToHex.rgbToHexColor(r, g, b);
                assert.strictEqual(res, expected);
            });
        });
    });
});