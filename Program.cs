using S_kning;

static int BinSearch(List<Person> pl, int first, int last, int key){
    while( first <= last){
        int mid = (first + last) / 2;
        if(pl[mid].Personnr < key){
            first = mid +1;
        }
        else if( pl[mid].Personnr > key){
            
        }
    }
}

List<Person> personlista = new List<Person>();
personlista.Add(new Person(1, "Darth Vader"));
personlista.Add(new Person(2, "Luke Skywalker"));
personlista.Add(new Person(3, "Leia Organa"));
personlista.Add(new Person(4, "Han Solo"));
personlista.Add(new Person(5, "R2D2"));
personlista.Add(new Person(6, "C3PO"));
personlista.Add(new Person(7, "Lando Calrissian"));
personlista.Add(new Person(8, "Obi-Wan"));

Console.WriteLine("Ange personnummret");
int nyckel = Convert.ToInt32(Console.ReadLine());
int index = BinSearch(personlista, nyckel);
