# GameEngineDesignBonus
100787491 = 37 = Prime

The singleton pattern was implemented by creating a PowerupManager script which creates an instance to start and end the speed powerup that i created in other scripts. It was implemented in this manner because I think it is the most organized way of keeping all functionality of the powerup system seperate. This implementation benefits the game by allowing the developer to create multiple powerups and start and end them in the same script, while having specific scripts for each powerup to keep everything tidy.

When you start the game, you control the player with A = left, D = right, Space = jump. You must reach the highest point of the level which is 2 blocks higher than the starting point. On the way you will collect a gold speed powerup which will temporarily increase the player's speed, until they reach a point where the powerup wears off.

I had to delete the library folder from the project files because git would not let me upload the game with it for some reason and i was running out of time to submit, although it should be fine to put a regular unity project library files into mine. Sorry for the inconvenience.
