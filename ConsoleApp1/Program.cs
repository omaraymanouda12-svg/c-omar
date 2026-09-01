

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


int pages2 = 464;

string pagesString = pages2.ToString();
Console.WriteLine(pagesString);
Console.WriteLine(pagesString.GetType());

//5th answer


int copies = 100;

object copiesObject = copies;

int copiesint = (int)copiesObject;

Console.WriteLine(copiesint);
Console.WriteLine(copies);

//6th answer



Console.WriteLine("Enter a number of pages: ");

int userPages = Convert.ToInt32(Console.ReadLine());

if (userPages >= 300)
{ Console.WriteLine("long book"); }
else
{ Console.WriteLine("short book"); }

//7th answer






