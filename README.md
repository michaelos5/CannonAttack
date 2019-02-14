CannonAttack
Text Based Game Demonstrating usage of Test Driven Development(TDD)

-----------------------------------------------------

---> Utilizes NUnit3 for tests
---> Written in C#

Overview
-----------------------------------------------------
CannonAttack is a simple text based game in which a player enters an 
angle and velocity of a cannonball to hit a target at a given distance. 
The game uses a basic formula for calculating the trajectory of the 
cannonball (will be given) and the player keeps taking turns at shooting 
at the target until it has been hit.

Requirements
-----------------------------------------------------
1.	Windows Console Application; 
2.	Player identified by an id, default is set to a constant "Human"; 
3.	Single player only, no multi-play 
4.	Allow player to set Angle and Speed of the Cannon Ball to Shoot at a Target; 
5.	Target Distance is simply the distance of the Cannon to Target, and is created randomly by default but can be overridden; 
6.	Angle and Speed needs to be validated (specifically not greater than 90 degrees and Speed not greater than speed of light); 
7.	Max distance for target is 20000 meters; 
8.	Base the algorithm for the calculation of the cannons trajectory upon the following C# code (distance and height is meters and velocity is meters per second):
distance = velocity * Math.Cos(angleInRadians) * time;
height = (velocity * Math.Sin(angleInRadians) * time) - (GRAVITY * Math.Pow(time, 2)) / 2; 
9.	A hit occurs if the cannon is within 50m of the target; 
10.	Display number of shots for a hit 
11.	Game text will be similar to following: 
	Welcome to Cannon Attack
	Target Distance:12621m
	Please Enter Angle:40
	Please Enter Speed:350
	Missed cannonball landed at 12333m
	Please Enter Angle:45
	Please Enter Speed:350
	Hit - 2 Shots
	Would you like to play again (Y/N)
	Y
	Target Distance:2078m
	Please Enter Angle:45
	Please Enter Speed:100
	Missed cannonball landed at 1060m
	Please Enter Angle:45
	Please Enter Speed:170
	Missed cannonball landed at 3005m
	Please Enter Angle:45
	Please Enter Speed:140
	Hit - 3 shots 
	Would you like to play again (Y/N)
	N
	Thanks for playing CannonAttack



Additional Feature
-----------------------------------------------------
In addition to these requirements a new feature will be added that gives the cannon a chance to explode
if the velocity entered by the user is deemed dangerous(Over 100000000) then the cannon will explode.