Algoritmo Pro2
	Definir num, I, contador Como Entero
    
    Escribir "Ingrese un número entero: "
    Leer num
    
    contador <- 0
    
    Para I <- 1 Hasta num Hacer
        Si num MOD I = 0 Entonces
            contador <- contador + 1
        FinSi
    FinPara
    
    Si contador = 2 Entonces
        Escribir "El número es primo"
    SiNo
        Escribir "El número no es primo"
    FinSi

FinAlgoritmo
