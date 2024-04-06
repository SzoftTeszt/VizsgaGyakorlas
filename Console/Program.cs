using ClassLibrary.Data;

LottoContext db= new LottoContext();

if (!db.Jatekos.Any()) {
    var sorok = File.ReadAllLines(@"c:\adat\jatekosok.csv").Skip(1);
    foreach (var line in sorok)
        db.Jatekos.Add(new ClassLibrary.Model.Jatekos(line));
    db.SaveChanges();
}
if (!db.Tipp.Any()) {
    var sorok = File.ReadAllLines(@"c:\adat\tippek.csv").Skip(1);
    foreach (var line in sorok)
        db.Tipp.Add(new ClassLibrary.Model.Tipp(line));
    db.SaveChanges();
}