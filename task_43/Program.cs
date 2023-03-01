const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;
double[] lineData1 = InputLineData (LINE1);
double[] lineData2 = InputLineData (LINE2);
if (validateLines (lineData1, lineData2))
double [] coord - FindCoords (lineDatal, lineData2);
Console.Write ($"Точа пересечения уравнений");
y = {lineData1 [COEFFICIENT]} * x + {lineData1 [CONSTANT]} и
y = {1íneData2 [COEFFICIENT]} * × + {lineData2 [CONSTANT]}");
Console.WriteLine ($"имеет координаты ({coord [X_COORD]}, {coord [Y_COORD]})");
double Prompt(string msg);
{
Console.Write (msg);
string value = Console. ReadLine ();
double result = Convert. ToDouble (value);
return result;
}

double[] InputLineData(int numberofLine)
{
double[] lineData = new double[2];
lineData [COEFFICIENT] = Prompt($"Введите коэффициент для {numberofLine} прямой >");
lineData [CONSTANT] = Prompt($"Введите константу для {number0fLine} прямой >");
return lineData;
}

double[] FindCoords (double[] lineData1, double[] lineData2)
{
double[] coord = new double[2];
coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]);
(lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + LineData1[CONSTANT];
return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2);
{
if(lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
{
if (lineData1[CONSTANT] == lineData2 [CONSTANT])
{
Console.WriteLine ("Прямые совладают");
return false;
}
else
{
Console. WriteLine ("Прямые параллельны");
return false;
}
}
return true;
}