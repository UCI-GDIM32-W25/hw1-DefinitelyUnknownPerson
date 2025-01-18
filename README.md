[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects:
- Player
  - Actions
    - Movement (WASD)
    - Planting Seeds (Space)
  - Attributes
    - Sprite
    - Movement Speed
    - Size
    - Color
- Seeds
  - Actions
    - None
  - Attributes
    - Sprite
    - Size
    - Color
- Seeds planted UI
  - Actions
    - Change Counter
  - Attributes
    - Text Size
    - Text Color
    - Number of Seeds Planted
- Seeds remaining UI
  - Actions
    - Change Counter
  - Attributes
    - Text Size
    - Text Color
    - Number of Seeds Remaining

When Player hits space, a seed object is created. When this occurs, seeds remaining -1, seeds planted +1. Does not work if seeds remaining <= 0.

## Devlog
My initially proposed plan was mostly the same as the activity answers, and I did not deviate from the plan during the coding process. The player movement was written in Update(), while the planting of seeds was handled by the PlantSeed() method, which first checked that the player had at least one seed left before planting the seed. Then, this method calls the UpdateSeeds() method in the PlantCountUI script, which updates the Text_SeedsPlantedNum and Text_SeedsRemainingNum texts with the current number of planted seeds and seeds remaining, respectively. Just like the plan, the plant object has no actions and therefore has no script attached to it, as it does not do anything other than be created at the player's location. I did not end up adjusting the color of any of the sprites, nor did I adjust the text size, though they are possible attributes to adjust if need be. One thing I learned during this process is that you have to attach a script to an object before it can be used by another script (in the case of attaching PlantTextUI to the Player script).

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting your break-down activity to the code that you wrote. You may want to provide more details to make sure you get full credit in future Devlogs, but this Devlog is satsifactory and will recieve full marks.

Next time, please include your break-down activity notes in the Devlog itself insteaad of just linking them, and consider formatting your break-down activities with the hyphen '-' symbol as suggested above. You can also remove the prompt text. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
