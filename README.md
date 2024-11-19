# Animal Runner Game

This repository contains the source code for a simple Unity project, **Animal Runner Game**, where players control a character to shoot projectiles at incoming animals. The game demonstrates fundamental Unity concepts like movement, spawning, collisions, and basic game logic.

---

## **Table of Contents**
1. [Project Overview](#project-overview)
2. [Features](#features)
3. [Scripts](#scripts)
4. [Setup Instructions](#setup-instructions)
5. [Future Improvements](#future-improvements)

---

## **Project Overview**
This game is a beginner-friendly Unity project, showcasing:
- Object spawning and destruction.
- Basic player controls using keyboard input.
- Simple collision detection and interaction between objects.
- Projectile mechanics.

---

## **Features**
- Player movement constrained to a horizontal range.
- Shooting projectiles to destroy incoming animals.
- Animals spawn at random positions and intervals.
- "Game Over" logic when animals pass the player.

---

## **Scripts**
The repository includes the following scripts:

1. **DestroyOutOfBounds.cs**:
   - Removes objects (animals or projectiles) that go beyond the game bounds.
   - Displays "Game Over" if an object moves out of the lower bounds.

2. **DetectCollisions.cs**:
   - Handles collision detection between animals and projectiles.
   - Destroys both the animal and the projectile upon collision.

3. **MoveForward.cs**:
   - Controls the forward movement of projectiles.
   - Speed can be adjusted using a public variable.

4. **PlayerController.cs**:
   - Manages player movement using horizontal input.
   - Allows the player to shoot projectiles by pressing the spacebar.
   - Keeps the player within a defined horizontal range.

5. **SpwanManager.cs**:
   - Spawns animals at random horizontal positions within a defined range.
   - Uses `InvokeRepeating` to spawn animals at regular intervals.

---


