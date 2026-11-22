# MG7
## Devlog
I created an array for the number of sparrows in the scene. I also added variables for the player so I could get the Vector3 position of the player and see when it gets into the interaction distance that I set. In the update method, it loops through the whole array for each sparrow. In each loop, it checks the distance between the player and the sparrow in the array using Vector3.Distance(). If the distance is less than or equal to the interaction distance, then calls SetActive and sets it to true which then triggers the OnEnable in Bird.cs. 

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
