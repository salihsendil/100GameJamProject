INCLUDE globals.ink

//EXTERNAL playEmote(emoteName)

//#audio:animal_crossing_low

VAR madde1 = ""
VAR madde2 = ""
VAR madde3 = ""

-> main

=== main ===
Bugün Lozan'da barış antlaşmasının şartlarını konuşmak için buradayız. #speaker:Moderatör #portrait:conferencer1

Türkiye ile yapılacak antlaşma bazı nedenlerden dolayı gecikti.

Ve artık bazı maddelere karar vermenin vakti geldi.

Kapitülasyonlar...
    + [kabul edilebilir.]
        -> chosen1("kabul edilebilir.")
    + [kabul edilemez]
        -> chosen1("kabul edilemez.")
        
=== chosen1(a) ===
~ madde1 = a 
Kapitülasyonlar {a} #speaker:İsmet Paşa #portrait:ismetpasa1
        
Not alındı. #speaker:Moderatör #portrait:conferencer1

Türkiye savaş tazminatı... 
+ [ödememeli!]
        -> chosen2("ödememeli!")
    + [ödemeli.]
        -> chosen2("ödemeli.")
        
=== chosen2(b) ===
~ madde2 = b
Türkiye savaş tazminatı {b} #speaker:İsmet Paşa #portrait:ismetpasa1

Bu da not alındı. #speaker:Moderatör #portrait:conferencer1

Peki ya Türkiye'deki azınlıklar? Azınlıkların hakları... 
+ [Eşittir]
        -> chosen3(" eşit birer vatandaşımızdır.")
    + [Değildir]
        -> chosen3("ın bazı ayrıcalıkları olabilir.")
        
=== chosen3(c) ===
~ madde3 = c
Azınlıklar{c} #speaker:İsmet Paşa #portrait:ismetpasa1

Bu da not alındı. #speaker:Moderatör #portrait:conferencer1

Tekrar ediyorum...

Kapitülasyonlar {madde1}

Türkiye savaş tazminatı {madde2}

Azınlıklar{madde3}

Doğru mudur?

Evet ilkelerimiz bu şekildedir. #speaker:İsmet Paşa #portrait:ismetpasa1

-> END



        
