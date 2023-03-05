// For more information see https://aka.ms/fsharp-console-apps


type Size = | Small | Medium | Big

type Drink = {name: string; size: Size; basePrice: float; priceIncreaseRatio: float}


let drinkPrice(drink: Drink): float = 
    let priceIncrease  = 
        match drink.size with
        | Size.Small -> 0.
        | Size.Medium -> drink.basePrice * drink.priceIncreaseRatio
        | Size.Big -> drink.basePrice * drink.priceIncreaseRatio * 2.
    drink.basePrice + priceIncrease



let coffee(size: Size) = {name = "Coffee"; size = size; basePrice = 15.; priceIncreaseRatio = 0.3}
let juice(size: Size) = {name = "Juice"; size = size; basePrice = 10.; priceIncreaseRatio = 0.4}


let drink3(name: string, size: Size) = {name = name; size = size; basePrice = 20.; priceIncreaseRatio = 0.3}