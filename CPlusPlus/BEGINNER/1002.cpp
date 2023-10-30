#include <iostream>
#include <iomanip>
 
int main()
{
    double n = 3.14159;
    double R = 0;

    std::cin >> R;

    std::cout << std::setprecision(4) << std::fixed;

    double result = n * R * R;
    std::cout << "A=" << result << std::endl;
 
    return 0;
}