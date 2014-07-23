<?php
$myVar['username']='ivan';

echo $myVar['username'];

?>

<?php
if((true || true) && false){
	echo 'OK';
}
else{
	echo 'NO OK'
}
?>

<?php
phpinfo(); // info about php
?>

<?php
$foo=1.5;
$foo='Hallo'
var_dump((int)$foo);    // kastvane
var_dump((float)$foo);
var_dump((bool)$foo);  // 0 i false sa edno i susto
var_dump((int)$foo);  // kastva ot string kum chislo ( output e 0 ako nqma chislo pred stringa)
echo 'Hello'+'PHP'; // output = 0 ("+" mat.funkciq)

?>

<?php
for($i=0;$i<10;$i++){
	echo $i.'<br>';
}
echo 'END'; 
?>

<?php
$i=3;
for($i=10;$i<15;$i+=2){  // for(;$i<15;) -> bezkraina interaciq + zabivane na PC
	echo $i.'<br>';
}
echo 'END'; 
?>

<?php
$i=3;
for(;$i<10;){
	echo $i.'<br>';
	$i++;           // exit, die - spirat izp. na koda. (ne se preporachvat), break - preporuchitelno 
}
/*
$i=3;
for(;;){
	echo $i.'<br>';
	if($i>10){
		break;
	}
	$i++;            
}
echo 'END';
*/
 
?>

<?php
$myAr=array('Ivan','Dragan','Petko')
for($i=0;$i<count($myAr);$i++){
	echo $myAr[$i].'<br>';
}
echo 'END';
/*
$myAr=array('Gogo','Ivan','Dragan','Petko')
for($i=0;$i<count($myAr);$i++){     // ne dobra praktika za dekl.na promenlivata !!!
	echo $myAr[$i].'<br>';
}
echo $i;  // out put i=4 poradi poslednata proverka na i++
*/
/*
$myAr=array('Gogo','Ivan','Dragan','Petko')
$count=count($myAr);          // podobra praktika za deklarirane na promenlivata !!!
for($i=0;$i<count;$i++){
	echo $myAr[$i].'<br>';
}
echo $i;  // out put i=4 poradi poslednata proverka na i++
*/

?>  // video 2 -> 0:40:00 h.

<?php

?>

<?php

?>

<?php

?>

<?php

?>

<?php

?>

<?php

?>





