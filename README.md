# Jeopardy
### By Wei, Misaki, Jake, and Andrew
#### Created 04 Feburary, 2020

## Description  

Jeopardy is an American television game show created by Merv Griffin. The show features a quiz competition in which contestants are presented with general knowledge clues in the form of answers, and must phrase their responses in the form of questions.

Additional information for this game can be found on [Wikipedia](https://en.wikipedia.org/wiki/Jeopardy!)
 
## Links:

* Github - [Wei](https://github.com/weidai07/Jeopardy)
* Github - [Misaki](https://github.com/misakimichy/Jeopardy)
* Github - [Jake](https://github.com/JakeAsh22/Jeopardy)
* Github - [Andrew](https://github.com/abatesaccs/Jeopardy)

## Setup/Installation Requirements:

1. Open - Click on any of the group member names listed above 
2. Clone the repository to local machine 
3. Build and Run project

  - $ dotnet restore - when you are ready to restore the dependencies of the project
  - $ dotnet build - when you are ready to build the project
  - $ dotnet ef migrations add Initial - to build the table in MySQL
  - $ dotnet ef database update - to update the table in the database 
  - $ dotnet watch run - to run the project and play the game 
  
### Specification

* Play individually or in groups.
* Pick a category and a point value.
* Click on the chosen box for the question.
* Player must give the answer in the form of a question before clicking again. The host may want to set a time limit for answering the question.
* If the player or team is correct, they are awarded the point value of the question. 
* Continue until all questions have been answered. The player or team with the most points wins.
* [Game Rules Source](https://www.iup.edu/teachingexcellence/reflective-practice/past-events/2008-09/sample-games-to-be-used-in-the-classroom/instructions-for-playing-jeopardy/) 

## Known Bugs

* _None at this time_

## Technologies Used:

* C#
* .NET
* JService API
* SQL
* LINQ 

### License:

Copyright (c) 2020 Wei, Misaki, Jake, and Andrew

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
