(function(){
    var btn1 = document.getElementById('Submit');
    btn1.addEventListener('click', savedata);
    function createrel(name,rel){
        this.guardian=name
        this.relation=rel
    }
    objstore=[]
    function savedata(){
    var guardian = document.getElementById('Guardian').value
    var relation = document.getElementById('relation').value
    objstore.push(new createrel(guardian,relation))   
    console.log(JSON.stringify(objstore)) 
    document.getElementById('Guardian').value=""
    document.getElementById('relation').value=""
}
     return objstore
})();

