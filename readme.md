# Interactive systems - Practice 1

## Upgrades
### Event system
Instead of following the roll a ball tutorial step by step I decided to implement a robust event oriented system
to properly segregate all responsibilities.

This architecture has several benefits:

- First we can segregate all the gameobjects logic in several scripts avoiding excessively long and coupled functionality.
- We also avoid the pain of having to relate all the gameobjects by dragging them through the editor or having to acces different components of the same game object in the same script.
- The use of this architecture also made implementing features like the reset game button absolutely painless.

### Main character model and animations

I added full fledged 3D model with textures, walking and idle animations. The animations are blended using unity animator system and 
blend trees. The transitions are a little bit sloppy using the keyboard but a game controller gives a much better feel.


### Builds

I builded this project usign Ubuntu 20.04, so I could not test the windows executable, in the case
that there is any error please let me know