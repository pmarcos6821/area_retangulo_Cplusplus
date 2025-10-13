#include <iostream>
using namespace std;

int main() {
    float largura, altura, area;

    cout << "Digite a largura do retangulo: ";
    cin >> largura;

    cout << "Digite a altura do retangulo: ";
    cin >> altura;

    area = largura * altura;

    cout << "A area do retangulo = " << area << " m2" << endl;

    return 0;
}
