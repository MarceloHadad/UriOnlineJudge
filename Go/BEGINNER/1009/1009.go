package main

import (
	"fmt"
)

func main() {
	var sellersName string
	var fixedSalary, sales float64

	fmt.Scanln(&sellersName)
	fmt.Scanln(&fixedSalary)
	fmt.Scanln(&sales)

	finalSalary := fixedSalary + (sales * 0.15)

	fmt.Printf("TOTAL = R$ %.2f\n", finalSalary)
}
