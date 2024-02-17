#include <iostream>
#include <string>

using namespace std;

int GetPoisitiveNumber(string Message)
{
    int Number;

    do
    {
        cout << Message;
        cin >> Number;

    } while (Number <= 0);

    return Number;
}

int Sum(int Number1, int Number2)
{
    return Number1 + Number2;
}

int main()
{
    cout << "Sum : " << Sum(GetPoisitiveNumber("Enter First Number: "), GetPoisitiveNumber("Enter Second Number: "));
}