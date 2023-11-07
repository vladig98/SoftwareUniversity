var assert = require('assert');
var checkForSymmetry = require("../../5. Check For Symmetry/check-for-symmetry");

describe('Check For Symmetry', function () {
    describe('isSymmetric()', function () {

        const tests = [
            { args: [1, 2, 2, 1], expected: true },
            { args: [1, 2, 3], expected: false },
            { args: 2, expected: false }
        ];


        tests.forEach(({ args, expected }) => {
            it(`test if the arrays are symmetric`, function () {
                const res = checkForSymmetry.isSymmetric(args);
                assert.strictEqual(res, expected);
            });
        });
    });
});