# Endless Runner 3D Game

This project is an **Endless Runner 3D game** developed using **Unity Hub**. In this game, the player controls a character that automatically moves forward on a track. The primary goal is to avoid obstacles that randomly appear on the track while attempting to achieve the highest possible score. The game continues indefinitely until the player collides with an obstacle, at which point the game ends, showing the player's score and the highest score achieved.

## Table of Contents

- [About](#about)
- [Features](#features)
- [How to Play](#how-to-play)
- [Project Setup](#project-setup)
- [Scripts Overview](#scripts-overview)

## About

This Endless Runner game is designed for those who want to have fun with a competitive score-based game.

The player’s character moves automatically along the track, and the player can control the character’s movement to the left or right to avoid randomly generated obstacles. As the player progresses, their score increases based on the distance traveled. When the player collides with an obstacle, the game ends, and a game-over screen is displayed, showing the final score and offering options to restart or quit.

### Key Components:
- **Dynamic Obstacles**: Obstacles are spawned randomly in the path of the player. These obstacles appear and disappear as the player advances, creating an endless challenge.
- **Endless Track**: The background and track are designed to loop seamlessly, providing an endless play experience.
- **Score Tracking**: Both the current and highest scores are displayed to the player, encouraging them to keep improving their performance.

## Features

- **Endless Movement**: The character moves forward continuously with increasing speed.
- **Dynamic Obstacles**: Randomly generated obstacles appear in the player’s path, requiring fast reflexes to avoid.
- **Score System**: Tracks both the player's current score and the highest score achieved during the session.
- **Game Over Screen**: When a collision occurs, the game ends and shows the player’s final score along with options to restart or exit the game.
- **Background Movement**: A looping background is used to create the illusion of infinite progression.
- **Audio**: Background music plays throughout the game, enhancing the gaming experience.

## How to Play

1. **Start the Game**: Press the **play** button to begin.
2. **Move the Character**: Use the **Arrow Keys** or **A (left)** and **D (right)** keys to move the player’s character left and right.
3. **Avoid Obstacles**: Obstacles will randomly appear on the track. Move the player to avoid these obstacles.
4. **Game Over**: If the player collides with any obstacle, the game ends.
5. **Restart**: After the game ends, you can view your score and restart game.

## Project Setup

To run this project on your local machine, follow these steps:

1. **Clone the repository**:
- git clone https://github.com/GameIUST4031/HW4_EndlessRunner.git

2. **Open in Unity**:
- Open the project in Unity. Ensure you are using a compatible version of Unity.

3. **Play the Game**:
- After the project is open, click the **Play** button in Unity to run the game and start playing.

## Scripts Overview

Here’s a breakdown of the key scripts in the project:

- **GameManager.cs**: Handles the main game logic, such as spawning obstacles, generating the looping background, and controlling game flow.
- **PlayerMovement.cs**: Controls the player’s character movement, including automatic forward movement and left/right movement using the keyboard.
- **CollisionDetect.cs**: Detects collisions between the player and obstacles. If a collision occurs, it triggers the game over sequence.
- **ScoreHandler.cs**: Manages the display of the player’s current score and the highest score achieved.
- **AudioHandler.cs**: Plays background music throughout the game and manages audio settings.
- **PopupMessage.cs**: Displays the game over screen, showing the player’s score and providing options to restart or exit the game.

