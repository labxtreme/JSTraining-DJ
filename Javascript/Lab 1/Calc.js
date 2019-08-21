function calc(opr = '+', num1, num2, ...remaining){
    if(opr =='-' || opr =='/'){
        if(remaining.length==0){
            if (opr=='/' && num2==0)
            {
                return "number which is dividing cannot be zero" 
            }
            else if (opr=='-')
            {
                return (num1-num2)
            }
            else
            {
                return (num1/num2)
            }
        }
        else
        {
            return "Need two values to do this not more than that"
        }
    }
    else if(opr =='+' || opr == "*"){
      if(opr=='+'){
          var a=num1+num2 
          for(let i=0;i<remaining.length;i++)
            a+=remaining[i]
        return a
      }  
      else{
        var a=num1*num2  
        for(let i=0;i<remaining.length;i++)
            a*=remaining[i]
        return a
      }
    }
    else{
        return "Operator not recognised"
    }
}

  console.log(calc('/',3,2))