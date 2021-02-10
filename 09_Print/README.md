# 4_009_PrintSpooler
## Obiettivo: 
Realizzare un esercizio dove simulare il funzionamento di uno Spooler di Stampa. Inserire i file da stampare all'interno di una ***Queque*** e visualizzarli all'interno di una *DataGridView*.
Al click sul bottone *Stampa* visualizzare i file nella coda di stampa e rimuoverli dalla relativa coda.
## Procedimento:
Ho creato due classi, *File* e *Stampante* (quest'ultima di tipo **Singleton**). 
- Al click sul bottone *Crea file* apro una nuova Form modale, chiamata *FormInserisciFile*, all'interno della quale inserisco i valori da salvare. In caso i dati in input siano errati genero una *Eccezzione* e fermo la creazione attraverso un *try-catch*, altrimenti genero un nuovo oggetto **File** che vado ad inserire nella coda della stampante. In caso quest'ultima non sia ancora mai stata istanziata, creo una nuova istanza e la salvo nella variabile *instance*, altrimenti accedo attraverso la variabile all'oggetto *Stampante* precedentemente creato.
Una volta inserito il nuovo File nella coda, vado a cancellare e riscrivere la *DataGridView* sulla base degli elementi della coda.
- Al click sul bottone *Stampa*, richiamo una funzione *StampaFile()* che mi visualizza progressivamente i dati presenti nella *Coda* attraverso una *MessageBox* e rimuove gli item dalla *DataGridView*. 

*Racca Paolo*