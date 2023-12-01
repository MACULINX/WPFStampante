# Progetto Stampante WPF

## Descrizione

Questo progetto implementa una semplice applicazione WPF che simula una stampante e la stampa di pagine colorate. La stampante è rappresentata dalla classe `Stampante`, mentre le pagine sono rappresentate dalla classe `Pagina`. Il programma consente di visualizzare lo stato dell'inchiostro e della carta, nonché di eseguire operazioni come la sostituzione del colore e la stampa di pagine.

## Classi

### `Pagina`

La classe `Pagina` rappresenta una pagina colorata. Ha quattro attributi, corrispondenti ai colori CMYB (Ciano, Magenta, Giallo, Nero). La classe include due costruttori: uno che accetta valori specifici per i colori con un massimo di 3 e un costruttore che crea una pagina con colori casuali.

### `Stampante`

La classe `Stampante` rappresenta una stampante virtuale. Ha quattro serbatoi di colore (CMYB) e un cassetto di fogli. Le principali funzionalità includono:

- **Stampa**: Il metodo `Stampa` prende in input una pagina e restituisce `true` se è possibile stamparla (abbastanza inchiostro e carta disponibili), altrimenti restituisce `false`.

- **StatoInchiostro**: Il metodo `StatoInchiostro` restituisce la quantità di inchiostro presente in uno specifico serbatoio (colore).

- **StatoCarta**: Il metodo `StatoCarta` restituisce la quantità di fogli di carta disponibili nel cassetto.

- **SostituisciColore**: Il metodo `SostituisciColore` sostituisce un serbatoio di inchiostro (colore) e lo riporta a 100.

- **AggiungiCarta**: Il metodo `AggiungiCarta` aggiunge fogli di carta fino a un massimo di 200 nel cassetto.

## Interfaccia Utente (WPF)

L'interfaccia utente è rappresentata dalla classe `MainWindow`. La finestra contiene 4 pulsanti per cambiare il serbatoio il colore della stampante, aggiungere carta, eseguire un test di stampa e stampare una pagina specifica. La finestra visualizza anche lo stato corrente dell'inchiostro e della carta.

## Diagramma UML

Il diagramma UML con le relazioni tra le classi è disponibile nel repository [WPFStampante_UML](https://raw.githubusercontent.com/MACULINX/WPFStampante/master/StampanteWPF_UML.png).

## Requisiti

- .NET Core 3.1 o versioni successive
- Ambiente di sviluppo WPF (ad esempio, Visual Studio)

## Installazione

1. Clonare il repository:

   ```bash
   git clone https://github.com/MACULINX/WPFStampante.git

2. Aprire il progetto in un ambiente di sviluppo compatibile con WPF (ad esempio, Visual Studio).

3. Eseguire l'applicazione.
