# WarehouseManager – plan wersji 1.0

## Cel projektu

WarehouseManager to aplikacja konsolowa napisana w C#, której głównym celem jest praktyczna nauka programowania.

Projekt ma pozwolić przećwiczyć wiedzę w praktyce, zamiast wykonywać pojedyncze, oderwane od siebie zadania.

Wersja 1.0 będzie wykonana wyłącznie w C# jako aplikacja konsolowa.

## Zakres wersji 1.0

### 1. Produkty

Każdy produkt powinien posiadać podstawowe dane:

- Id
- Name
- Price
- Quantity
- Category

Program powinien umożliwiać:

- dodawanie produktu,
- usuwanie produktu,
- wyszukiwanie produktu,
- wyświetlanie wszystkich produktów.

---

### 2. Zarządzanie stanem magazynowym

Program powinien umożliwiać:

- zwiększenie ilości produktu,
- zmniejszenie ilości produktu,
- sprawdzenie aktualnego stanu,
- zabezpieczenie przed wydaniem większej liczby sztuk niż znajduje się w magazynie.

---

### 3. Wyszukiwanie i filtrowanie

Wykorzystując LINQ aplikacja powinna umożliwiać:

- wyszukiwanie produktu po nazwie,
- filtrowanie produktów dostępnych na magazynie,
- filtrowanie według kategorii,
- wyszukiwanie produktów poniżej określonego stanu magazynowego.

---

### 4. Sortowanie

Produkty będzie można sortować:

- alfabetycznie,
- według ceny,
- według ilości,
- od najdroższego do najtańszego,
- od największego stanu magazynowego.

---

### 5. Statystyki magazynu

Program powinien potrafić obliczyć:

- liczbę różnych produktów,
- całkowitą liczbę sztuk,
- wartość pojedynczego produktu,
- całkowitą wartość magazynu,
- najdroższy produkt,
- produkt z największą ilością.

---

### 6. Operacje magazynowe

Dodamy podstawowe operacje:

- przyjęcie towaru,
- wydanie towaru.

Każda operacja powinna odpowiednio zmieniać Quantity produktu.

---

### 7. Walidacja danych

Program powinien zabezpieczać się przed niepoprawnymi danymi.

Przykłady:

- cena nie może być ujemna,
- ilość nie może być ujemna,
- nazwa produktu nie może być pusta,
- nie można usunąć nieistniejącego produktu,
- nie można wydać większej liczby produktów niż znajduje się w magazynie.

---

### 8. Obsługa błędów

W projekcie wykorzystamy:

- if / else,
- null,
- bool,
- wyjątki,
- try / catch.

Celem będzie nauczenie się poprawnego reagowania programu na błędne sytuacje.

---

### 9. Menu konsolowe

Po przygotowaniu logiki magazynu stworzymy menu użytkownika.

Przykład:

1. Wyświetl produkty
2. Dodaj produkt
3. Usuń produkt
4. Wyszukaj produkt
5. Przyjmij towar
6. Wydaj towar
7. Wyświetl produkty dostępne
8. Wyświetl statystyki magazynu
9. Zakończ program

Menu będzie korzystać z wcześniej przygotowanych klas i metod.

---

## Główne klasy

### Product

Reprezentuje pojedynczy produkt.

### WarehouseService

Odpowiada za zarządzanie produktami oraz logikę magazynu.

### Category

Reprezentuje kategorię produktu.

### ConsoleMenu

Odpowiada za komunikację użytkownika z aplikacją.

---

## Czego chcemy nauczyć się podczas projektu

Projekt powinien pozwolić praktycznie wykorzystać:

- klasy i obiekty,
- konstruktory,
- właściwości,
- enkapsulację,
- metody,
- List<T>,
- pętle,
- if / else,
- nullable,
- LINQ,
- lambdy,
- wyjątki,
- enum,
- podział odpowiedzialności między klasy,
- organizację projektu,
- Git i GitHub.

---

## Warunek ukończenia wersji 1.0

WarehouseManager 1.0 uznajemy za ukończony, gdy użytkownik może uruchomić program z konsoli i bez zmieniania kodu:

- dodawać produkty,
- usuwać produkty,
- wyszukiwać produkty,
- zmieniać ich ilość,
- wykonywać przyjęcia i wydania,
- filtrować i sortować produkty,
- sprawdzać statystyki magazynu,
- obsługiwać program przez menu konsolowe.

Cała logika wersji 1.0 pozostaje w C# i działa w pamięci programu.