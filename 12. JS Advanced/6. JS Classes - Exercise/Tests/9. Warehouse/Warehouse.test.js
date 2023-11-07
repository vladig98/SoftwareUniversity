var assert = require('assert');
var warehouse = require("../../9. Warehouse/Warehouse");
var expect = require('chai').expect

describe('Warehouse', function () {

    describe("constructor testing", function () {
        it("initializing negative capacity", function () {
            expect(() => new warehouse.Warehouse(-5)).to.throw("Invalid given warehouse space");
        });

        it("initializing 0 as cpacity", function () {
            expect(() => new warehouse.Warehouse(0)).to.throw("Invalid given warehouse space");
        });

        it("initializing empty", function () {
            expect(() => new warehouse.Warehouse()).to.throw("Invalid given warehouse space");
        });
    });

    describe("addProduct()", function () {
        let wh = new warehouse.Warehouse(100);

        it("add product", function () {
            let product = wh.addProduct("Food", "waffle", 5);
            assert.strictEqual(Object.keys(product).includes("waffle"), true);
            assert.strictEqual(product.waffle, 5);
        });

        it("add the same product again", function () {
            let product = wh.addProduct("Food", "waffle", 5);
            assert.strictEqual(Object.keys(product).includes("waffle"), true);
            assert.strictEqual(product.waffle, 10);
        })

        it("try adding a product when the warehouse is full", function () {
            expect(() => wh.addProduct("Food", "waffle", 100)).to.throw("There is not enough space or the warehouse is already full");
        });
    });

    describe("orderProducts()", function () {
        it("check if the array is ordered", function () {
            let wh = new warehouse.Warehouse(100);
            wh.addProduct("Drink", "fanta", 20);
            wh.addProduct("Drink", "Coke", 50);

            assert.strictEqual(Object.keys(wh.orderProducts("Drink"))[0], "Coke");
            assert.strictEqual(Object.keys(wh.orderProducts("Drink"))[1], "fanta");
        });
    });

    describe("occupiedCapacity()", function () {
        it("check the occupied capacity", function () {
            let wh = new warehouse.Warehouse(100);
            wh.addProduct("Drink", "fanta", 20);
            wh.addProduct("Drink", "Coke", 50);

            assert.strictEqual(wh.occupiedCapacity(), 70);
        });
    });

    describe("revision()", function () {
        it("empty warehouse", function () {
            let wh = new warehouse.Warehouse(100);

            assert.strictEqual(wh.revision(), "The warehouse is empty");
        });

        it("print all products", function () {
            let wh = new warehouse.Warehouse(100);
            wh.addProduct("Food", "waffle", 20);
            wh.addProduct("Drink", "Coke", 50);

            assert.strictEqual(wh.revision(), "Product type - [Food]\n- waffle 20\nProduct type - [Drink]\n- Coke 50");
        });
    });

    describe("scrapeAProduct()", function () {
        it("product does not exist", function () {
            let wh = new warehouse.Warehouse(100);

            expect(() => wh.scrapeAProduct("waffle", 10)).to.throw("waffle do not exists");
        });

        it("reduce number", function () {
            let wh = new warehouse.Warehouse(100);
            wh.addProduct("Food", "waffle", 20);

            assert.strictEqual(wh.scrapeAProduct("waffle", 10).waffle, 10);
        });
    });
});