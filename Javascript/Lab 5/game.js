(function(){
    var btn1 = document.getElementById('refresh');
    console.log(btn1)
    btn1.addEventListener('click', redo);
    for(let i=1;i<=36;i++)
    {
        var myDiv = document.createElement('div')
        document.body.appendChild(myDiv)
    }

    function random(number){
       return Math.floor(Math.random()*number)
    }
    var listofcol=['rgb(255,255,0)','rgb(0,255,0)','rgb(255,255,255)','rgb(0,0,0)','rgb(0,0,255)']
    function bgchange(){
        var rndcol=listofcol[random(5)]
        return rndcol
    }
    var divs = document.querySelectorAll('div')
    for(let i=0; i<divs.length; i++)
        {   divs[i].onclick = function(e){
            e.target.style.backgroundColor = bgchange()
        }}
    function redo(){
        for(let i=0; i<divs.length; i++)
        {   
            divs[i].style.backgroundColor = 'blue';
        }
    }
     
})();