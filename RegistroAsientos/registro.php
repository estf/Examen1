<?php
$serverName = "(localdb)\ProjectsV12";
$connectionInfo = array( "Database"=>"FM", "UID"=>"", "PWD"=>"" );
$conn = sqlsrv_connect( $serverName, $connectionInfo);
if( $conn === false ) {
     die( print_r( sqlsrv_errors(), true));
}

  $sql = "INSERT INTO asientos (data) VALUES (?)";
$params = array(1, "2_4");

$stmt = sqlsrv_query( $conn, $sql, $params);
if( $stmt === false ) {
     die( print_r( sqlsrv_errors(), true));
}
?>