All Credit Goes to Feverdream Johnny(John Ellis) for the original Impact Controller. This is my modded(dare I say improved) version. The added code may be a bit scuffed(hacky) on the inside but performance impact should be negligible and the UX is just as good as the original.

## Additions
- Modded default controller w/ sound, better values and different ground detection layer.
- Input System: New Input System support!
- Customization: Camera landing bow
- Feature: Third-person camera offset
- Toggle: Make player art always face camera

## Details
#### Camera Landing Bow
This is normally non-adjustable and I find it to be far too extreme, so I added a float that controls specifically that, defaults to the standard value of 0.2f
#### Third Person Camera Offset
It's a bit of a janky implementation, but this does what it says on the tin. When you are not in first person, your camera will be offset by this vector multiplied by the perspective slider(though it maxes around 0.5 perspective and goes back to 0 around 1, I do not know why and have hence limited the perspective slider to 0.5f)
#### Player Art Toggle
This toggle makes your player art permanently face toward where your camera is looking, normally this is done only when aiming but now you have this toggle for first person games or third person where you may want to strafe or backpedal without having to aim(or if you don't want an aim button).

Small note, this was the default behaviour of attaching art(or objects) to the controller previously but was lost when somewhere along the line it was made so that the player controller never actually rotates, regardless it was a simple thing to patch back in.

## Wishlist(things I might add)
- A toggle button that changes shoulders in TPS mode, should technically be a simple extra control and multiplying the x value of my offset by -1, but I have a feeling the hackiness of the offset is gonna make that look janky in real time.
- Allow the player to go between first and third-person via scrollwheel a-la Fallout 3 and NV, should actually be relatively easy but I haven't looked at the input system at all yet and don't expect to make a 3rd person game soon.
