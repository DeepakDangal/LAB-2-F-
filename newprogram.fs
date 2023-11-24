type Coach = {
    Name: string
    formerPlayer: bool
}

type Stats = {
    wins: int
    losses: int
}

type Team = {
    Name: string
    coach: Coach
    Stats: Stats
}
let teams = [
    { Name = "chicago Bulls"; coach = { Name = "Billy Donovan"; formerPlayer = true }; Stats = { wins = 2344; losses = 2254 } }
    { Name = "Miami Heat"; coach = { Name = "Erik Spoelstra"; formerPlayer = true }; Stats = { wins = 1475; losses = 1328 } }   
    { Name = "Golden State Warriors"; coach = { Name = "Steve Kerr"; formerPlayer = true }; Stats = { wins = 2923; losses = 3098 } }
    { Name = "Milwaukee Bucks"; coach = { Name = "Adrian Griffin"; formerPlayer = true }; Stats = { wins = 2340; losses = 2103 } }
    { Name = "Toronto Raptors"; coach = { Name = "Darko Rajakovic"; formerPlayer = true }; Stats = { wins = 1071; losses = 1175 } }
]


let bestTeams = teams |> List.filter (fun team -> team.Stats.wins > team.Stats.losses)

bestTeams |> List.iter (fun team -> printfn "Team Name: %s" team.Name)
bestTeams |> List.iter (fun team -> printfn "Team Wins: %d" team.Stats.wins)

let calculateSuccessPercentage team =
    float team.Stats.wins / float (team.Stats.wins + team.Stats.losses) * 100.0

let successPercentages = bestTeams |> List.map calculateSuccessPercentage
let avg = List.average successPercentages

printfn "The percentage of the team is %f" avg

 