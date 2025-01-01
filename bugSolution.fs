let x = ref 10
let y = ref 20

let add x y = 
  let mutable xVal = !x
  let mutable yVal = !y
  xVal <- xVal + yVal
  yVal <- yVal + xVal
  x := xVal
  y := yVal
  xVal + yVal

printf "%A" (add x y)
printfn "%A %A" !x !y 