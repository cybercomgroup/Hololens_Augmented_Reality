<?php

$servername = "libanaden.com.mysql";
$server_username = "libanaden_com_notes";
$server_password = "Dreamteam";
$dbName = "libanaden_com_notes";


		$id = $_POST["id"];


$conn = new mysqli($servername, $server_username, $server_password, $dbName);
		
		if(!$conn){
			die("connection failed.". mysqli_connect_error());
		}
	
		$sql = "DELETE FROM note WHERE id = $id";
		$result = mysqli_query($conn, $sql);
		
		if(!result) echo "there was an error";
		else echo "Everything ok.";
		
?>