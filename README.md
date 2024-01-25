# ProjectName
_by Kim Robinson & Henry Oberholtzer_

## Description

###  This app will allow a user to:
    - Win a game by collecting the most "books" of cards (four of a kind)
    - Draw cards from a deck of 52, based on a standard 52 card deck.
        - Card deck should be "shuffleable", which is to say drawable at random
    - Players are dealed hands of seven
    - Any group of four of a kind can be marked as book, and this is checked and saved in the player
    - Player can request card of a specific type from their opponent
    - If the opponent does not have a the card, the player gets a card from the deck.
    - Play repeats until all cards have been drawn and the player with the most four of a kind wins

### Structure
- Game
    - > Deck, initializes with 52 cards
    - > DealCards, (random?)
- Player
    - > Hand
    - > Name
    - > Score

Index           | /game                         | GET   | Shows all games in progress                       |
New Game        | /game/new                     | GET   | Offers a form to create a new game                |
Create Game     | /game/                        | POST  | Creates the game on the server                    |
Show Game State | /game/:id                     | GET   | Shows the current status of the game              |
Deal Cards      | /game/:id/deal                | POS   | Deals cards to all players in the game            |
New Game Player | /game/:id/player/new          | GET   | Offers a form to create a new player for the game |
Create Player   | /game/:id/player/             | POST  | Creates the player on the server                  |
Create Player   | /game/:id/player/:id          | POST  | Creates the player on the server                  |
Delete Player   | /game/:id/player/:id/delete   | GET   | Removes a player on the server                    |




### Technologies Used

* C#
* MSTest
* TDD (Test Driven Development)
* RGR Workflow (Red Green Refactor)
* .Net
* Git
* NuGet package with dotnet CLI

## Setup/Installation Requirements

_Currently not viewable on gh-pages. Please follow steps below to set up locally_

1. Navigate to [my github repository](https://github.com/kimmykokonut/XXX) for this project 

2. Click the `Fork` button and  you will be taken to a new page where you can give your repository a new name and description. Choose "create fork".

3. Click the `Code` button and copy the url for HTTPS.

4. On your local computer, create a working directory for my files and name appropriately.

5. On your terminal, type `$ git clone 'url'` (using the url from step 3.)

6. Once you have this on your local directory, if you ever want to push it to GitHub, you need to do these steps first so Git knows to ignore the obj and bin directories:
`$ git init` to initialize Git (if cloning, this step automatically happened)
`$ touch .gitignore` adds .gitignore file in the root directory. 

7. On your terminal, type `$ code .` to open in VS Code.  If you do not have VS Code Editor, you may download [here](https://code.visualstudio.com/)

8. In the .gitignore file, add `bin` and `obj` and save.
In the Terminal:
`$ git add .gitignore`
`$ git commit -m 'add .gitignore`
`$ git push origin main`

9. While in the terminal, navigate to the project's production directory currently called "ProjectName" and type `$ dotnet build` to compile the application's code.

10.  To use MSTest, you need to use the NuGet package manager to install the packages in the .csproj file.  Navigate to the ProjectName.Tests directory in the terminal and run the command `$ dotnet restore`

11.  Optionally you can use a file watcher so you don't have to restart the server every time the code changes. Run this command `$ dotnet watch run` to make the server automatically update.

12. In the terminal, type `$ dotnet run` (to compile and execute the console application ).

13. Enjoy!  You can close the development server at anytime by entering `ctrl` + `c` in the terminal.

* To run tests using MSTest, navigate to the ProjectName.Tests directory in your terminal and type `$ dotnet test`

## Known Bugs
* None known at this time

## License
MIT License. See license.md for further information