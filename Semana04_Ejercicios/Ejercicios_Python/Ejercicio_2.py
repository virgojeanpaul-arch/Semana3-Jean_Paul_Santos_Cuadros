print('Menú de operaciones')
print('1. Calcular el área de un circulo')
print('2. Calcular el área de un cuadrado')
print('3. Calcular el área de un triangulo')
print('4. Salir')

opcion = int(input('Seleccione una de las opciones(1-4): '))

match opcion:
    case 1: 
        print('Elegiste círculo')
        print('Área del círculo = pi * r2')
    case 2: 
        print('Elegiste cuadrado')
        print('Área del cuadrado = lado2')
    case 3:
        print('Elegiste triangulo')
        print('Área de un triangulo = (base*altura)/2')
    case 4:
        print('Saliendo del programa...')
    case _:
        print('Opción invalida. Ingrese un numero del 1 al 4.')