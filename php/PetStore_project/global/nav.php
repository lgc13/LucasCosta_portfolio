	<nav class="navbar navbar-inverse navbar-fixed-top">
		<div class="container">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
					<span class="sr-only">Toggle navigation</span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
				<a class="navbar-brand" href="../index.php" target="_self">Home</a>
			</div>

			<div id="navbar" class="collapse navbar-collapse">
				<ul class="nav navbar-nav">
					<!-- <li class="active"><a href="../index.php">LIS4381</a></li> -->
					<li><a href="../project2/add_petstore.php">Add a Pet</a></li>
					<li><a href="../project2/index.php">View All Pets</a></li>
					<li><a href="../a4/index.php">Client Side Validation</a></li>
					<!-- <li><a href="../a4/index.php">A4</a></li>
					<li><a href="../a5/index.php">A5</a></li>
					<li><a href="#../project1/index.php">P1</a></li>
					<li><a href="../project2/index.php">P2</a></li>
					<li><a href="#../test/index.php">Test</a></li> -->
				</ul>
			</div><!--/.nav-collapse -->
		</div>
	</nav>

<?php
date_default_timezone_set('America/New_York');
$today = date("m/d/y g:ia");
echo $today;
 ?>
