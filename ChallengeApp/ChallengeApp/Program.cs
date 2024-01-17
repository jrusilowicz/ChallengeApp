using System;

int number = 1122334455;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] count = new int[10];


foreach (char c in letters)
{
    if (c == '0') { count[0]++; }
    else if (c == '1') { count[1]++; }
    else if (c == '2') { count[2]++; }
    else if (c == '3') { count[3]++; }
    else if (c == '4') { count[4]++; }
    else if (c == '5') { count[5]++; }
    else if (c == '6') { count[6]++; }
    else if (c == '7') { count[7]++; }
    else if (c == '8') { count[8]++; }
    else if (c == '9') { count[9]++; }

}

foreach (int cnt in count)
{
    Console.WriteLine(cnt);
}