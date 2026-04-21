promedio = int(input('Ingrese el promedio del estudiante (0-20): '))

if promedio < 0 or promedio > 20:
    print('Valor inválido')
elif promedio <= 5:
    print('Deficiente')
elif promedio <= 10:
    print('Regular')
elif promedio <= 14:
    print('Bueno')
else: 
    print('Excelente')