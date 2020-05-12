# BibiGun game
 <a href="https://orabu103.itch.io/spaceship">Click here to play</a>
<h4>About The Project -</h4>
<p>In this game, the player has to run away from enemies and kill as much as possible to earn the highest score</p>

<h4>Features -</h4>
<p><strong> 
<img src="./Assets/Sprites/Bibi_r.png"  width="50px" height="50px" />Player - </strong>
The player's life, in every game, the player has three lives</p><br>
<p><strong>
<img src="./Assets/Sprites/power_up_r.png" width="50px" height="50px" /> Power Up - </strong>
The player gets a stronger shot </p>
<p><strong> 
<img src="./Assets/Sprites/cow_r.png" width="50px" height="50px" /> Enemy - </strong> 
The player must kill the enemy in one shot ,And if the player collides with it he loses 1 lives</p>
<p><strong> 
<img src="./Assets/Sprites/big_cow_r.png" width="50px" height="50px" /> Big Enemy - </strong>
The player must kill the enemy in ten shot ,and if the player collides with it he loses 2 lives</p>
<p><strong> 
<img src="./Assets/Sprites/star_laser.png" width="50px" height="50px" />Power - </strong>
The player's shot when he blows an enemy he gets 10 points</p><br>


<h4>Video of the game for the first section of the assignment -</h4>
<img src="./Assets/Images/game.gif" width="500px" height="300px" />
<p><ul>
 
<li>In this video you can see when the player gathers power, his shots change and when he kills, 2 points are added.
<a href="./Assets/Scripts/3-collisions/ShieldThePlayer.cs"> TriggerEnter Code </a><strong> And </strong> <a href="/Assets/Scripts/2-spawners/KeyboardSpawner.cs"> Laser creation Code </a></li>

<li>In addition, when it collects a shield, a white circle is formed around the spacecraft and disappears after a certain time, <br>
or after the player collides with an enemy, or when the player collides at the bottom of the screen.</li>
<li>You can see that the player has three stars, and when he collides with the enemy, he drops a star.
<a href="./Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs"> Code of Life </a></li></li></p>
</ul>

<h4>Video of the game for the second section of the assignment -</h4>
<img src="./Assets/Images/World.gif" width="500px" height="300px" />


<p><ul>
 <li>In this game can be seen when the player reaches the end of the screen on the right it appears on the left,<br> so the world is round <a href="./Assets/Scripts/3-collisions/CircleW.cs">Code</a></li>

<li>When the player collides with the wall at the bottom of the screen he cannot keep moving down <a href="./Assets/Scripts/3-collisions/WallB.cs">Code</a></li>

<li>When the enemy collides with the wall at the bottom of the screen, it is destroyed <a href="./Assets/Scripts/3-collisions/DestroyObeject.cs">Code</a></li></li>


<li>When the lasers reaches the end of the screen, they disappear <a href="./Assets/Scripts/3-collisions/DestroyObeject.cs">Code</a></li></li></li>
