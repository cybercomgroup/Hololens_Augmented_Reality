<?php

		$servername = "libanaden.com.mysql";
		$server_username = "libanaden_com";
		$server_password = "123456";
		$dbName = "libanaden_com";
		
		$number1 = $_POST["number1Post"];
		$number2 = $_POST["number2Post"];


		
		$conn = new mysqli($servername, $server_username, $server_password, $dbName);
		
		if(!$conn){
			die("connection failed.". mysqli_connect_error());
		}
		
		$sql = "INSERT INTO calc (number1, number2)
				VALUES ('".$number1."','".$number2."')";
		$result = mysqli_query($conn, $sql);
		
		if(!result) echo "there was an error";
		else echo "Everything ok.";
?>