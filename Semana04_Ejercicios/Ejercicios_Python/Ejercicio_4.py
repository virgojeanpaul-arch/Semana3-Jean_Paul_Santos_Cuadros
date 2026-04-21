categoria = input('Categoria (A/B/C): '). upper()
horas = float(input('Horas: '))
anios = float(input('Años de servicio: '))

if categoria == "A": 
    tarifa = 33.50
elif categoria == "B": 
    tarifa = 29.80
elif categoria == "C": 
    tarifa = 25.70
else: print('Categoria invalida'); exit()

if anios <= 3: bono = 0.00
elif anios <= 10: bono = 0.10
elif anios <= 17: bono = 0.20
else: bono = 0.30

print(f'Sueldo: S/. {tarifa * horas * (1 + bono):.2f}')