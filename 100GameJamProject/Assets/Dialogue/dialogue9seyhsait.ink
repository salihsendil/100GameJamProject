INCLUDE globals.ink

//EXTERNAL playEmote(emoteName)

//#audio:animal_crossing_low

-> main

=== main ===
Paşam, Diyarbakır’da bir hadise meydana gelmiş. Bu telgrafı size iletmemi istediler. #speaker:Postacı #portrait:postman

Ver bakalım. #speaker:M. Kemal Paşa #portrait:kemalpasa1

.....

Paşam telgrafta ne yazıyor? #speaker:İsmet Paşa #portrait:ismetpasa1
    + [İsyanı bastır ]
        -> quell
    + [Görmezden Gel]
        -> dismiss
        
=== quell ===

İrticai bir kesim şeriat çağrıları ile cumhuriyetimize ve devrimlerimize karşı baş kaldırmış. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Derhal Kâzım Paşa’ya, Mürsel Paşa’ya ve Naci Paşa’ya haber verin. Bu irticai eylemin icabına hemen bakılsın.

Baş üstüne efendim! #speaker:İsmet Paşa #portrait:ismetpasa1
-> END

=== dismiss ===

Yapmış olduğumuz devrimler halkın bu kadar tepkisini çektiyse yapabileceğimiz pek bir şey yok.  #speaker:M. Kemal Paşa #portrait:kemalpasa1

Anlaşılan halk devrimlere pek hazır değil. 

İsmet Paşa derhal arabulucu bir ekip yollayın, boşuna kan dökülmesin.

Ne istiyorsa söylesinler, ortada bir yerde uzlaşmaya çalışalım.

Şu an devleti ilgilendiren daha önemli meseleler var, bununla uğraşacak durumda değiliz.

Emredersiniz! #speaker:İsmet Paşa #portrait:ismetpasa1

-> END