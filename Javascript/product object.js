var product = {
    Title : 'Goldman Sachs',
    ID : 1132,
    Price : 3000,
    Stock : true,
    supplier : [{name : 'jake harper', location : 'palm spring'}, {name :'anthony dacota', location : 'philedelphia'},{ name :  'mark avenue', location : 'Las vegas'}]
}
Object.defineProperties(product,{
'ID': {
    writable : false        
},
'Price':{
    enumerable : false        
},
'Stock':{
    enumerable : false        
}
})
console.log(JSON.stringify(product))