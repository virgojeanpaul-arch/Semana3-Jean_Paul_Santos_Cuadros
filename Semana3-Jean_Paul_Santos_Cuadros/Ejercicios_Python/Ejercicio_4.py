import math

radio = float(input('Radio del círculo: '))
area = math.pi * radio ** 2
perimetro = 2 * math.pi * radio

print(f'Área: {area:.4f}')
print(f'Perimetro: {perimetro:.4f}')