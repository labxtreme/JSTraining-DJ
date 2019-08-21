(function(){
    var btn1 = document.getElementById('size-12');

    btn1.addEventListener('click', hello);
    var allp = document.getElementsByTagName('h1');

    function hello(){
      allp[0].style.fontSize = '12px';
    
     }
})();