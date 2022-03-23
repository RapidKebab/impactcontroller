All Credit Goes to FeverDevJohnny(John Ellis) for the original Impact Controller. This is my modded(dare I say improved) version. The added code may be a bit scuffed(hacky) on the inside but performance impact should be negligible and the UX is just as good as the original.

## Additions
- Customization: Camera landing bow
- Feature: Third-person camera offset
- Toggle: Make player art always face camera

## Details
- Camera Landing Bow
This is normally unadjustable and I find it to be far too extreme, so I added a float that controls specifically that, defaults to the standard value of 0.2f
- Third Person Camera Offset
It's a bit of a janky implementation, but this does what it says on the tin. When you are not in first person, your camera will be offset by this vector multiplied by the perspective slider(though it maxes around 0.5 perspective and goes back to 0 around 1, I do not know why)
- Player Art Toggle
This toggle makes your player art permanently face toward where your camera is looking, normally this is done only when aiming but now you have this toggle for first person games or third person where you may want to strafe or backpedal without having to aim(or if you don't want an aim button).

Small note, this was the default behaviour of attaching art(or objects) to the controller previously but was lost when somewhere along the line it was made so that the player controller never actually rotates, regardless it was a simple thing to patch back in.
