using LinearRegression;

// Y = (m * x) + b

// test data
CoordinateList list = new CoordinateList();
list.Add(new Coordinates(10, 15));
list.Add(new Coordinates(16, 24));
list.Add(new Coordinates(32, 26));
list.Add(new Coordinates(8, 20));
list.Add(new Coordinates(12, 30));
list.Add(new Coordinates(22, 15));
list.Add(new Coordinates(19, 21));
list.Add(new Coordinates(5, 10));
list.Add(new Coordinates(1, 16));
list.Add(new Coordinates(20, 19));

Console.WriteLine($"X total : {list.xTotal} | Y total : {list.yTotal} | XY total : {list.xyTotal} | X^2 : {list.xSquaredTotal} | Y^2 : {list.ySquaredTotal}");

double m = 0, b = 0;

double mTop = (list.yTotal * list.xSquaredTotal) - (list.xTotal * list.xyTotal);
double Bottom = ((list.coordinates.Count * list.xSquaredTotal) - (Math.Pow(list.xTotal, 2)));

//calculate the y intercept of the line
m = mTop/Bottom;

double bTop = ((list.coordinates.Count * list.xyTotal) - (list.xTotal * list.yTotal));

//calulate the slope of the line
b = bTop/Bottom;

Console.Write("Enter x : ");
double x = Double.Parse(Console.ReadLine());

Console.WriteLine($"Equation: Y = {m} + ({b} x {x})");

// put totals into the equation to find what y is when x = user input
double result = m + (b * x);

Console.WriteLine($"Y = {result}");