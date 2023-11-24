# LAB-2-F-
In this Lab we will filter some lists from Data given by NBA stats records of past year and following this steps as given below:
Assignment Instructions
Records
In this exercise, you are a big sports fan and you have just discovered a passion for NBA basketball (Schierboom, 2022, March 23). Being new to NBA basketball, you are doing a deep dive into NBA history, keeping track of teams (coaches, their win/loss stats), and comparing them against each other.

Define the Model
Define the Coach record with the following two fields:

Name: the coach's name (of type string)
FormerPlayer: indicates if the coach was a former player (of type bool)
Define the Stats record with the following two fields:

Wins: the number of wins (of type int)
Losses: the number of losses (of type int)
Define the Team record with the following three fields

Name: the team's name (of type string)
Coach: the team's coach (of type Coach)
Stats: the team's stats (of type Stats)

Create a List of 5 Teams

Create coaches, stats, and teams based on the following links. There must be 5 teams in total. 
Coaches
Win/Loss Stats

Now add the 5 teams to a list.

Filtering the List

Create a list of successful teams by filtering the list we created. The criterion to be a successful team is:
Number of wins must be greater than number of losses.

Mapping the List
Using the map function, calculate the success percentage of each team. Success percentage can be calculated by:
(Wins )/((Wins+Losses))×100

Tip: Convert integers to floats before performing division for correct results.

Discriminated Union:

In this exercise, it is Valentine's Day (Schierboom, 2022, March 24), and you and your partner are planning on doing something nice together.
Your partner has lots of ideas, and you would like to calculate the budget for your special evening.
Your partner proposes the following ideas:

Playing a board game
Chill out
Watch a movie
Go to a restaurant
Take a long drive
You have five tasks to help choose your Valentine's Day activity.

Define the Cuisine
Your partner has selected two possible restaurants: one based on Korean cuisine and the other based on Turkish cuisine.

Define the Cuisine discriminated union to represent these cuisines as the following two cases: Korean and Turkish.

Define the Movie Genres
There are tons of movies to choose from and different kinds of screens.

Define the MovieType discriminated union to represent the following experiences as cases: Regular, IMAX, DBOX, RegularWithSnacks, IMAXWithSnacks, and DBOXWithSnacks

Define the Activity
As already established, your partner has come up with five different activities: playing a board game, chilling out, watching a movie, going to a restaurant, and taking a walk

Define the Activity discriminated union to represent these activity types:

BoardGame: no associated data
Chill: no associated data
Movie: has its Genre as associated data
Restaurant: has its Cuisine as associated data
LongDrive: has an int representing the number of kilometres and a float representing fuel charges per kilometre for your car

Calculate the Budget
Finally, you are ready to plan your finances and your partner's ideas. Implement a function named calculateBudget that takes an Activity value and returns the price based on the following description:

Playing a board game costs 0 CAD.
Chilling out costs 0 CAD.
Watching a movie (cost per head)
Regular — 12 CAD
IMAX — 17 CAD
DBOX — 20 CAD
All other options with snacks cost an additional 5 CAD.
Go to a restaurant: Korean costs $70 CAD per couple; Turkish costs $65 CAD per couple.
Long drive: Calculate the cost by multiplying fuel per kilometre and the number of kilometres.
