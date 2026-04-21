edad = int(input('Ingrese su edad: '))

if edad >= 18:
    print('Acceso permitido. Bienvenido')
else: 
    print('Acceso denegado')
    faltan = abs(18 - edad)
    print(f'Te faltan {faltan} año(s) para registrarte')