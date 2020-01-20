# CS342-Project01
Project 01 for Experimental Game Development. Two-player Cooperative

Members: In Park, Jiajian Zhang

Project name: Tethered
/////////////////////Instructions///////////////////////
Unzip the game folder and click on the Project01.exe file. This executable file will run the game. 

Because the game is for two players, AWD controls left, up, and right respectively for Player 1 while the Arrow keys are for Player 2.

/////////////////////Game Concept///////////////////////
Game Tagline
  You and another player go out for a jog and avoid obstacles while making sure that your connecting tether does not touch obstacles. 
Gameplay Synopsys
  Overview
    Both players must reach the end of the level by coordinating their movements and avoiding obstacles that block their way. Secondly they must be aware of the connecting tether between them. If that tether touches the obstacles, then the players restart. 
Gameplay Descriptions
  Player 1
    Can Jump
    Can move left and right
  Player 2 
    Can Jump
    Can move left and Right
Gameplay Mechanics
  The players’ controls are exclusive. Player 1’s actions do not affect Player 2’s actions. If Player 1 chose to jump, Player 2 would not need to jump either. However they do share some mechanics. The connecting tether between the two players cannot touch the obstacles. Either player cannot collide with obstacles either. If they do, both players must restart the level. 
  The goal is to make it to the end of the level together as a team. Player 1 cannot advance without Player 2. 
Controls and Interfaces
  Movement
    Player 1
      Left - A
      Up - W
      Right - D
    Player 2
      Left - Left Arrow
      Up - Up Arrow
      Right - Right Arrow
  Pause Menu
    Accessed by pressing the Escape Key while in game
    The players can choose to:
      Resume Play
      Quit to Menu
  Main Menu
    The players can choose to:
      Play game 
      Quit game
  Rules
    Obstacles
      They will randomly placed along either players’ path or in between their paths. 
      Players cannot touch Obstacles
      If either player collide with obstacles, both players restart at the beginning of the level.
      Players’ tether cannot touch obstacles
      If players’ tether touches obstacles, then they restart at the beginning of the level.
    Players’ Tether
      Remains connected between the two players.
    Scoring/Winning Conditions
      If Players reach end of the level, they win. 
      Players have infinite tries. 
