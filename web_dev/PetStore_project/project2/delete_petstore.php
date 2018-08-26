<?php
//show errors: at least 1 and 4
ini_set('display_errors', 1);
//
//
error_reporting(E_ALL);

//get item ID
$sto_id_v = $_POST['sto_id'];

require_once('global/connection.php');

//notes
$query =
"DELETE FROM store
WHERE sto_id = :sto_id_p";

try
{
  $statement = $db->prepare($query);
  $statement->bindParam(':sto_id_p', $sto_id_v);
  $row_count = $statement->execute();
  $statement->closeCursor();

  //
  //

  //
header('Location: index.php');
}

catch (PDOException $e)
{
  $error = $e->getMessage();
  echo $error;
}
?>
