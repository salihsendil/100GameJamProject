INCLUDE globals.ink

//EXTERNAL playEmote(emoteName)

//#audio:animal_crossing_low

{ subjects == "": -> main | -> signed }

-> main

=== main ===
Paşam, size bir mektup gelmiş. #speaker:İsmet Paşa #portrait:ismetpasa1

Mektubu getiren kişi acil olduğunu söylüyor ve sizin dışında kimseye de bu mektubu veremeyeceğini söylüyor. 

Bu o postacı çocuk. Tanıyorum kendisini. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Söyleyin içeri gelsin. 

Paşam, elimde size acil ulaştırmam gereken bir belge var.  #speaker:Postacı #portrait:postman1

Ne hakkında? #speaker:M. Kemal Paşa #portrait:kemalpasa1

Lütfen, siz okuyun. #speaker:Postacı #portrait:postman1

Paşam, yüzünüzden düşen bin parça? #speaker:İsmet Paşa #portrait:ismetpasa1
    + [Savaşa devam]
        -> rebel
    + [Kaçmak]
        -> escape
        
=== rebel ===

Şaşırdığım bir şey değil. İstanbul’daki hükümet, hakkımızda ölüm fermanı yayınlamış. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Bir de utanmadan pişman olanların affedileceğini yazmışlar. 

İsmet, ekibimize haber ver. Bundan sonra İstanbul hükümeti meşruluğunu yitirmiştir.  

Bundan böyle milletin tek bir temsilcisi vardır, o da Ankara’da kuracağımız yeni meclistir. 

Kurtuluş Savaşı artık fiilen başlamıştır. Artık ne İtilaf Devletleri ile müzakere edilebilir, ne de Yunan ordularının Ege’deki işgaline tahammül edilebilir! 

İsmet Paşa, senden tek bir ricam olacak. 

Ordunu savaş için hazırla! İşgalci Yunan ordularına karşı en kısa zamanda büyük bir taarruza başlayacağız.

Emredersiniz paşam! #speaker:İsmet Paşa #portrait:ismetpasa
-> END

=== escape ===

İstanbul’daki saray hükümeti vatanı kurtarmak yerine İtilaf Devletleri’nin yanında saf tutmayı seçmiş ve bizim hakkımızda bir ölüm fermanı yayınlamış. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Eğer Damat Ferit Paşa işgalcilerin o kadar yapmış olduğu zulme rağmen yine de onların tarafını tutuyorsa, yapabileceğimiz pek bir şey kalmamış demektir. 

Paşam, lütfen bir süreliğine istirahat edin. #speaker:İsmet Paşa #portrait:ismetpasa1

Böyle bir şeyi nasıl söylersin İsmet! Üstelik bu kadar yol kat etmişken. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Paşam, durumun ben de farkındayım ama kendiniz için olmasa bile unutmayın ki vatanın bağımsızlığı ve bölünmez bütünlüğünü sağlamak için Kuvayı Milliye’ye katılmış birliklerimiz için sizin hayatınız çok önemli. #speaker:İsmet Paşa #portrait:ismetpasa1

Zar zor topladığımız bu başıbozuk ordunun moralini korumak için sizin en azından bir süreliğine gizlenmeniz daha doğru olacaktır. 

Peki, madem öyle icap ediyor, o zaman bir süreliğine bu mücadeleye ara veririz. #speaker:M. Kemal Paşa #portrait:kemalpasa1
-> END

=== subjects(pokemon) ===
~ pokemon_name = pokemon
Bu maddeyi onayladınız: {subjects}!
-> END

=== signed ===
You already chose {subjects}!
-> END