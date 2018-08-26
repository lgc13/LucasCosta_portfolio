<?php
//show errors: at least 1 and 4...
ini_set('display_errors', 1);
//ini_set('log_errors', 1);
//ini_set('error_log', dirname(__FILE__) . '/error_log.txt');
error_reporting(E_ALL);

//use for inital test of form inputs
//exit(print_r($_POST));

//code to process inserts goes here
$sto_id_v = $_POST['sto_id'];
$sto_name_v = $_POST['sto_name'];
$sto_street_v = $_POST['sto_street'];
$sto_city_v = $_POST['sto_city'];
$sto_state_v = $_POST['sto_state'];
$sto_zip_v = $_POST['sto_zip'];
$sto_phone_v = $_POST['sto_phone'];
$sto_email_v = $_POST['sto_email'];
$sto_url_v = $_POST['sto_url'];
$sto_std_sales_v = $_POST['sto_std_sales'];
$sto_notes_v = $_POST['sto_notes'];

//exit($sto_name_v . "," . $sto_street_v . "," . $sto_city_v . ", etc.");

//name: letters, numbers, hyphens, and underscore
$pattern='/^[a-zA-Z0-9\-_\s]+$/';
$valid_name = preg_match($pattern, $sto_name_v);
//echo $valid_name; //test output: should be 1 (i.e., valid)
//exit();

//street: only letters, numbers, comma, space character, and period
$pattern='/^[a-zA-Z0-9,\s\.]+$/';
$valid_street = preg_match($pattern, $sto_street_v);
//echo $valid_street; //test output: should be 1 (i.e., valid)
//exit();

//city: only letters and space character
$pattern='/^[a-zA-Z\s]+$/';
$valid_city = preg_match($pattern, $sto_city_v);
//echo $valid_city; //test output: should be 1 (i.e., valid)
//exit();

//state: must includ two letters (min. 2, max. 2)
$pattern='/^[a-zA-Z]{2}+$/';
$valid_state = preg_match($pattern, $sto_state_v);
//echo $valid_state; //test output: should be 1 (i.e., valid)
//exit();

//ZIP: must include 5-9 digits
$pattern='/^\d{5,9}+$/';
$valid_zip = preg_match($pattern, $sto_zip_v);
//echo $valid_zip; //test output: should be 1 (i.e., valid)
//exit();

//phone: must include 10 digits
$pattern='/^\d{10}+$/';
$valid_phone = preg_match($pattern, $sto_phone_v);
//echo $valid_phone; //test output: should be 1 (i.e., valid)
//exit();

/*/email:
$pattern='/^[A-z0-9_\-]+[@][A-z0-9_\-]+([.][A-z0-9_\-]+)+[A-z.]{2,4}$/';
$valid_email = preg_match($pattern, $sto_email_v);
//echo $valid_email; //test output: should be 1 (i.e., valid)
//exit();
*/
//URL:
$pattern='/^(https?:VV)?([\da-z\.-]+)\.([a-z\.]{2,6})([V\w \.-]*)*V?$/';
$valid_url = preg_match($pattern, $sto_url_v);
//echo $valid_url; //test output: should be 1 (i.e., valid)
//exit();

//std_sales: max 10 digits, including optional decimal point with two digits
$pattern='/^\d{1,8}(?:\.\d{0,2})?$/';
$valid_std_sales = preg_match($pattern, $sto_std_sales_v);
//echo $valid_std_sales; //test output: should be 1 (i.e., valid)
//exit();

if
(
	empty($sto_name_v) ||
	empty($sto_street_v) ||
	empty($sto_city_v) ||
	empty($sto_state_v) ||
	empty($sto_zip_v) ||
	empty($sto_phone_v) ||
	empty($sto_email_v) ||
	empty($sto_url_v) ||
	!isset($sto_std_sales_v)
)
{
	$error = "All fields require data, except <b>Notes</b>. Check all fields and try again.";
	include('global/error.php');
}

else if (!is_numeric($sto_std_sales_v) || $sto_std_sales_v <= 0)
{
	$error = 'std sales can only contain numbers (other than a decimal point); and must be equalto or great than zero.';
	include('global/error.php');
}

else if ($valid_name === false)
{
	echo "Error in pattern!";
}
else if ($valid_name === 0)
{
	$error = 'Name can only contain letters, numbers hyphens, and underscore';
	include('global/error.php');
}

else if ($valid_street === false)
{
	echo "Error in pattern!";
}
else if ($valid_street === 0)
{
	$error = 'Street can only contain letters, numbers, commas, or periods';
	include('global/error.php');
}

else if ($valid_city === false)
{
	echo "Error in pattern!";
}
else if ($valid_city === 0)
{
	$error = 'City can only contain letters, numbers';
	include('global/error.php');
}

else if ($valid_state === false)
{
	echo "Error in pattern!";
}
else if ($valid_state === 0)
{
	$error = 'State must contain two letters';
	include('global/error.php');
}

else if ($valid_zip === false)
{
	echo "Error in pattern!";
}
else if ($valid_zip === 0)
{
	$error = 'ZIP must contain 5 - 9 digits, and no other characters';
	include('global/error.php');
}

else if ($valid_phone === false)
{
	echo "Error in pattern!";
}
else if ($valid_phone === 0)
{
	$error = 'Phone number must contain 10 digits, and no other character';
	include('global/error.php');
}

else if ($valid_std_sales === false)
{
	echo "Error in pattern!";
}
else if ($valid_std_sales === 0)
{
	$error = 'std Sale must contain no more than 10 digits, including a decimal point';
	include('global/error.php');
}

/*else if ($valid_email === false)
{
	echo "Error in pattern!";
}
else if ($valid_email === 0)
{
	$error = 'Email can only contain letters, numbers, comma, space character, and period';
	include('global/error.php');
}*/

else if ($valid_url === false)
{
	echo "Error in pattern!";
}
else if ($valid_url === 0)
{
	$error = 'URL can only contain letters, numbers';
	include('global/error.php');
}

else
{
	require_once('global/connection.php');

$query =
"UPDATE store
SET
sto_name = :sto_name_p,
sto_street = :sto_street_p,
sto_city = :sto_city_p,
sto_state = :sto_state_p,
sto_zip = :sto_zip_p,
sto_phone = :sto_phone_p,
sto_email = :sto_email_p,
sto_url = :sto_url_p,
sto_std_sales = :sto_std_sales_p,
sto_notes = :sto_notes_p
WHERE sto_id = :sto_id_p";

//exit($query)

	try
		{
			$statement = $db->prepare($query);
			$statement->bindParam(':sto_id_p', $sto_id_v);
			$statement->bindParam(':sto_name_p', $sto_name_v);
			$statement->bindParam(':sto_street_p', $sto_street_v);
			$statement->bindParam(':sto_city_p', $sto_city_v);
			$statement->bindParam(':sto_state_p', $sto_state_v);
			$statement->bindParam(':sto_zip_p', $sto_zip_v);
			$statement->bindParam(':sto_phone_p', $sto_phone_v);
			$statement->bindParam(':sto_email_p', $sto_email_v);
			$statement->bindParam(':sto_url_p', $sto_url_v);
			$statement->bindParam(':sto_std_sales_p', $sto_std_sales_v);
			$statement->bindParam(':sto_notes_p', $sto_notes_v);
			$row_count = $statement->execute();
			$statement->closeCursor();

			$last_auto_increment_id = $db->lastInsertId();

			//exit($last_auto_increment_id);

//include('index.php'); //forwarding is faster, one trip to server
}

	Catch (PDOException $e)
		{
			$error = $e->getMessage();
			echo $error;
		}
		header('Location: index.php');
	}
?>
