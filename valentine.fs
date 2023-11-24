 type Cuisine =
    | Korean
    | Turkish

type MovieType =
     | Regular
     | IMAX
     | DBOX
     | RegularWithSnacks
     | IMAXWithSnacks
     | DBOXWithSnacks

type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float

let calculateBudget activity =
     match activity with
     | BoardGame -> 0.0
     | Chill -> 0.0
     | Movie Regular -> 12.0
     | Movie IMAX -> 17.0
     | Movie DBOX -> 20.0
     | Movie _ -> 12.0 + 5.0 
     | Restaurant Korean -> 70.0
     | Restaurant Turkish -> 65.0
     | LongDrive (kilometres, fuelCharge) -> float kilometres * fuelCharge

let eveningActivity = Restaurant Turkish
let budget = calculateBudget eveningActivity
printfn "Estimated Budget: %.2f CAD" budget