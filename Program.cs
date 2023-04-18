
Console.WriteLine("Введите массив");
int[] mas = Console.ReadLine().Split().Select(int.Parse).ToArray();
pop(mas);
Console.WriteLine("Done!");
Console.WriteLine(string.Join(" ", mas));

void pop(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {

        for (int j = 0; j < mass.Length; j++)
        {

            if (i== j) { continue; }

            if (mass[i] == mass[j])
            {
                mass = delnum(mass, i);
                pop(mass);
            } 
        }
    }
    mas = mass;
}


int[] delnum(int[] delmas, int place)
{
    delmas = delmas.Where((item, index) => index!= place).ToArray();
    return delmas;
}

