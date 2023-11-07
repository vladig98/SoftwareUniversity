var assert = require('assert');
var sumofNumber = require("../../4. Sum Of Numbers/sum-of-numbers");

describe('Sum of Numbers', function () {
  describe('sum()', function () {

    const tests = [
      { args: [1, 2], expected: 3 },
      { args: [1, 2, 3], expected: 6 },
      { args: [1, 2, 3, 4], expected: 10 }
    ];


    tests.forEach(({ args, expected }) => {
      it(`testing if the sum function returns the correct output`, function () {
        const res = sumofNumber.sum(args);
        assert.strictEqual(res, expected);
      });
    });
  });
});