# C-Basics

Logical Error uppgift 1
  - Vad var problemet?
  - Programmet hittar inte det största talet. Det beror på att max var satt till 0, och villkoret gjorde att inget förändrades.
  - Lösning av problmet
  - Jag fixade så att max börjar med det första talet, och så kollar programmet om det nuvarande talet är större än max.

Logical Error uppgift 3
  - Vad var problemet?
  - Problemet va att loopen körde ett steg för långt. Du hadde i <= numbers.Length, men i en array börjar index från 0 å slutar vid Length - 1.
  - Lösning av problemet:
  - Bytte till i < numbers.Length så loopen slutar där den ska.


