package main

import "fmt"

func main() {
	var a int
	var b int

	fmt.Scanln(&a)
	fmt.Scanln(&b)

	var soma = a + b

	fmt.Println("SOMA =", soma)
}
