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
