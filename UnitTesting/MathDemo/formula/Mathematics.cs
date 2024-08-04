namespace MathDemo;

public class Mathematics
{
public static bool isGenap(int num) {
        return num % 2 == 0 ? true : false;
    }
    public static bool isGanjil(int num) {
        return num % 2 == 1 ? true : false;
    }
    public static int isKuadrat(int num) {
        int sum = 0;
        for (int count = 1; count <= num; count++) {
            sum = count * count;
        }
        return sum;
    }
    public static double Ispenjumlahan(double num1, double num2) {
        return (num1 + num2);
    }
    public static double Ispengurangan(double num1, double num2) {
        return (num1 - num2);
    }
    public static double Isperkalian(double num1, double num2) {
        return (num1 * num2);
    }
    public static double Ispembagian(double num1, double num2) {
        return (num1 / num2);
    }
}
