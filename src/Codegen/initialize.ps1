# Generate authentication schema
hygen data model --name Role --schema Auth
hygen data model --name RoleClaim --schema Auth
hygen data model --name User --schema Auth
hygen data model --name UserClaim --schema Auth
hygen data model --name UserLogin --schema Auth
hygen data model --name UserRole --schema Auth
hygen data model --name UserToken --schema Auth

# Generate data schema
hygen data model --name Achievment --schema Data
hygen data model --name Area --schema Data
hygen data model --name HeroClass --schema Data
hygen data model --name HeroSkill --schema Data
hygen data model --name ItemClass --schema Data
hygen data model --name ItemSkill --schema Data
hygen data model --name ItemType --schema Data
hygen data model --name MobClass --schema Data
hygen data model --name MobSkill --schema Data
hygen data model --name MobType --schema Data
hygen data model --name NpcClass --schema Data
hygen data model --name NpcSkill --schema Data
hygen data model --name NpcType --schema Data
hygen data model --name Profession --schema Data
hygen data model --name Quest --schema Data

# Generate game schema
hygen data model --name Area --schema Game
hygen data model --name Channel --schema Game
hygen data model --name Game --schema Game
hygen data model --name Hero --schema Game
hygen data model --name Leaderboard --schema Game
hygen data model --name Mob --schema Game
hygen data model --name Npc --schema Game
hygen data model --name Season --schema Game

# Generate web project areas
# hygen web area --name Accounts
# hygen web area --name Chat
# hygen web area --name Heroes
# hygen web area --name Play
# hygen web area --name Public
# hygen web area --name Seasons
# hygen web area --name Wiki