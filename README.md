[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
HW1 break-down exercise: https://docs.google.com/document/d/1aKXmnD89qfrvvGAF0bAgR_yGSzhOZjHMFQ8cwOKksck/edit?usp=sharing

My initially proposed plan was mostly the same as the activity answers, and I did not deviate from the plan during the coding process. The player movement was written in Update(), while the planting of seeds was handled by the PlantSeed() method, which first checked that the player had at least one seed left before planting the seed. Then, this method calls the UpdateSeeds() method in the PlantCountUI script, which updates the Text_SeedsPlantedNum and Text_SeedsRemainingNum texts with the current number of planted seeds and seeds remaining, respectively. Just like the plan, the plant object has no actions and therefore has no script attached to it, as it does not do anything other than be created at the player's location. I did not end up adjusting the color of any of the sprites, nor did I adjust the text size, though they are possible attributes to adjust if need be. One thing I learned during this process is that you have to attach a script to an object before it can be used by another script (in the case of attaching PlantTextUI to the Player script).

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
