# 4_024_EreditarietàCarte2
## Obiettivo: 
Realizzare il seguente esercizio.

## Istruzioni:
Creare due classi che permettano di giocare con **carte da gioco** tresette (40 carte)

### La Classe Carte:
ha i seguenti campi privati e proprietà pubbliche: 
1. seme: può avere i seguenti valori: Cuore, Picche, Fiore, Quadri.
2. valore: può essere: Asso,2,3,4,5,6,7, Fante, Regina, Re.
Il controllo sui vincoli di integrità deve essere fatto nella sezione ***set*** creando eccezioni in
caso di dati errati

### La classe MazzoCarte
contiene come proprietà privata una lista in cui poter caricare tutte le carte del mazzo.
I metodi pubblici sono:
- InserisciCarta(obj) --> permette di inserire una nuova istanza carta nella lista se non ancora presente.
- due Metodi DammiCarta (con gli opportuni parametri) che restituiscano:
    - la prima carta del mazzo;
    - la posizione della carta con il seme e il valore richiesto se presente;
- MescolaCarte() che riordina le istanze del mazzo in sequenza casuale

Realizzare una semplice interfaccia che permetta di richiamare i metodi richiesti.

*Racca Paolo*