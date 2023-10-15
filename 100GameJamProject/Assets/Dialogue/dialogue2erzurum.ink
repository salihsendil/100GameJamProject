INCLUDE globals.ink

//EXTERNAL playEmote(emoteName)

//#audio:animal_crossing_low

-> main

=== main ===
İstanbul’dan Mustafa Kemal Paşa’ya mektup var. #speaker:Postacı #portrait:postman1

Ver bakalım evlat. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Ne oldu paşam? #speaker:Kazım Paşa #portrait:kazimpasa1

Mektup İstanbul’daki hükümetten. Askerlikten azledildiğimi bildiriyor. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Peki ya bu durumda ne yapacaksınız? #speaker:Kazım Paşa #portrait:kazimpasa1
    + [Direnişe devam]
        -> rebel
    + [Göreve dönüş]
        -> mission
        
=== rebel ===

Anlaşılan o ki İstanbul’daki hükümet bu eylemlerimizden hoşlanmamış, fakat biz vatanı kurtarma yoluna bir kez baş koyduk. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Artık bu saatten sonra geri dönüş mümkün değildir. Fakat, şunu da bilmenizi isterim ki artık tamamen yalnızız.

İstanbul hükümeti bizim yanımızda değil. 

Vatanı kurtarma yolunda biz, kendimiz İstanbul’dan bağımsız hareket etmek zorundayız.

Başlattığımız bu Milli Mücadele hareketi artık tamamen bize bağlıdır. 

Bu mücadelede vatanı kurtarmak için, gerekirse İstanbul’daki işbirlikçi hükümeti karşınıza almak pahasına bu yolda kararlı mısınız?

Emrinizdeyim paşam! #speaker:Kazım Paşa #portrait:kazimpasa1
-> END

=== mission ===


Ne yazık ki yapacak pek bir şey kalmadı. İstanbul’daki hükümet vatanı kurtarmaktansa İtilaf Devletleri ile iş birliği yapmayı tercih etti. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Bana düşen vazife bu emri dinlemek ve İstanbul’a dönmektir. 

Ama paşam, Milli Mücadele’yi çoktan başlatmadık mı? #speaker:Kazım Paşa #portrait:kazimpasa1

Şu saatten sonra nasıl vatanı için direnme yolunu seçmiş ve bu uğurda her şeyini feda etmeye koyulmuş bir ekibe kurtuluş mücadelesinin sona erdiğini söyleyebiliriz? 

Buna gerek yok Kâzım Paşa. Ben İstanbul’a döneceğim ve bütün bu yaşananları reddedeceğim. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Erzurum’daki kongrenin sadece hükümete verdiğimiz bir tepki olduğunu ama kesinlikle Anadolu’da herhangi bir hareketliliğin yaşanmayacağını bildireceğim.  

Fakat, eminim siz bu mücadeleyi benim bıraktığım yerden devam ettireceksinizdir. Şartlar maalesef ki beni bu mücadeleden ayırıyor ama bu mücadeleyi devam ettirme konusunda size güvenebileceğimden eminim.

Emrinizdeyim paşam! #speaker:Kazım Paşa #portrait:kazimpasa1

-> END