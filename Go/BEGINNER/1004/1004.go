package main

import "fmt"

func main() {
	var n1, n2 int

	fmt.Scanln(&n1)
	fmt.Scanln(&n2)

	prod := n1 * n2

	fmt.Println("PROD =", prod)
}
