type Size = | Small | Medium | Big
type DrinkName = | Tea | Coffee | Juice 

type Drink = { name: DrinkName; basePrice: float; size: Size; priceIncreaseRatio: float }


let drinkPrice(drink: Drink): float = 
    let priceIncrease  = 
        match drink.size with
        | Size.Small -> 0.
        | Size.Medium -> drink.basePrice * drink.priceIncreaseRatio
        | Size.Big -> drink.basePrice * drink.priceIncreaseRatio * 2.
    drink.basePrice + priceIncrease



let tea(size: Size) = { name = DrinkName.Tea; size = size; basePrice = 20.; priceIncreaseRatio = 0.2 }
let coffee(size: Size) = { name = DrinkName.Coffee; size = size; basePrice = 15.; priceIncreaseRatio = 0.3 }
let juice(size: Size) = { name = DrinkName.Juice; size = size; basePrice = 10.; priceIncreaseRatio = 0.4 }