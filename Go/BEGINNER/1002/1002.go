package main

import (
	"fmt"
	"math"
)

func main() {
	pi := 3.14159

	var r float64

	fmt.Scanln(&r)

	a := pi * math.Pow(r, 2)

	fmt.Printf("A=%.4f\n", a)
}
