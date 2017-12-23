### Food Drop
Kopia projektu, który robiliśmy na zajęciach.
##### Czym się różni ta wersja od tej, którą robiliśmy na zajęciach?
- Działające UI w scenie gry
- Pole tekstowe, które tym razem znajduje się na ekranie :)
- Nowy, świerzy, niedokończony skrypt 
##### Ale Jacek, dlaczego nie działało ostatnio UI?
Główna różnica pomiędzy UI w menu, a UI w grze leży w Canvas/Render mode:
- _Screen Space - Overlay_ nakłada Canvas na kamerę - dobre do elementów GUI typu liczniki, minimapy itd.
- _Screen Space - Camera_ stawia Canvas określoną odległość przed kamerą - dobre do robienia _fancy_ menu pod kątem lub innych bajerów, może być zasłonięte przez obiekty w scenie

Dodatkowo zawsze warto sprawdzić jakie ustawienia mają elementy Canvas, bo może się zdażyć, że pole tekstowe będzie wychodzić poza ekran i tekst nie będzie widoczny
##### Do dokończenia dla chętnych:
1. Wyjście z gry na escape - Application.Quit();
2. Zakodzenie CroissantNumberDisplayController - pole tekstowe ma trzymać aktualną ilość pozotałych croissantów
3. Inny (lepszy) skrypt do generowania nowych croissantów w scenie
