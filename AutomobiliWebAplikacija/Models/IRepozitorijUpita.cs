namespace AutomobiliWebAplikacija.Models
{
    public interface IRepozitorijUpita
    {
        IEnumerable<Automobil> PopisAutomobil(); // R - read
        void Create(Automobil automobil); // C - insert tj create
        void Delete(Automobil automobil); // D - delete
        void Update(Automobil automobil); //U - update
        int SljedeciId();
        int KategorijaSljedeciId();
        Automobil DohvatiAutomobilSIdom(int id);

        IEnumerable<Kategorija> PopisKategorija();
        void Create(Kategorija kategorija);
        void Delete(Kategorija kategorija);
        void Update(Kategorija kategorija);

        Kategorija DohvatiKategorijuSIdom(int id);
    }
}
