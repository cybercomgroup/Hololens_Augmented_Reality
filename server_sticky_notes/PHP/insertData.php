<?php

$servername = "libanaden.com.mysql";
$server_username = "libanaden_com_notes";
$server_password = "Dreamteam";
$dbName = "libanaden_com_notes";


		$content =$_POST["content"];
		$user = $_POST["user"];

$conn = new mysqli($servername, $server_username, $server_password, $dbName);
		
		if(!$conn){
			die("connection failed.". mysqli_connect_error());
		}
	
		$sql = "INSERT INTO note (content, user) VALUES ('".$content."','".$user."')";
		$result = mysqli_query($conn, $sql);
		
		if(!result) echo "there was an error";
		else echo "Everything ok.";
		
?>