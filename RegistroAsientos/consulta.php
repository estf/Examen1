<?php
//Cadena de conexión
$connection_string =  @"Data Source=(localdb)\ProjectsV12;Initial Catalog=FM;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
$user = '';
$pass = '';
//Establecemos la conexión
$connection = odbc_connect($connection_string, $user, $pass );
//Ejecutamos una consulta de selección, en este caso para efectos de prueba el nombre de los empleados
$result = odbc_exec($connection, 'select * from asientos');
//Recorremos la variable $result, la cual es un arreglo asociativo de los registros devueltos por la consulta
//Procedemos a imprimir en cada iteración
while(odbc_fetch_row($result))
{
$Var1 = odbc_result($result, 'nombres');
echo $row['numeroAsiento'].",";
}
?>