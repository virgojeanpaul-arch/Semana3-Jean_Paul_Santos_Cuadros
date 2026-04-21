import math

x1 = float(input('x1: '))
x2 = float(input('x2: '))
y1 = float(input('y1: '))
y2 = float(input('y2: '))

dx = x2 - x1
dy = y2 - y1

distancia = math.sqrt(dx**2 + dy**2)

print(f'Distancia entre los puntos: {distancia}')