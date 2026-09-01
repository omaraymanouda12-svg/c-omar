

int pages = 300;
double number  = pages;
Console.WriteLine(number);

// first answer

double price = 49.99;
int sprice = (int)price;
Console.WriteLine(sprice);

//2nd answer

string pagesText = "464";

int pagesInt = Convert.ToInt32(pagesText);
Console.WriteLine(pagesInt);

//3rd answer

string yearText = "2023";

int year = int.Parse(yearText);
Console.WriteLine(year);



string badtext = "abc";

if ( int.TryParse(badtext, out int result))
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid number");
}

//4th answer



