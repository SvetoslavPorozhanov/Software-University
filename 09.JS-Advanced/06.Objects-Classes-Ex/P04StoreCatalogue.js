function solve(input) {
    const catalog = {};
    for (let line of input) {
        const [product, price] = line.split(' : ');
        const letter = product[0];
        if (catalog.hasOwnProperty(letter) === false) {
            catalog[letter] = {};
        }
        catalog[letter][product] = price;
    }

    const sortedKeys = Object.keys(catalog).sort((a, b) => a.localeCompare(b));
    for (let key of sortedKeys) {
        console.log(key);
        const sortedProducts = Object.keys(catalog[key]).sort((a, b) => a.localeCompare(b));
        for (let product of sortedProducts) {
            console.log(`  ${product}: ${catalog[key][product]}`);
        }
    }
}