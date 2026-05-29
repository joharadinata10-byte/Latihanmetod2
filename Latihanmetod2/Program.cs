int jumlahitem;

decimal hargaitem, diskon, totalbayar;

static decimal hitungDiskon(int jml_item)
{
    if (jml_item == 5) return 50000m;
    else if (jml_item == 10) return 75000;
    else return 0;
}

static decimal hitungTotal(int jml_item, decimal hrg_item, decimal diskon_item)
{
    return jml_item * hrg_item - diskon_item;
}

Console.Write("Masukkan jumlah item: ");
jumlahitem = int.Parse(Console.ReadLine());

Console.Write("Masukkan harga per item: Rp");
hargaitem = decimal.Parse(Console.ReadLine());

diskon = hitungDiskon(jumlahitem);

totalbayar = hitungTotal(jumlahitem, hargaitem, diskon);

Console.WriteLine($"Total yang harus dibayar adalah Rp {totalbayar}");

