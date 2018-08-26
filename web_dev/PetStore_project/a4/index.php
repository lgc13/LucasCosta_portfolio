<!DOCTYPE html>
<html lang="en">
<head>
<!--
"Time-stamp: <Fri, 06-24-16, 20:09:09 Eastern Daylight Time>"
//-->
<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="Assignment 4 for my LIS 4381 class.">
	<meta name="author" content="Lucas Costa">
	<link rel="icon" href="favicon.ico">

	<title>Client Side Validation</title>

<!-- Include FontAwesome CSS to use feedback icons provided by FontAwesome -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css">

<!-- Bootstrap for responsive, mobile-first design. -->
<!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css" integrity="sha384-fLW2N01lMqjakBkx3l/M9EahuwpSfeNvV63J5ezn3uZzapT0u7EYsXMjQV+0En5r" crossorigin="anonymous">

<!-- Note: following file is for form validation. -->
<link rel="stylesheet" href="css/formValidation.min.css"/>

<!-- Starter template for your own custom styling. -->
<link href="css/starter-template.css" rel="stylesheet">

	<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
	<!--[if lt IE 9]>
		<script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
		<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
	<![endif]-->

</head>
<body>

	<?php include_once("../global/nav.php"); ?>

	<div class="container">
		<div class="starter-template">
			<div class="row">
				<div class="col-sm-8 col-sm-offset-2">

					<div class="page-header">
						<?php include_once("global/header.php"); ?>
					</div>

					<h2>Pet Stores</h2>

						<form id="defaultForm" method="post" class="form-horizontal" action="#">
								<div class="form-group">
										<label class="col-sm-3 control-label">Name:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="name" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Street:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="street" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">City:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="city" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">State:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="state" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Zip:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="zip" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Phone:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="phone" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Email:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="email" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">URL:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="url" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">YTD Sales:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="ytdsales" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Notes:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" name="notes" />
										</div>
								</div>

								<div class="form-group">
										<div class="col-sm-5 col-sm-offset-3">
												<button type="submit" class="btn btn-primary" name="signup" value="Sign up">Submit</button>
										</div>
								</div>
						</form>
					</div>
			</div>

			<?php include_once "global/footer.php"; ?>

		</div> <!-- end starter-template -->
 </div> <!-- end container -->


	<!-- Bootstrap JavaScript
	================================================== -->
	<!-- Placed at end of document so pages load faster -->
<script type="text/javascript" src="https://code.jquery.com/jquery-2.1.4.min.js"></script>

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" integrity="sha384-0mSbJDEHialfmuBBQP6A4Qrprq5OVfW37PRR3j5ELqxss1yVqOtnepnHVP9aJ7xS" crossorigin="anonymous"></script>

<!-- Turn off client-side validation, in order to test server-side validation.  -->
<script type="text/javascript" src="js/formValidation/formValidation.min.js"></script>

<!-- Note the following bootstrap.min.js file is for form validation, different from the one above. -->
<script type="text/javascript" src="js/formValidation/bootstrap.min.js"></script>

	<!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
	<script src="js/ie10-viewport-bug-workaround.js"></script>

<script type="text/javascript">
 //See Regular Expressions: http://www.qcitr.com/usefullinks.htm#lesson7
 $(document).ready(function() {

	$('#defaultForm').formValidation({
			message: 'This value is not valid',
			icon: {
					valid: 'fa fa-check',
					invalid: 'fa fa-times',
					validating: 'fa fa-refresh'
			},
			fields: {
					name: {
							validators: {
									notEmpty: {
											message: 'Name is required'
									},
									stringLength: {
											min: 1,
											max: 30,
											message: 'Name must be less than 30 characters long'
									},
									regexp: {
										//alphanumeric, hyphens, underscores, and spaces
										//regexp: /^[a-zA-Z0-9\-_\s]+$/,
										//similar to: (though, \w supports other Unicode characters)
											regexp: /^[\w\-\s]+$/,
										message: 'Name can only contain letters, numbers, hyphens, and underscore'
									},
							},
					},

					street: {
							validators: {
									notEmpty: {
											message: 'Street required'
									},
									stringLength: {
											min: 1,
											max: 30,
											message: 'Street no more than 30 characters'
									},
									regexp: {
										//street: only letters, numbers, comma, space character, and period
										regexp: /^[a-zA-Z0-9,\s\.]+$/,
									message: 'Street can only contain letters, numbers, commas, or periods'
									},
							},
					},

					city: {
							validators: {
									notEmpty: {
											message: 'City required'
									},
									stringLength: {
											min: 1,
											max: 30,
											message: 'City no more than 30 characters'
									},
									regexp: {
										//street: only letters, numbers, comma, space character, and period
										regexp: /^[a-zA-Z0-9,\s\.]+$/,
									message: 'City can only contain letters and numbers'
									},
							},
					},

					state: {
							validators: {
									notEmpty: {
											message: 'State required'
									},
									stringLength: {
											min: 2,
											max: 2,
											message: 'State must be two characters'
									},
									regexp: {
										//street: only letters, numbers, comma, space character, and period
										regexp: /^[a-zA-Z0-9,\s\.]+$/,
									message: 'State can only letters'
									},
							},
					},

					zip: {
							validators: {
									notEmpty: {
											message: 'Zip required'
									},
									stringLength: {
											min: 5,
											max: 9,
											message: 'Zip must be only numbers, between 5 to 9 chars'
									},
									regexp: {
										//street: only letters, numbers, comma, space character, and period
										regexp: /^[0-9]+$/,
									message: 'Zip must contain only numbers'
									},
							},
					},

					phone: {
							validators: {
									notEmpty: {
											message: 'Phone required'
									},
									stringLength: {
											min: 10,
											max: 10,
											message: 'Phone must have 10 numeric characters'
									},
									regexp: {
										//street: only letters, numbers, comma, space character, and period
										regexp: /^[0-9]+$/,
									message: 'Phone must have 10 numeric characters'
									},
							},
					},

					email: {
							validators: {
									notEmpty: {
											message: 'Email required'
									},
									stringLength: {
											min: 1,
											max: 100,
											message: 'Email no more than 100 characters'
									},
									regexp: {
										//street: only letters, numbers, comma, space character, and period
										regexp: /^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$/,
									message: 'Must include valid email'
									},
							},
					},

					url: {
							validators: {
									notEmpty: {
											message: 'URL required'
									},
									stringLength: {
											min: 1,
											max: 100,
											message: 'URL no more than 100 characters'
									},
									regexp: {
										//street: only letters, numbers, comma, space character, and period
										regexp: /^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$/,
									message: 'Must include an URL'
									},
							},
					},

					ytdsales: {
							validators: {
									notEmpty: {
											message: 'YTD sales required'
									},
									stringLength: {
											min: 1,
											max: 11,
											message: 'YTD can be no more than 10 digits'
									},
									regexp: {
										//street: only letters, numbers, comma, space character, and period
										regexp: /^[0-9\.]+$/,
									message: 'Must include an YTD sales'
									},
							},
					},

			}
	});
});
</script>

</body>
</html>
