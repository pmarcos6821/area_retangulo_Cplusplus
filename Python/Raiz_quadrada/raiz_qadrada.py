import math

# Solicita um número ao usuário
numero = float(input("Digite um número para calcular a raiz quadrada: "))

# Verifica se o número é não-negativo
if numero >= 0:
    raiz = math.sqrt(numero)
    print(f"A raiz quadrada de {numero} é {raiz:.2f}")
else:
    print("Não é possível calcular a raiz quadrada de um número negativo.")