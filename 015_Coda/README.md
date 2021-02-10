# 4_015_EsQueue
## Obiettivo: 
Realizzare un programma seguendo le indicazioni date:
**Utilizzando una coda** realizzare la gestione di un pronto soccorso:
al Pronto Soccorso i pazienti sono classificati con un colore: rosso (urgentissimo), giallo (grave),
verde (moderato), bianco (lieve). Funziona così: quando una persona arriva al pronto soccorso
l’infermiere lo registra (nome e età) e decide anche il colore di priorità; appena un medico è libero
deve gestire prima quelli con codice rosso, poi giallo, poi verde e poi bianco. Dichiara una struttura
Paziente con i campi Nome, Età, Colore; il programma deve gestire 4 code diverse e inserire il
paziente nella lista corretta; quando un medico è libero preme il pulsante e il programma fornisce
subito il paziente da servire (quindi sceglie il primo dei pazienti codice verde solo se non ci sono
codici rosso e giallo). Le informazioni vanno visualizzate in una etichetta; i dati prelevati da caselle
di testo Un altro pulsante determina i valori massimo e minimo giornalieri delle temperature
rilevate.

## Osservazioni:
Ho deciso di inserire le varie code all'interno di un *Dictionary* così da potervi accedere e poterle gestire in modo più semplice e ottimale.
Ho creato due *Forms*, una utilizzabile da un eventuale infermiere e l'altra dal medico, così da simulare al meglio un eventuale utilizzo del programma.

*Racca Paolo*