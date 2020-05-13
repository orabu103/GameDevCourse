

# BibiGun game
 <a href="https://orabu103.itch.io/bibigun">Click here to play</a>
<h4>About The Project -</h4>
<p>In this game, the player has to run away from enemies and kill as much as possible to earn the highest score</p>

<h4>Features -</h4>
<p><strong> 
<img src="./Assets/Sprites/Bibi_r.png"  width="50px" height="50px" />Player - </strong>
 The player's spacecraft can move with the up and down arrows left and right</p><br>
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
<p><strong> 
<img src="./Assets/Sprites/heart_powerup.png" width="50px" height="50px" />Life - </strong>
The player's life, in every game, the player has three lives</p><br>


<h4>Video of the Big Enemy -</h4>
<img src="./Assets/Gif/Bigcow.gif" width="500px" height="300px" />
<p><ul>
 
<li>In the video it can be seen that the big enemy comes after accumulating 100 points.
</strong> <a href="./Assets/Script/Player.cs"> The appearance of the big enemy </a></li>

<li>To kill the big enemy the player has to hit him with the shots 10 times.</li>
</strong> <a href="./Assets/Script/DbigEnemy.cs"> Killing the big enemy </a></li>

<li>When the Big Enemy is create, a police sound is activated.</li>
</ul>



<h4>Object collision video -</h4>
<img src="./Assets/Gif/newlife.gif" width="500px" height="300px" />

<p><ul>
<li>When the player collides with the enemy, he loses one life</li>
<liWhen the player collides with the big enemy, he loses two lives</li>
<liWhen the player collides with the enemy there is the sound of a cow</li>
</ul>

