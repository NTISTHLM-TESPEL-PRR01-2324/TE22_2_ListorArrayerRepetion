// int[,] grid = new int[5, 5];
int[,] grid = {
  {1,1,1,1,1,1,1},
  {1,0,0,0,1,0,1},
  {1,0,1,0,1,0,1},
  {1,0,1,1,1,0,1},
  {1,0,0,0,0,0,1},
  {1,1,1,1,1,1,1},
};

for (int y = 0; y < grid.GetLength(0); y++)
{
  for (int x = 0; x < grid.GetLength(1); x++)
  {
    if (grid[y, x] == 0) Console.Write(" ");
    else if (grid[y, x] == 1) Console.Write("█");
  }
  Console.WriteLine();
}


// string[] names = new string[30];

// int[] hps = new int[30];

// int hp;

// names[1] = "Mikael";

// Console.WriteLine(hps[3]);

// List<string> names = new() {"Martin", "Micke"};
// names.Add("Lena");

// List<int> hps = new() { 3, 100, 2000 };

// int i = 3;
// Console.WriteLine(names[i]);

Console.ReadLine();