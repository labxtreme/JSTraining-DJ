function add(a1){
    var c1=0
    function addintern(a2){
        c1=a1+a2
        return addintern1
        }
    function addintern1(a3){
        var res=c1+a3
        return res
        } 
    return addintern

}

console.log(add(10)(20)(3));

console.log(add(10)(20)(30));
