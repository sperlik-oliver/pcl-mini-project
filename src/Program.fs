type Size = | Small | Medium | Big

type Drink = { name: string; basePrice: float; size: Size; priceIncreaseRatio: float }
type Food = { name: string; price: float; }
type Fruit = { name: string; price: float; }
type Product = | Food of Food | Fruit of Fruit | Drink of Drink

let drinkPrice(drink: Drink): float = 
    let priceIncrease  = 
        match drink.size with
        | Size.Small -> 0.
        | Size.Medium -> drink.basePrice * drink.priceIncreaseRatio
        | Size.Big -> drink.basePrice * drink.priceIncreaseRatio * 2.
    drink.basePrice + priceIncrease



let tea(size: Size) = { name = "Tea"; size = size; basePrice = 20.; priceIncreaseRatio = 0.2 }
let coffee(size: Size) = { name = "Coffee"; size = size; basePrice = 15.; priceIncreaseRatio = 0.3 }
let juice(size: Size) = { name = "Juice"; size = size; basePrice = 10.; priceIncreaseRatio = 0.4 }