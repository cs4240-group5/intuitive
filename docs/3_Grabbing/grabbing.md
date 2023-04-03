# Grabbing Room
Primary Designer: [Choong Zhan Hong](https://github.com/choongzhanhong)

Directory
- [Overview](#overview)
- [Designing for Height](#designing-for-height)

## Overview
The Grabbing Room is meant to visualise the concepts around designing for user interaction in VR.
The most common interaction would often be grabbing of objects, hence the importance of understanding design principles
around grabbing and interaction with objects.

## Designing for Height
VR users can use programmes sitting or standing, and VR affords a wide range of movement, but it is still important to
make the movement comfortable. It is thus good to constrain design to the user's own physical constraints, or even the
VR headset's technical constraints (such as keeping within tracking range of some VR sets).

As such, a few concepts are explored in this room.
### Height of Interactables
To summarise the best practices found online (See [References](#height-ref)), the following are some guidelines to follow:

- Keep interactable objects between desk (1m) to eye-level height.
- Design for standing or sitting users. You should decide beforehand if your user should be standing or sitting.
  - You can guide user's behaviour through built-in constraints. *Example: angled screens that can be viewed while standing
	but not while sitting.*

#### References {#height-ref}
## Affordances for Interaction
It is important to distinguish interactable objects from environmental or cosmetic elements. In scenarios such as games,
this gives the user an intuitive grasp of what actions they can take. Your program should thus indicate to the user what are
the *affordances* of the objects around them.

### Outlines
A very simple way to indicate such affordances is through outlining your objects to make them stand out. In my scene, I made use of
a free and super comprehensive asset that
comes with a variety of outline styles.

To name a few, you can outline objects if they're visible/hidden, or even show a silhouette when it's behind a wall. So,
there's many ways to provide outlines in different scenarios. Imagine: you would less obvious outlines in a puzzle game
(to not make things too obvious) or to make your scene more immersive/less visually cluttered.

### Varied Affordances
Apart from interactions with 3D objects, the user can sometimes interact with UI as well. So, this scene
also demonstrates a very simple way to differentiate UI from 3D objects simply using different pointers.
Most UI interactions use a "laser pointer" to differentiate from 3D objects.

#### References {#affordance_ref}


---
**CS4240** Interaction Design for Virtual and Augmented Reality AY2022/2023
 
Project Group 5 - intUItive! [(Back to main page)](../README.md).