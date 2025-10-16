package main

import (
	"fmt"
)

func main() {
	var milhas float64
	const fatorConversao = 1.60934

	fmt.Print("Digite a quantidade de milhas: ")
	fmt.Scanln(&milhas)

	quilometros := milhas * fatorConversao

	fmt.Printf("%.2f milhas equivalem a %.2f quilômetros.\n", milhas, quilometros)
}