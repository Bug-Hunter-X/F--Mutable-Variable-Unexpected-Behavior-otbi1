let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d" y

//Modify the value of x
x <- 20

printfn "%d %d" x y