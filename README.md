Frustration-man
============

Based on https://github.com/vilbeyli/Pacman.

**Videos** can be seen here: [Normal](https://drive.google.com/file/d/1toJzWOEyYMaEvVxpQqhGICxoDhGrf1Ns/view), [Intense](https://drive.google.com/file/d/1p8tfuAQazJ-3CH9lxXHfrNstSjMSYVXB/view)

The project is currently configured for the intense version. The relevant variables to change are exposed in the inspector as fields. The slow factor is under pacman, the others under Game Manager.

| Field                  | Normal | Intense | Explanation
| ---------------------- |--------| ------- | ---
| Slow Factor            | 0.5    | 0.33    | Speed multiplier while slowed
| Always Leave Slow      | Off    | On      | Whether Pacman leaves slow in empty corridors
| Spawn Clear Slow Range | 5      | 4       | The range from spawn where slow is cleared on respawn
| Ghost Clear Slow Range | 8      | 8       | The range of the slow-clearing "explosion" when eating a ghost
| Randomise Spawn        | Off    | Off     | Whether spawn is set on a random pellet upon entering a level
