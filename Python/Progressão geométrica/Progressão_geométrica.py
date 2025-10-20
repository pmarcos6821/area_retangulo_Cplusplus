def calcular_pg(primeiro_termo, razao, num_termos):
    termos = []
    for n in range(num_termos):
        termo = primeiro_termo * (razao ** n)
        termos.append(termo)
    return termos

def main():
    print("Calcula uma progressão geométrica")
    try:
        a1 = float(input("Digite o primeiro termo (a₁): "))
        r = float(input("Digite a razão (r): "))
        n = int(input("Digite o número de termos (n): "))

        pg = calcular_pg(a1, r, n)
        print("\nTermos da Progressão Geométrica:")
        for i, termo in enumerate(pg, start=1):
            print(f"a{i} = {termo}")
    except ValueError:
        print("Por favor, insira valores válidos.")

if __name__ == "__main__":
    main()
