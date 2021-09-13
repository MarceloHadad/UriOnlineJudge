package main

import "fmt"

func main() {
	var A, B float64

	fmt.Scanln(&A)
	fmt.Scanln(&B)

	media := ((A * 3.5) + (B * 7.5)) / 11

	fmt.Printf("MEDIA = %.5f\n", media)
}
