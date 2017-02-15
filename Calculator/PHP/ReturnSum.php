<?php

		$servername = "libanaden.com.mysql";
		$server_username = "libanaden_com";
		$server_password = "123456";
		$dbName = "libanaden_com";
		


		
		$conn = new mysqli($servername, $server_username, $server_password, $dbName);
		
		if(!$conn){
			die("connection failed.". mysqli_connect_error());
		}
		
		$sql = "SELECT sum FROM calc";
		$result = mysqli_query($conn, $sql);
		 if(mysqli_num_rows($result) > 0){
		//show data for each row
		while($row = mysqli_fetch_assoc($result)){
		echo "Sum: ".$row ['sum'].";";
		}
	}
?>