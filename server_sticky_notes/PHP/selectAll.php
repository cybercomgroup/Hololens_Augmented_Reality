<?php

$servername = "libanaden.com.mysql";
$server_username = "libanaden_com_notes";
$server_password = "Dreamteam";
$dbName = "libanaden_com_notes";



$conn = new mysqli($servername, $server_username, $server_password, $dbName);
		
		if(!$conn){
			die("connection failed.". mysqli_connect_error());
		}
	
		$sql = "SELECT * FROM  note";
		$result = mysqli_query($conn, $sql) or die("Error in Selecting " . mysqli_error($conn));
		
		$rows = array();
		while($row = mysqli_fetch_assoc($result))
		{
			$rows[] = $row;
		}
		
		$notearray = array('Notes' => $rows);
		echo json_encode($notearray);

?>