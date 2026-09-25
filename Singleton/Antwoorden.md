# Opdracht #3 - Thread safe

| Solution to multi-threading problem | Omschrijving van toepasbaarheid |
|---|---|
| Synchronize the GetInstance() method | Makkelijk te maken en goed te onderhouden, want je zet gewoon een lock om de hele methode. Nadeel is de performance: elke keer dat GetInstance() wordt aangeroepen moet er gelockt worden, terwijl dat alleen de eerste keer nodig is. Prima als GetInstance() niet vaak wordt aangeroepen. |
| Eager instantiation | Het object wordt meteen gemaakt als de class geladen wordt, dus er kan nooit een tweede instantie komen. Heel simpel en snel bij het ophalen. Nadeel is dat het object altijd gemaakt wordt, ook als je het nooit gebruikt. Handig als het object klein is of zeker gebruikt wordt. |
| Double checked locking | Er wordt alleen gelockt als er nog geen instantie is, dus alleen de eerste keer. Dit is het beste voor de performance. Nadeel is dat de code wat ingewikkelder is en dus lastiger te onderhouden. Handig als GetInstance() heel vaak wordt aangeroepen. Deze oplossing is gebruikt in ChocolateBoiler. |
