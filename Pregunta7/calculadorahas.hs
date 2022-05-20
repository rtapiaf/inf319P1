calculadora :: Integer -> Integer -> IO()
calculadora num1 num2 = do
  print("****OPERACIONES ARITMETICAS**** ")
  print("Suma : ")
  print(num1+num2)
  print("Resta : ")
  print(num1-num2)
  print("Multiplicacion : ")
  print(num1*num2)
  print("Division : ")
  print(div num1 num2)
  
main::IO()
main = do
  print "Introduzca el primer numero"
  num1 <- getLine
  print "Introduzca el segundo numero"
  num2 <- getLine
  calculadora (read num1) (read num2)
  
  

