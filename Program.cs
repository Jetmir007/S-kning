using S_kning;

static int BinSearch(List<Person> pl, int first, int last, int key){
    while( first <= last){
        int mid = (first + last) / 2;
        if(pl[mid].Personnr < key){
            first = mid +1;
        }
        else if( pl[mid].Personnr > key){
            last = mid -1;
        }
        else{
            return mid;
        }
    }
    return -1;
}

List<Person> personlista =
[
    new Person(1, "Darth Vader"),
    new Person(2, "Luke Skywalker"),
    new Person(3, "Leia Organa"),
    new Person(4, "Han Solo"),
    new Person(5, "R2D2"),
    new Person(6, "C3PO"),
    new Person(7, "Lando Calrissian"),
    new Person(8, "Obi-Wan"),
    new Person(9, "Qui-Gon-Jin"),
];

Console.WriteLine("Ange personnummret");
int nyckel = Convert.ToInt32(Console.ReadLine());
int index = BinSearch(personlista,0, 8, nyckel);
if(index != -1){
    Console.WriteLine(personlista[index].Namn);
}
else{
    Console.WriteLine("Personnumret finns inte med i listan");
}