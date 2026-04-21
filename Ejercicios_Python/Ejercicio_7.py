kWh = float(input('Ingrese el consumo de kWh: '))

subtotal = 5.00 + (kWh * 0.55)
igv = subtotal * 0.18
total = subtotal + igv

print(f'Subtotal a pagar: S/. {subtotal:.2f}')
print(f'IGV (18%): S/. {igv:.2f}')
print(f'Total a pagar: S/. {total:.2f}')