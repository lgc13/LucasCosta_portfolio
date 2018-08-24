<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="My online portfolio that illustrates skills acquired while working through various project requirements.">
	<meta name="author" content="Lucas Costa">
	<link rel="icon" href="favicon.ico">

	<title>My Online Portfolio</title>

<!-- Include FontAwesome CSS to use feedback icons provided by FontAwesome -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css" />

<!-- Bootstrap for responsive, mobile-first design. -->
<!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous" />

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css" integrity="sha384-fLW2N01lMqjakBkx3l/M9EahuwpSfeNvV63J5ezn3uZzapT0u7EYsXMjQV+0En5r" crossorigin="anonymous" />

<!-- Form validation styling. -->
<link rel="stylesheet" href="css/formValidation.min.css" />

<!-- Custom styles with this template -->
<link href="css/starter-template.css" rel="stylesheet" />

<!-- jQuery DataTables: http://www.datatables.net/ //-->
<!-- jQuery DataTables CDN: https://cdn.datatables.net/ //-->

<link rel="stylesheet" type=""text/css" https://cdn.datatables.net/1.10.12/css/jquery.dataTables.min.css" />
<link rel="stylesheet" type=""text/css" href="https://cdn.datatables.net/responsive/2.1.0/css/responsive.dataTables.min.css" />

	<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
	<!--[if lt IE 9]>
		<script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
		<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
	<![endif]-->

<!-- Carousel styles -->
<style type="text/css">
h2
{
	margin: 0;
	color: #666;
	padding-top: 90px;
	font-size: 52px;
	font-family: "trebuchet ms", sans-serif;
}
.item
{
	background: #333;
	text-align: center;
	height: 300px !important;
}
.carousel
{
  margin: 20px 0px 20px 0px;
}
.bs-example
{
  margin: 20px;
}
</style>


</head>
<body>

	<?php include_once("global/nav_global.php"); ?>

	<div class="container">
		 <div class="starter-template">
						<div class="page-header">
							<?php include_once("global/header.php"); ?>
						</div>

<!-- Start Bootstrap Carousel  -->
<div class="bs-example">
	<div
      id="myCarousel"
		class="carousel"
		data-interval="1000"
		data-pause="hover"
		data-wrap="true"
		data-keyboard="true"
		data-ride="carousel">

    	<!-- Carousel indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
       <!-- Carousel items -->
        <div class="carousel-inner">

          <div class="active item">
                <h2>Web Designing</h2>
                <div class="carousel-caption">
                  <h3>WordPress</h3>
                  <p>Check the things I learned in my web development class.</p>
						 <img src="images/wordpress.png" alt="Web Designing">
                </div>
            </div>

            <div class="item">
                <h2>App Development</h2>
                <div class="carousel-caption">
                  <h3>Second slide label</h3>
                  <p>Look at this app I made!.</p>
						 <img src="images/app.png" alt="Slide 2">
                </div>
            </div>

            <div class="item">
                <h2>BitBucket</h2>
                <div class="carousel-caption">
                  <h3>Third slide label</h3>
                  <p>More programs and things I learned in class.</p>
						 <img src="images/bitbucket.png" alt="Bitbucket">
                </div>
            </div>

        </div>
        <!-- Carousel nav -->
        <a class="carousel-control left" href="#myCarousel" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
        </a>
        <a class="carousel-control right" href="#myCarousel" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
        </a>
    </div>
</div>
<!-- End Bootstrap Carousel  -->

<!-- Placeholder for responsive table if needed.  -->
 <div class="table-responsive">
	 <table id="myTable" class="table table-striped table-condensed" >

		 <!-- Code displaying PetStore data with Edit/Delete buttons goes here // -->

	 </table>
 </div> <!-- end table-responsive -->

<?php
include_once "global/footer.php";
?>

	</div> <!-- end starter-template -->
</div> <!-- end container -->

<!-- Bootstrap core JavaScript: jQuery necessary for Bootstrap's JavaScript plugins
	================================================== -->
	<!-- Placed at end of document so pages load faster -->
		<script type="text/javascript" src="https://code.jquery.com/jquery-2.1.3.min.js"></script>

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" integrity="sha384-0mSbJDEHialfmuBBQP6A4Qrprq5OVfW37PRR3j5ELqxss1yVqOtnepnHVP9aJ7xS" crossorigin="anonymous"></script>

<!-- jQuery DataTables: http://www.datatables.net/ //-->
<script type="text/javascript" src="https://cdn.datatables.net/1.10.12/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdn.datatables.net/responsive/2.1.0/js/dataTables.responsive.min.js"></script>

	<!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
	<script src="js/ie10-viewport-bug-workaround.js"></script>

	<script>
	 $(document).ready(function(){
    $('#myTable').DataTable();
});
	</script>


</body>
</html>
