function objetoAjax(){

var xmlhttp=false;

try {


xmlhttp = new ActiveXObject("Msxml2.XMLHTTP");

} catch (e) {

try {

xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");

} catch (E) {

xmlhttp = false;

}


}
if (!xmlhttp && typeof XMLHttpRequest!='undefined') {

  xmlhttp = new XMLHttpRequest();

  }

  return xmlhttp;

  }
function enviarDatosEmpleado(){




  divResultado = document.getElementById('cart-item');

 
  list = document.getElementsByTagName('li');
  
  i=0;
  
  l=(list.length-2);
  
  while (i<l){ 
    
   
  
    
  
  nom=(list[i]).getAttribute('class');


  


  ajax=objetoAjax();




  ajax.open("POST", "registro.php",true);

  ajax.onreadystatechange=function() {

  if (ajax.readyState==4) {


  divResultado.innerHTML = ajax.responseText


  }

  }

  ajax.setRequestHeader("Content-Type","application/x-www-form-urlencoded");


  //enviando los valores

  ajax.send("numeroAsiento="+nom)
   i++;
   
  }
  t=document.getElementsByTagName('li');
  h=0;
  while (h<l){ 
    
    document.getElementById('selected-seats').removeChild(t[h]);
  h++;
  }
  }

function LimpiarCampos(){


  document.nuevo_empleado.nombres.value="";

  document.nuevo_empleado.departamento.value="";

  document.nuevo_empleado.sueldo.value="";

  document.nuevo_empleado.nombres.focus();

  }