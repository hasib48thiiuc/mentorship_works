// See https://aka.ms/new-console-template for more information
using System.Text;


string text = "Hello";
string text2 = "World";
string text3 = text + text2;

/*
for(int i = 0; i<text.Length; i++)
{
    if (text[i] == 'a' || text[i] == 'b')
        text[i] = '_';
}
*/

string fullText = string.Empty;
while (true)
{
    var line = Console.ReadLine();
    if (line == null)
        break;
    fullText += line;
}

StringBuilder someText = new StringBuilder("Hello");


for (int i = 0; i < someText.Length; i++)
{
    if (someText[i] == 'a' || someText[i] == 'b')
        someText[i] = '_';
}

while (true)
{
    var line = Console.ReadLine();
    if (line == null)
        break;
    someText.Append(line);
}

string finalResult = someText.ToString();