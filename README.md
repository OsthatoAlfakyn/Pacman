Frustration-man
============

![Screenshot](http://i.imgur.com/GQcmfQY.png)

Based on https://github.com/vilbeyli/Pacman.

The project is currently configured for the intense version. The relevant variables to change are exposed in the inspector as fields. The slow factor is under pacman, the others under Game Manager.

| Field                  | Normal | Intense | Explanation
| ---------------------- |--------| ------- | ---
| Slow Factor            | 0.5    | 0.33    | Speed multiplier while slowed
| Always Leave Slow      | Off    | On      | Whether Pacman leaves slow in empty corridors
| Spawn Clear Slow Range | 5      | 4       | The range from spawn where slow is cleared on respawn
| Ghost Clear Slow Range | 8      | 8       | The range of the slow-clearing "explosion" when eating a ghost
| Randomise Spawn        | Off    | Off     | Whether spawn is set on a random pellet upon entering a level
