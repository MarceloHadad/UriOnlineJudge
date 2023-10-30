#include <iostream>
  
int main()
{
    double A, B, MEDIA = 0;
    double weightA = 3.5, weightB = 7.5;

    std::cin >> A >> B;

    MEDIA = ((A * weightA) + (B * weightB)) / (weightA + weightB);

    std::cout.precision(5);
    std::cout << "MEDIA = " << std::fixed << MEDIA << std::endl;

    return 0;
}