# FactionFixer

[RimWorld](https://rimworldgame.com) mod to fix saves that were corrupted by the [`GiddyUp 2 Forked`](https://steamcommunity.com/sharedfiles/filedetails/?id=3246108162) mod. I haven't found exactly what mod combo causes it, but the issue fundamentally lies with GU2.

RimWorld fails to generate leader pawns for factions and the factions are not committed to the world. On one of my recent saves, I didn't notice until I was really curious as to why I was getting zero raids or visitors.
Wrote this mod in order to save the save.

## Usage

- Install the mod.
- Enable developer mode ingame.
- Remove [`GiddyUp 2 Forked`](https://steamcommunity.com/sharedfiles/filedetails/?id=3246108162) from your modlist, if you haven't already.
- Add `FactionFixer` to your modlist. (leave all the mods in your save loaded, ESPECIALLY faction mods)
- Once the mods are loaded in this configuration, load your save.
- **Open the world/planet map**.
- Open the developer action menu at the top of the screen. It is a cog with a play symbol.
- Under the category "FactionFixer", find "Regenerate Factions".
- Watch as the factions and their settlements are generated!


## If you encounter any issues or wish to expand the mod

This mod is made specifically for fixing the corruption caused by the [`GiddyUp 2 Forked`](https://steamcommunity.com/sharedfiles/filedetails/?id=3246108162) mod, however it might work for similar scenarios with the same or similar symptoms. **YMMV**.

I do not really want to maintain and update this project for edgecases and other corruptions and whatnot, so if you want to turn this into a bigger mod that fixes more corruptions or is more versatile as a save recovery tool, you have my permission.

HOWEVER, please credit this repo in the README and you may NOT commercialize/make money from the mod AND you must make available the source code.