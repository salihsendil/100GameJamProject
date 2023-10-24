INCLUDE globals.ink

VAR gameover = false

//EXTERNAL playEmote(emoteName)

//#audio:animal_crossing_low

-> main

=== main ===
Paşam Samsun’a hoş geldiniz, şeref getirdiniz. #speaker:Kazım Paşa #portrait:kazimpasa1

Teşekkür ederim paşam, o şeref bana aittir. Lakin, neden buraya geldiğimi tahmin ediyorsunuzdur. #speaker:M. Kemal Paşa #portrait:kemalpasa1

İstanbul’daki hükümet Samsun’da yaşanan hadiselerden oldukça rahatsız, bana da buraya gelmem ve sizleri teftiş etmem için emir verildi

Anlıyorum paşam. Fakat, açıkça söylemem gerekir ki vatanın şu anki içler acısı durumunu görmek bizi mahvediyor. #speaker:Kazım Paşa #portrait:kazimpasa1

Sizi gayet iyi anlıyorum paşam. Ben de bilhassa aynı endişe içerisindeyim. #speaker:M. Kemal Paşa #portrait:kemalpasa1
    + [İsyana destek]
        -> rebel
    + [Göreve devam]
        -> mission
        
=== rebel ===

Fakat, bu şekilde sadece küçük bir merkezden yapılan bir isyan durumu değiştirmeye yetmez. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Anadolu’da ve Rumeli’de büyük bir milli mücadele için bütün ülke çapında derhal bir seferberlik ilan edilmelidir.

Ancak böyle büyük çapta bir mücadele ile vatanı kurtarabiliriz. Bu konuda size güvenim tam.
-> END

=== mission ===


Ama ne olursa olsun unutmamamız gerekir ki hepimizin bir vazifesi var ve benim vazifem de devleti tehlikeli durumlara sokacak eylemleri engellemek. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Ama paşam! #speaker:Kazım Paşa #portrait:kazimpasa1

Kâzım Paşa, sizi anlıyorum ve sizinle aynı düşünceleri paylaşıyorum. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Lakin, İstanbul’daki hükümet bu topraklar üzerindeki tek hâkim unsur olarak kararını verdi ve ateşkes antlaşmasını imzaladı. 

Bizim görevimiz de bu devlete sadık paşalar olarak gelen emirlere uymamız ve bizden bekleneni yapmamızdır. Bu konuda size güvenim tam.

Ben ve ordum emrinizdedir paşam! #speaker:Kazım Paşa #portrait:kazimpasa1

(kapıdan çıkar) #speaker:M. Kemal Paşa #portrait:kemalpasa1

Ne olursa olsun bu mücadele devam etmek zorundadır. Mustafa Kemal Paşa yanımızda olmasa bile bunu yapmak zorundayız. Vatanın kurtuluşu bize bağlı. #speaker:Kazım Paşa #portrait:kazimpasa1

//gameover = true
-> END