package main

import "fmt"

func main() {

	var number int
	var workedHours, receivePerHour float64

	fmt.Scanln(&number)
	fmt.Scanln(&workedHours)
	fmt.Scanln(&receivePerHour)

	salary := workedHours * receivePerHour

	fmt.Println("NUMBER =", number)
	fmt.Printf("SALARY = U$ %.2f\n", salary)
}
