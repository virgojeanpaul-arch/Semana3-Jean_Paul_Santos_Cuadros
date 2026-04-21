Exam_Par = float(input('Ingrese examen parcial: '))
Exam_Fin = float(input('Ingrese examen final: '))
p1 = float(input('Ingrese la práctica 1: '))
p2 = float(input('Ingrese la práctica 2: '))
p3 = float(input('Ingrese la práctica 3: '))

prom_prac = (p1 + p2 +p3 - min(p1,p2,p3))/2
prom_final = (Exam_Par + Exam_Fin + prom_prac) / 3

print(f'Promedio de prácticas: {prom_prac:.2f}')
print(f'Promedio final: {prom_final:.2f}')

if prom_final >= 18:
    print('Excelente')
elif prom_final >= 14:
    print('Bueno')
elif prom_final >= 10:
    print('Regular')
else: 
    print ('Deficiente')