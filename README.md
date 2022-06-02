# Art503-Project

Title: StoneKeep

Using Unity as the game engine.

Coded in C#.

Concept:

Stone Keep is a 2D action platformer featuring four playable characters that have united to fight back against the evil that terrorizes their home. Together they use their unique skills to defeat the great evil. The goal of the player is to navigate the stages and defeat enemies so they can confront the final antagonist to save the kingdom.

Story:
    The eldest son of the royal family ascended to power through bloodshed and treachery, and plunged the kingdom into a period of darkness and war. He was usurped and exiled by his younger brother, but has festered with hatred and jealousy, believing himself to still be the rightful heir to the throne. Having allied himself with monsters and magical forces, he has returned to the castle to seize control, and our heroes, who remember the bloody past, are determined to stop him from throwing their home into chaos once again.

Gameplay:

Characters and Character Swapping:

    The primary game mechanic of Stone Keep is the ability to play and seamlessly swap between four playable characters. Each character has unique attacks, movement, and abilities. The goal is to have each character feel like a different experience. The player is given the ability to change characters at will and make use of them how they will, whether that be swapping when one character is more viable or playing through the game using only their favorite, as all levels are designed to be doable by all characters. All characters are tied to the same health bar and control scheme to reduce player confusion and create more game flow. Characters are also all visually distinct to ensure that players recognise which character they are playing and can get a sense of what they do from their looks. The hope is that players can use this mechanic to help them find a gameplay experience that suits them when making it through the game. 

The game has four different archetypes which will be discussed more in-depth in the game elements section. These archetypes are swapped between by pressing 1, 2, 3, and 4 on the keyboard at any point in time when the player is not undergoing a separate action, such as jumping or attacking. Movement is tied to both the W, A, and D, or the Up, Left, and Right keys to give players a choice to find the control scheme that feels more comfortable to them. The spacebar is also tied to jump to help provide an alternate setup for some of the more complicated puzzles. For the fourth character, the mage, the spacebar is the only button tied to the character’s movement ability, as the character has a short-range teleport that can go upwards or horizontally rather than a jump. Attacks are assigned to z which has a different variation per character. The attacks are a split between close ranged for characters 2 and 3, and mid-long ranged for characters 1 and 4. 

Each playable character has: 
Unique movement speed 
Unique movement ability 
Unique attack 
Four Character Archetypes:
Archer (Character 1)
Rogue (Character 2)
Tank (Character 3)
Wizard (Character 4)

Platforming:

    Platforming is an extremely important mechanic in Stone Keep as the game is an action platformer. The objective of the platforming is to provide the player with an engaging puzzle mechanic that when combined with the other game mechanics forms a fun gameplay loop that keeps the player invested in the game. It is the primary form of gameplay as it takes up most of the game space and is heavily built into the map design. The character abilities work with the platforming to provide various optional paths or ways to approach different sections. Platforms within the game are all formed of combinations of cubes of the same size (roughly equivalent to the player hitbox) that allow for consistency in platforming mechanics. The player is expected to maneuver themselves around the level using the various platforms to reach the final boss fight at the end. 

    The game’s platforming works using a simple jump system, in which every character has some form of jump, or short-range teleport in the Mage’s case, that allow them to traverse the platforms. Players start on the bottom level of the Stone Keep and must reach the top. From the ground all characters have the ability to jump at least one block high, then from that point on they can continue to jump to reach other platforms. Generally, jumping between platforms is simple and won’t cause too much frustration in the player. There are more challenging sections, however, that ask the player to test their skills to make it through. Some sections appear simple, but require the player to be patient and not get ahead of themselves or risk starting the section over. 

The game has been structured so all characters can complete it, but the platforming in the map is designed to have sections accessible only by certain characters using their unique abilities. The Archer is able to wall jump to climb through the level and possibly pass some enemy encounters. The Rogue can double jump and therefore access areas that require a better jump height which may lead to an easier playthrough if done successfully. The Tank builds speed as he moves to make up for his low jump height. The Mage can teleport through some walls and get the player out of difficult situations. Combining all of these abilities into the platforming allows for the player to try out different paths each time they play and potentially give them a different challenge that will reward them with a faster run. 

Ultimately the platforming mechanic keeps the player engaged and aware of what they are doing while playing the game with its simple premise mixed with the occasional challenge.

Combat:

    Combat forms the other half of the gameplay loop. Although platforming is more of the game’s focus, combat is still essential in ensuring the player has fun in StoneKeep. Player characters all have one standard attack, as enemies also have one attack that can damage the player each. Combat is simple to avoid giving the player too much to deal with at once. It functions on an easy to follow premise of if the player hits an enemy with an attack and they take damage, if an enemy hits the player with an attack the player takes damage. Ranged attacks fire a projectile that has a hitbox around it. Melee attacks create a hitbox in front of the player or enemy attacking that will hurt the target if the hitboxes collide. Two player characters have ranged attacks, two have melee attacks to give the player options to choose from. Enemies also have a mix of ranged and melee attacks. Players can choose to fight enemies or avoid them using the platforming mechanics. Fighting puts the player in danger but also clears the path making failed platforming attempts not come with extra danger. 

    Player health is tied to four hearts in the top left of the screen. The player loses health when they are hit by an attack, which loses them a heart. Players can regain health upon reaching the next layer of the map; one heart per layer.  Health is linked to the player, not the characters, meaning every character shares the same health, so if one character loses their health they all do. Enemy health is a hit based system, wherein their health will drop when hit, similarly to the player, but it is not displayed on screen, they take one to three hits to kill based on enemy type. 

Game Elements:

Characters:

Character 1 : Archer

    The Archer is the base character for the game (the character the player starts as). He holds an average movement speed and the highest base jump height. The unique movement ability tied to the Archer is the wall jump. With this ability the player can jump back and forth between walls by timing their jumps and movements properly to access different areas of the game. Attacking with the Archer fires the character’s bow in front of the character, based on the direction he is facing. This attack provides the player with the most range of any character attack. Overall, the Archer is well rounded, being an excellent option for player choice. The Archer is visually distinct from the enemies, environment, and other characters with his dark skin, light hair, green tunic, and bow as can be seen in the art section further in the document. 

Character 2 : Rogue

The Rogue is the second option for the player to choose from. Boasting fast movement speed and average jump height allows for quick level progression. The unique movement ability assigned to the Rogue, the double jump, helps with their fast level traversal while also granting access to paths other characters cannot take. Attacking with the Rogue requires the player to be in close quarters with the enemy to do a dagger slash. The Rogue gives the player balance with high speed while risking danger in combat scenarios. Dressed in all black with red eyes, the Rogue stands from the rest of the cast as seen in the art section below. 

Character 3 : Tank

    The Tank is the third option that players can choose. Although the Tank has slow movement speed and a low jump height, he makes up for it with his unique movement ability. As the Tank moves he builds speed which helps with progressing while moving continuously. While the Tank is moving, his attack is enabled giving him the ability to keep attacking while moving to keep momentum going. The Tank is the epitome of a big beefy knight with massive plate armor and a big lance ahead of it. The lighter blues help offset from the other party members as seen below.

Character 4 : Mage

The fourth and final character in the game is the Mage. This character has an average movement speed, though slightly slower than the Archer’s, and no jump. Though the Mage cannot jump, she can teleport both horizontally and vertically. Her teleport is short ranged but allows for the player to pass through thin walls that other characters would have to go around, potentially putting them in harm's way. The vertical teleport, however, functions somewhat similarly to a jump but instead places the character two spaces directly above their previous position. The Mage attacks by throwing magical projectiles that drop off after traveling a short distance. She stands out with her vibrant orange coloring as seen in the art section. 

Enemies:
Enemy: Skeleton (100 HP)
    
    The evil king was able to summon the undead to protect his castle, these dormant versatile beings are usually guarding or roaming around looking for a fight but can be easily defeated and progressed further.
    
Enemy: Death Knight (200 HP)

The Death Knight is the largest knight of the King who shows no mercy to his opponents. They wield a sword and are fast at striking enemies in close proximity. Players can kill them with projectiles but stealth may be difficult because of its large health. 

Enemy: Dread Knight (150 HP)
    
The Dread Knight works for the evil King and is an enemy character that roams the map slashing the protagonist with his claymore when the player is in proximity. They can deal heavy damage to the player if not dodged. The Dread Knight cannot however detect if the player is behind them allowing for stealth kills if ranger or mage’s projectiles don’t reach him. 

Enemy: Boss (800HP)

    The boss is the final enemy the heroes will face. With every successive hit against the final boss to whittle down his HP, he will teleport to a new platform to keep his distance away from the player until finally he is cornered at the end of the map and defeated by the heroes. However, this doesn’t mean he can’t do damage. The player will have to keep their distance from all incoming attacks. He will launch projectiles towards the player and will get even more aggressive by launching even more projectiles the lower his HP is. If damaged enough, he will get tired and rest at a lower stage where you can deal as much damage to him as possible without worrying about his projectiles. Once defeated, the player will be brought to the win screen where they can choose to quit or play the game again.


Levels:

    The levels in Stone Keep function in a layer system, wherein the game is all one level and the player progresses by reaching the next layer of the keep, ending with the final boss fight on layer three. 

Layer 1

    The first layer of the game is meant to give the player a simple introduction to the game. Platforming on this layer is generally quite simple and enemy placements are low. There are opportunities for characters to use their skills to their advantage and progress through the level faster. Some small pitfalls can lead the player to a quick end, but are quite easily avoidable to help the player get their bearings. The game ramps up its required platforming difficulty at the end of this layer with a jumping puzzle. This puzzle requires the player to scale a small section of the keep by jumping back and forth between small platforms. Although it does not appear that complex it requires some precise movement to get passed. Once the player reaches the end of this puzzle they arrive at the next layer. 

Layer 2

    Layer Two holds more challenges for the player. It has a greater amount of enemies to fight or pass with platforming. The platforming is still not too difficult on its own, but the higher number of enemies makes it need to be done fast to not face defeat. On this layer false blocks are introduced. These are blocks that allow the player to pass through them, which can place the player in dangerous situations or have to redo sections of the game if not spotted. False blocks are distinguishable by their darker coloring and are avoidable if the player is paying attention. At the end of this layer the player is faced with another seemingly simple jumping puzzle to complete in order to reach the next layer. This puzzle is a series of floating blocks placed like a set of winding stairs. There is just enough space between each step for the player to fall through and need to restart if they are not careful. If the player should get ahead of themselves they can easily have to do the puzzle again requiring patience to pass this seemingly simple stairway. The player can also choose to go past this stairway and have an easier climb to the next layer with a wall jumping puzzle for the Archer. 

Layer 3

    Layer Three holds more challenge in combat than in platforming. This layer is split between the boss area and a smaller platforming section similar to the previous two layers but littered with many enemies for the space given. The player is forced to decide to fight through the enemies or risk the platforming in order to preserve hearts for the boss fight at the end. This layer is also filled with false blocks which can send the player promptly back to layer two and more danger if they were not able to clear out the enemies there. The player eventually comes to a super mario-esque staircase that drops them into the boss area. Once here they will use the platforms provided to avoid the bosses attacks and land the killing blow claiming victory. 

Art:
Google Drive Folder: https://drive.google.com/drive/folders/1wnM6HTZvsUeAyk2woxrQqoA3ES4zTc5A?usp=sharing 

Sound:

Google Drive Folder: https://drive.google.com/drive/folders/1ArLOcXkXO7m_jSbh2kQ6EHCaQgQKl23B?usp=sharing 

Music 

Title: Vishnu - Patrick Patrikios - YouTube Audio Library
Game Over: Whole Tone Limbo - Godmode - YouTube Audio Library
Layer 1: Haunted Forest - TrackTribe - YouTube Audio Library
Layer 2: Dead Forest - Brian Bolger - YouTube Audio Library
Layer 3: Black Mass - Brian Bolger - YouTube Audio Library
Boss Fight: Switched on Carcassi - Brian Bolger - YouTube Audio Library
Victory:  Adventure Theme - Sir Cubworth - YouTube Audio Library

SFX

AMBIENCE: 
Distant Thunder - YouTube Audio Library
Hallow Wind - YouTube Audio Library
Rolling Thunder - YouTube Audio Library

ARCHER:
Attack Grunt: male-fighting—pain-reaction-exhale by celine-woodburn Artlist
Hurt: men-emotes—effort-grunt-attacking by john-silke Artlist
Bow Draw: bows-and-arrows—drawing-bow by gamemaster-audio Artlist
Bow Fire: bow-arrow-shot by boom-library Artlist

ROGUE:
Attack Grunt: human-voices—male-groan-attacking by gamemaster-audio Artlist
Hurt: human-body—pain-reaction-male by inspectorj Artlist
Attack: dagger-whoosh-whoosh by boom-library Artlist

TANK:
Attack Grunt: human-voices—male-attacking-grunt by gamemaster-audio Artlist
Hurt: human-voices—male-getting-hurt-grunt by gamemaster-audio Artlist
Attack: anime-go—weapon-two-hands-sword by j.bob Artlist

MAGE:
Attack Grunt: human-voices—female-attacking-grunt by gamemaster-audio Artlist
Hurt: human-voices—female-grunt-intense-pain by gamemaster-audio Artlist
Attack: white-magic—white-shot-one-shot by cristian-lucchetta Artlist
Teleport: white-magic—white-arrow-passing-by by cristian-lucchetta Artlist

BOSS:
Hurt: dwarf—reaction-grunt by epic-stock-media Artlist
Death: this-one-guy—pain-grunt-strangled by skyclad-sound Artlist
Laugh: male-makes-old-pirate-laugh by foley-walkers Artlist
Charging: dwarf—reaction-long-grunt by epic-stock-media Artlist
Attack: black-magic—lightning-ball-impact by cristian-lucchetta Artlist
Teleport: spellcast—vanish-magic-poof by stuart-duffield Artlist

