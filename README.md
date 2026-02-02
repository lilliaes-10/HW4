# HW4
## Devlog
In the game, the model-view-controller pattern is used to keep the Player code decoupled from other systems like PipeSpawner and ScoreManager in this game. The controls are handled in PLayerController class. It handles player input, applying jump forces, and detecting collisions. The methods Update(), OnCollisionEnter2D(), and OnTriggerEnter2D() exist to control how player behaves without focusing on the appearance of the player. To keep the control systems decoupled, the game needs events and a Singleton. The PlayerController invokes events such as OnPlayerDied oor OnScoreChanged instead of directly calling UI. The ScoreManager class is used as a Singleton using a static Instance variable. It also listens to the events and updates the UI. By using events and a Singleton, the PlayerController doesn't need a direct relation to the UI or visual systems. It helps to keep layers independent, and makes code easier to maintain and debug.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
