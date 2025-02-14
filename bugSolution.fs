let mutable x = ref 10

let addOne xRef = 
    let newValue = !xRef + 1
    xRef := newValue
    newValue

let y = addOne x

printfn "%d" y

//Modify the value of x
x := 20

printfn "%d %d" !x y