package main

import "fmt"

func main() {
	var A, B, C, D int

	fmt.Scanln(&A)
	fmt.Scanln(&B)
	fmt.Scanln(&C)
	fmt.Scanln(&D)

	diferenca := A*B - C*D

	fmt.Println("DIFERENCA =", diferenca)
}
