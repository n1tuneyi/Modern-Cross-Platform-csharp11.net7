using System;

string[,] grid = new[,]
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};

WriteLine($"Lower bound of the first dimension is: {grid.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is: {grid.GetUpperBound(0)}");
WriteLine($"Lower bound of the second dimension is: {grid.GetLowerBound(1)}");
WriteLine($"Upper bound of the second dimension is: {grid.GetUpperBound(1)}");

for (int row = 0; row <= grid.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid[row, col]}");
    }
}

string[,] grid2 = new string[3, 4]; 
grid2[0, 0] = "Alpha"; 
grid2[0, 1] = "Beta";

grid2[2, 3] = "Dog";