var animal = {
    color : 'red'
}

var dog={name : 'foo'}
dog.__proto__=animal
console.log(animal.constructor.prototype)
