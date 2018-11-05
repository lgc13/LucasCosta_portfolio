<!DOCTYPE html>
<html lang="en">
<head>
<!--
"Time-stamp: <Fri, 06-24-16, 20:09:09 Eastern Daylight Time>"
//-->
<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="My online portfolio for employers to look at my qualifications.">
	<meta name="author" content="Lucas Costa">
	<link rel="icon" href="favicon.ico">

	<title>LIS4381 - Project 2</title>

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
			<div class="row">
				<div class="col-sm-8 col-sm-offset-2">

					<div class="page-header">
						<?php include_once("global/header.php"); ?>
					</div>

					<h2>Pet Stores</h2>

						<form id="edit_petstore" method="post" class="form-horizontal" action="edit_petstore_process.php">
							<?php	require_once("global/connection.php");

								$sto_id_v = $_POST['sto_id'];
							//notes
							$query =
							"SELECT *
							FROM store
							WHERE sto_id = :sto_id_p";

							  $statement = $db->prepare($query);
							  $statement->bindParam(':sto_id_p', $sto_id_v);
							  $statement->execute();
							  $result = $statement->fetch();

								while($result != null)
							{
							?>
								<input type="hidden" name="sto_id" value="<?php echo $result['sto_id']; ?>" />

								<div class="form-group">
										<label class="col-sm-3 control-label">Name:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="30" name="sto_name" value="<?php echo $result['sto_name']; ?>" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Street:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="30" name="sto_street" value="<?php echo $result['sto_street']; ?>" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">City:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="30" name="sto_city" value="<?php echo $result['sto_city']; ?>" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">State:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control"maxlength="2" name="sto_state" value="<?php echo $result['sto_state']; ?>" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">ZIP:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="9" name="sto_zip" value="<?php echo $result['sto_zip']; ?>" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Phone:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="10" name="sto_phone" value="<?php echo $result['sto_phone']; ?>" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Email:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="100" name="sto_email" value="<?php echo $result['sto_email']; ?>" />
										</div>
								</div>


								<div class="form-group">
										<label class="col-sm-3 control-label">URL:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="100" name="sto_url" value="<?php echo $result['sto_url']; ?>" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">YTD Sale:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="21" name="sto_std_sales" value="<?php echo $result['sto_std_sales']; ?>" />
										</div>
								</div>

								<div class="form-group">
										<label class="col-sm-3 control-label">Notes:</label>
										<div class="col-sm-5">
												<input type="text" class="form-control" maxlength="255" name="sto_notes" value="<?php echo $result['sto_notes']; ?>" />
										</div>
								</div>

								<?php
								$result = $statement->fetch();
							}
								$db = null;
								 ?>

								<div class="form-group">
										<div class="col-sm-9 col-sm-offset-3">
												<button type="submit" class="btn btn-primary" name="edit" value="edit">Update</button>
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

<!-- Turn off client-side validation, in order to test server-side validation.
<script type="text/javascript" src="js/formValidation/formValidation.min.js"></script>
-->

<!-- Note the following bootstrap.min.js file is for form validation, different from the one above. -->
<script type="text/javascript" src="js/formValidation/bootstrap.min.js"></script>

	<!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
	<script src="js/ie10-viewport-bug-workaround.js"></script>

<script type="text/javascript">
 //See Regular Expressions: http://www.qcitr.com/usefullinks.htm#lesson7
 $(document).ready(function() {

	$('#edit_petstore').formValidation({
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
										//city: only letters, numbers, comma, space character, and period
										regexp: /^[a-zA-Z0-9,\s]+$/,
									message: 'City can only contain letters, numbers'
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
											message: 'State must be 2 characters'
									},
									regexp: {
										//state: only 2 letters
										regexp: /^[a-zA-Z]+$/,
									message: 'State can only contain letters'
									},
							},
					},

					ZIP: {
							validators: {
									notEmpty: {
											message: 'ZIP required'
									},
									stringLength: {
											min: 5,
											max: 9,
											message: 'ZIP must be 5, and no more than 9 digits'
									},
									regexp: {
										//ZIP: only numbers
										regexp: /^[0-9]+$/,
									message: 'ZIP can only contain numbers'
									},
							},
					},

					phone: {
							validators: {
									notEmpty: {
											message: 'Phone number required'
									},
									stringLength: {
											min: 10,
											max: 10,
											message: 'Phone number must be 10 digits'
									},
									regexp: {
										//phone: only numbers
										regexp: /^[0-9]+$/,
									message: 'Phone can only contain numbers'
									},
							},
					},

					email: {
							validators: {
									notEmpty: {
											message: 'Email address required'
									},
									stringLength: {
											min: 1,
											max: 100,
											message: 'Email no more than 100 characters'
									},
									regexp: {
										//email: only letters, numbers, comma, space character, and period
										regexp: /^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$/,
									message: 'Must include valid email address'
									},
							},
					},

					URL: {
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
										//url: only letters, numbers
										regexp: /^(https?:VV)?([\da-z\.-]+)\.([a-z\.]{2,6})([V\w \.-]*)*V?$/,
									message: 'Must include valid URL'
									},
							},
					},

					stdsales: {
							validators: {
									notEmpty: {
											message: 'YTD Sale required'
									},
									stringLength: {
											min: 1,
											max: 11,
											message: 'YTD Sale can be no more than 10 digits, including decimal point'
									},
									regexp: {
										//url: only letters, numbers
										regexp: /^[0-9\.]+$/,
									message: 'YTD Sale can only contain numbers and decimal point'
									},
							},
					},
			}
	});
});
</script>

</body>
</html>
