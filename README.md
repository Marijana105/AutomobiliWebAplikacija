1.	Uvod
1.1	Svrha aplikacije 
<

Kroz vježbu kolegija Razvoj poslovnih aplikacija radit će se jednostavna aplikacija za automobile koja podržava unos, uređivanje, brisanje, pretragu i opis automobila u bazi. Aplikacija također, treba omogućiti brisanje i prikaz detalja pojedinog automobila. Svaki unos podataka kroz aplikaciju treba uključivati provjeru valjanosti i za brisanje podataka je potrebna posebna potvrda korisnika.

1.2	Korisnici aplikacije


Aplikaciji će moći pristupiti svi korisnici koji imaju internet i internet preglednik te žele pristupiti svim
bitnim informacijama vezano za automobile na jednom centraliziranom mjestu.
1.3	Koristi (benefiti) od aplikacije


Stvorit će se jedna centralna baza podataka o automobilima dostupna svima. Korisnici kada budu htjeli potražiti informacije o biciklima neće više morati pretraživati putem Google-a i koristiti više izbora za dobivanje informacija o nekom automobila jer će kroz aplikaciju moći dobiti sve potrebne informacije na jednom mjestu. Aplikacija će biti dostupna putem interneta, zahvaljujući tome korisnik ima mogućnost korištenja aplikacije u bilo koje vrijeme.
2.	Zahtjevi
2.1	Funkcijski zahtjevi
Aplikacija mora omogućiti spremanje, uređivanje, pretraživanje, prikaz, traženje i brisanje automobila u bazi podataka.

2.2	Sistemski, hardverski i mrežni zahtjevi
Budući da će aplikacija biti razvijena u ASP.NET Core MVC-u ona treba biti smještena na Microsoft
Web poslužitelju (eng. server). Preporučuju se sljedeće hardverske specifikacije:
Minimum četverojezgreni procesor 2.2 GHz
Minimum 30GB RAM memorije
Minimum 1TB prostora
Operativni sustav Windows server 2019.

2.2.1	2.2.1 Web server
Preporučuje se korištenje Windows Azure-a za hostanje aplikacije.
Windows Azure može hostatii bilo koju ASP.NET Core MVC aplikaciju, uključujući i našu
predloženu aplikaciju u ovom dokumentu.Instaliranje je vrlo jednostavno jer je Microsoft odgovoran
za dodavanje resursa na poslužitelju za vrijeme visokog prometa.
Troškovi su minimalni, oni ovise o količini podataka koji se prikazuju posjetiteljima te održavanje
hardvera nije uključeno u njih.

2.2.2	2.2.2 Baze podataka
Preporučuje se korištenje SQL SERVER baze podataka unutar Windows Azure-a za temeljnu
bazu podataka aplikacije. Što se tiče Web poslužitelja, ova preporuka osigurava visoku dostupnost
za bazu podataka s dobrim omjerom vrijednosti za uložen novac. To posebno ima smisla ako je I
Web aplikacija hostana na Windows Azure-u.

2.3	Sigurnost
U kasnijem razvoju aplikacije razvit će se sigurna identifikacija i zaštićena autentikacija gdje
korisnička imena i lozinke ne smiju biti spremljena u obična tekstualna polja i datoteke, a ostali
podaci korisnika kao što su adresa, telefonski brojevi, brojevi kreditnih kartica neće biti dostupni
anonimnim pristupom.

2.4	Korisnički zahtjevi
Rb.	Zahtjev	Vrsta korisnika (user / admin)
1.	Prikaz svih automobila	Anonimni korisnik
2.	Pretraga automobila po kategoriji I nazivu	Anonimni korisnik
3.	Unos automobila	Registrirani korisnik
4.	Uređivanje automobila	Registrirani korisnik
5.	Brisanje automobila	Administrator
6.	Provjera valjanosti podataka kod unosa I uređivanja	Registrirani korisnik
7.	Potvrda s pitanjem “Jeste li sigurni?” kod brisanja automobila	Administrator
8.	Prikaz detalja pojedinog automobila	Anonimni korisnik
9.	Početna stranica dolaska na aplikaciji mora sadržavati osnovne informacije o svrsi aplikacije	Anonimni korisnik

2.5	Slučajevi (scenariji) korištenja (use-case dijagrami) 
Sljedeći slučajevi korištenja opisuju scenarije u kojima korisnici web aplikacije koriste predloženu aplikaciju za upravljanje automobilima. U tim slučajevima korištenja su uključene osnovne operacije, stoga ih ne treba smatrati konačnim. Kako napreduje razvoj dodatna funkcionalnost može biti dodana prema odluci SCRUM mastera.

2.5.1. Slučaj korištenja 1: Pregled automobila	
Kada posjetitelj stranice pregledava Filmove koji se nalaze u web aplikaciji, odvijaju se sljedeći koraci:
1.	Posjetitelj dolazi na početnu stranicu web mjesta kao anonimni korisnik ili klikne na link Početna stranica u izborniku ako se nalazio na drugoj stranici na istom web mjestu.
2.	Početna stranica prikazuje osnovni opis web aplikacije i sadrži gumbe za prikaz, pretraživanje i dodavanje novih automobila. 
3.	Prikaz osnovnih informacija o razvojnom timu moguće je dobiti putem stranica O nama i Kontakt.
4.	Ako anonimni korisnik želi vidjeti sve Automobile u bazi, mora kliknuti na link Popis automobila u glavnom izborniku ili gumb prikaži na Početnoj stranici.
5.	Web aplikacija prikazuje popis automobila. Za svaki Automobil se prikazuje Naziv automobila, Godina proizvodnje automobila, Kategorija te Cijena.
6.	Ako anonimni korisnik želi pretraživati Automobile u bazi po Kategoriji i Nazivu, mora kliknuti na link Tražilica automobila u glavnom izborniku.
7.	 Ako anonimni korisnik želi vidjeti detalje Automobila, mora kliknuti na link Detalji za taj Automobil.
8.	Web aplikacija prikazuje detalje odabranog automobila –Naziv automobila, Datum Godina proizvodnje Automobila, Kategorija te Cijenu.

10.5.2.	Slučaj korištenja 2: Dodavanje novog automobila
Svi korisnici trebaju moći dodati novi Automobil. Kada korisnik dodaje novi Automobil, sljedeći koraci se odvijaju:
1.	Korisnik klikne na gumb Unos na Početnoj stranici ili na link Novi automobil na stranicama Popis automobila ili Tražilica automobila.
2.	Korisnik upisuje podatke o novom Automobilu.
3.	Korisnik klikne na gumb Spremi.
4.	Ako su upisani podaci ispravni, web aplikacija sprema Automobil u bazu i vraća korisnika na stranicu Popis automobila

6.5.3.	 Slučaj korištenja 3: Uređivanje automobila
Kada korisnik uređuje Automobil, sljedeći koraci se odvijaju:
1.	Korisnik klikne na link Uredi u popisu automobila na stranicama Popis automobila ili  Tražilica automobila.
2.	Korisnik mijenja postojeće podatke o automobilu.
3.	Korisnik klikne gumb Spremi promjene.
4.	Ako su upisani podaci točni, web aplikacija sprema promjene u bazi i prikazuje stranicu za Popis automobila.


2.5.4.	Slučaj korištenja 4: Brisanje automobila
Kad korisnik briše automobile iz baze podataka web aplikacije, sljedeći koraci se odvijaju:
1.	Korisnik klikne na link Obriši u popisu automobila na stranicama Popis automobila ili  Tražilica automobila.
2.	Web aplikacija zahtijeva potvrdu o brisanju automobila.
3.	Ako korisnik potvrđuje brisanje, automobil je uklonjen iz baze.
4.	Web aplikacija prikazuje stranicu Popis automobila.

2.6.	Dijagrami klasa 
Klasa Automobil je potrebna kako bi se u aplikaciji evidentirali matični podaci za svaki automobil. Svojstva koja opisuju neki automobil su: ID (identifikator automobile ), Naziv (naslov automobila, tekstualni podatak), Godina proizvodnje (godina, tekstualni podatak), Cijena (cijena, decimalni broj), Kategorija (kateogrija, tekstualni podatak) 
Kako bi se podaci o automobililma mogli spremiti u bazu podataka, potrebno je napraviti klasu AutomobilDBContext koja koristi klasu Automobil kao model za izradu tablice u bazi pomoću Entity frameworka pa zbog toga i nasljeđuje klasu DbContext. Nakon toga treba pristupiti razvoju kontrolera AutomobilController koji mora naslijediti baznu klasu Kontroler s pripadajućim metodama za manipulaciju nad bazom.  
 







