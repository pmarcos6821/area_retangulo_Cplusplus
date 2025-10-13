#include <iostream>
#include <cmath>
#include <windows.h>
using namespace std;

int main() {
    SetConsoleOutputCP(CP_UTF8);

    int opcao;
    double valor;

    do {
        cout << "\n=== Calculadora Científica ===\n";
        cout << "1 - Seno\n";
        cout << "2 - Cosseno\n";
        cout << "3 - Tangente\n";
        cout << "4 - Logaritmo natural\n";
        cout << "5 - Raiz quadrada\n";
        cout << "0 - Sair\n";
        cout << "Escolha uma opção: ";
        cin >> opcao;

        if (opcao == 0) break;

        cout << "Digite um número: ";
        cin >> valor;

        switch (opcao) {
        case 1: cout << "Seno: " << sin(valor) << endl; break;
        case 2: cout << "Cosseno: " << cos(valor) << endl; break;
        case 3: cout << "Tangente: " << tan(valor) << endl; break;
        case 4:
            if (valor > 0)
                cout << "Logaritmo natural: " << log(valor) << endl;
            else
                cout << "Erro: logaritmo de número não positivo.\n";
            break;
        case 5:
            if (valor >= 0)
                cout << "Raiz quadrada: " << sqrt(valor) << endl;
            else
                cout << "Erro: raiz de número negativo.\n";
            break;
        default: cout << "Opção inválida.\n";
        }

    } while (true);

    cout << "Encerrando a calculadora...\n";
    return 0;
}