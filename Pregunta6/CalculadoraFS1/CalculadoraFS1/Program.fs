// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

module calculadora =
    let sumar x y = x + y
    let restar x y = x - y 
    let multiplicar x y = x * y 
    let dividir x y = x / y  

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("Introduce el primer numero")
    let n1 = Console.ReadLine() 
    Console.WriteLine("Introduce el segundo numero")
    let n2 = Console.ReadLine()
    let primero = Convert.ToInt32(n1)
    let segundo = Convert.ToInt32(n2)
    let suma = calculadora.sumar primero segundo
    Console.WriteLine("La suma es: " + suma.ToString())
    let resta = calculadora.restar primero segundo
    Console.WriteLine("La resta es: " + resta.ToString())
    let multiplica = calculadora.multiplicar primero segundo
    Console.WriteLine("La multiplicacion es: " + multiplica.ToString())
    let divide = calculadora.dividir primero segundo
    Console.WriteLine("La division es: " + divide.ToString())
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
