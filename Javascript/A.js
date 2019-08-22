var globalvar = "Global Variable";
 
 function funct1() {
 
var gloabalvar = "Local Variable";
 console.log(gloabalvar);
 return globalvar;
 }
 console.log(globalvar);
 var result = funct1();
 console.log(result);