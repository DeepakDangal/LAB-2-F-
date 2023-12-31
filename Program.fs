﻿//   let rec productTailRecursive acc lst =
//       match lst with
//       | [] -> acc
//       | head :: tail -> productTailRecursive (acc * head) tail

//   let my_List = [1; 4; 5; 6; 7]

//   let result = productTailRecursive 1 my_List
//   printfn "The product of the elements in the list is: %d" result


//   no two of recurssion

//   let rec productOfOddNumbers acc number =
//       if number <= 1 then
//           acc
//       else if number % 2 = 0 then 
//           productOfOddNumbers acc (number - 1) 
//       else
//           productOfOddNumbers (acc * number) (number - 2) 
//   let givenNumber = 11 

//   let result2 = productOfOddNumbers 1 givenNumber
//   printfn "The product of all odd numbers from %d to 1 is: %d" givenNumber result2

//  question no-


//  let sequence = [1..700]


//  let filteredNumbers = sequence |> List.filter (fun x -> x % 7 <> 0 || x % 5 <> 0)

//  let totalSum = filteredNumbers |> List.fold (+) 0

//  printfn "The sum is %d" totalSum

//   question no 6


//   let names = ["James";"Robert";"John";"William";"Michael";"David";"Richard"]

//    Filtering names that contain the letter "I"
//   let filteredNames = names |> List.filter (fun name -> name.Contains("i"))

//    Concatenating the filtered names using List.fold
//   let concatenatedNames = filteredNames |> List.fold (fun acc name -> acc + name) ""

//   printfn "%s" concatenatedNames

//  questin 4
//  let names_ = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

//   Trimming empty spaces before and after each element using List.map and String.Trim()
//  let trimmedNames = names_ |> List.map (fun name -> name.Trim())

//   Printing the trimmed names
//  trimmedNames |> List.iter (fun trimmedName -> printfn "%s" trimmedName)



//   lab-2

//  type Coach = {
//      Name: string
//      formerPlayer: bool
//  }

//  type Stats = {
//      wins: int
//      losses: int
//  }

//  type Team = {
//      Name: string
//      coach: Coach
//      Stats: Stats
//  }

//  let teams = [
//      { Name = "chicago Bulls"; coach = { Name = "Billy Donovan"; formerPlayer = true }; Stats = { wins = 2344; losses = 2254 } }
//      { Name = "Miami Heat"; coach = { Name = "Erik Spoelstra"; formerPlayer = true }; Stats = { wins = 1475; losses = 1328 } }   
//      { Name = "Golden State Warriors"; coach = { Name = "Steve Kerr"; formerPlayer = true }; Stats = { wins = 2923; losses = 3098 } }
//      { Name = "Milwaukee Bucks"; coach = { Name = "Adrian Griffin"; formerPlayer = true }; Stats = { wins = 2340; losses = 2103 } }
//      { Name = "Toronto Raptors"; coach = { Name = "Darko Rajakovic"; formerPlayer = true }; Stats = { wins = 1071; losses = 1175 } }
//  ]


//  let bestTeams = teams |> List.filter (fun team -> team.Stats.wins > team.Stats.losses)

//  bestTeams |> List.iter (fun team -> printfn "Team Name: %s" team.Name)
//  bestTeams |> List.iter (fun team -> printfn "Team Wins: %d" team.Stats.wins)

//  let calculateSuccessPercentage team =
//      float team.Stats.wins / float (team.Stats.wins + team.Stats.losses) * 100.0

//  let successPercentages = bestTeams |> List.map calculateSuccessPercentage
//  let avg = List.average successPercentages

//  printfn "The percentage of the team is %f" avg

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

