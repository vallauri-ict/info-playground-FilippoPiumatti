# 4_011_FormRegistrazione
## Obiettivo: 
Realizzare un programma dove simulare una *Form di Registrazione*, convalidando i valori in input tramite **Regex** e seguendo le seguenti istruzioni:
### Form di registrazione:
- Cognome
- Nome
- Indirizzo
- Città
- CAP (5 caratteri numerici)
- Mail (formato mail)
- Cod fisc (formato corretto)
- User
- Pwd (almeno 8 caratteri con almeno 1 numero e almeno 1 maiuscola)
Al click sul pulsante registra se è tutto ok allora salvo i dati su un file in formato json

INTEGRAZIONE:
- per creare la stringa in formato Json utilizzare l’override del metodo ToString()
- creare una classe Utenti istanziabile una volta sola (singleton) contenente una Lista che viene
valorizzata con i dati contenuti nel file.
**NB**:
- Le nuove registrazioni possono avvenire solo se l’utente (campo user) non è presente nella
lista

Consiglio: per realizzare il punto precedente costruire un metodo bool presente() che
ricerca se lo user esiste già e restituisce un bool

*Racca Paolo*