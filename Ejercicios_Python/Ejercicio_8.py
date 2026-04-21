celsius = float(input('Ingrese la temperatura en C°: '))

fahrenheit = celsius * (9.0 / 5) + 32
kelvin = celsius + 273.15

print(f'Fahrenheit (F): {fahrenheit:.2f}')
print(f'Kelvin (K): {kelvin:.2f}')