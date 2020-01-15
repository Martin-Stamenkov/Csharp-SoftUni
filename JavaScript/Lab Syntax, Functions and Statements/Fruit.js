function solve(fruit, grams, pricePerKg) {

    let gramsToKg = grams / 1000;
    let totalPrice = pricePerKg * gramsToKg;

    console.log(`I need $${totalPrice.toFixed(2)} to buy ${gramsToKg.toFixed(2)} kilograms ${fruit}.`);

}
solve('orange', 2500, 1.80);