namespace BigONotation.BigO;

public class BigO_2N_HanoiTower
{
    public void TowerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
    {
        if (n == 0)
            return;

        // O(2^n)
        TowerOfHanoi(n - 1, from_rod, aux_rod, to_rod);

        Console.WriteLine($"Move disk {n} from rod {from_rod} to rod {to_rod}");

        TowerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
    }
}
