peso = float(input('Ingrese el peso en kg: '))
estatura = float(input('Ingrese la estatura en metros'))

imc = peso / (estatura * estatura)
imc_red = round(imc, 2)

print(f'IMC: {imc_red}')

if imc < 18.5:
    print('Bajo peso')
elif imc < 25:
    print('Normal')
elif imc < 30:
    print('Sobrepeso')
else:
    print('Obesidad')   