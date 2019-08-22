function pubpri(){
    var pubele1="hello"
    var pubele2="there"
    var priele3="you cannot"
    var priele4="see me"
    function letmeout(){
        return Math.random()*30+Math.random()*100
    }
    return {
        nub : pubele1,
        club : pubele2,
        randomsum : letmeout
    }
}

console.log(pubpri().nub)
console.log(pubpri().club)
console.log(pubpri().randomsum())