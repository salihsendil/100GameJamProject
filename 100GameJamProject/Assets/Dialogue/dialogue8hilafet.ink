INCLUDE globals.ink

//EXTERNAL playEmote(emoteName)

//#audio:animal_crossing_low

-> main

=== main ===
Kazım Paşa’dan Mustafa Kemal Paşa’ya mektup var. #speaker:Postacı #portrait:postman1

Ver bakalım mektubu, ne yazmış Kâzım Paşa bir görelim. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Kâzım Paşa bu mektubu kendisi de bizzat ulaştırabilirdi. #speaker:İsmet Paşa #portrait:ismetpasa1

Paşam, haddime değil ama Kâzım Paşa ne demiş mektubunda?

Bu mücadelenin hilafete karşı değil, bizzat hilafeti korumak için yapıldığını söylemiş. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Görünen o ki kendisi halifeliği kaldırma planımız hakkında bazı duyumlar almış ve bu konudaki endişelerini dile getirmiş.

Peki paşam, ne yapmayı planlıyorsunuz? #speaker:İsmet Paşa #portrait:ismetpasa1
    + [Hemen kaldır ]
        -> remove
    + [Şimdilik koru]
        -> conserve
        
=== remove ===

Kâzım Paşa’nın bu konudaki fikirleri önemsiz. Biz bu cumhuriyeti sadece toprakları düşmandan arındırmak için kurmadık. #speaker:M. Kemal Paşa #portrait:kemalpasa1

Bizim yaptığımız şey yalnız vatanın bölünmez bütünlüğünü korumak ve ulusal egemenliği tesis etmek değil, 

aynı zamanda kurduğumuz bu cumhuriyeti çağdaşlaştırmak ve onu muhasır medeniyetler seviyesine ulaştırmaktır. 

Aksi taktirde, eğer ulusal kalkınma sağlanmazsa ve ulus bilinci olan çağdaş bir halk yaratılamaz ise aynı hatalar tekrarlanır ve ülke bir kez daha çağın gerisinde kalarak zayıf düşer ve tekrardan düşmana teslim olur.

Bunun bir kez daha yaşanmaması için bu devrimler elzemdir. Din ve devlet işleri ayrı olmak zorundadır, aksi taktirde irticanın önüne geçilemez.

İki sene evvel saltanat kaldırıldı, şimdi ise halifeliğin kaldırılması icap etmektedir. 

Bu konuda kimin ne düşündüğü ile ilgilenemeyiz.

Kurtardığımız bu vatanı ve kurduğumuz bu cumhuriyeti geliştirebilmek için Türk aydınlanmasının tamamlanması lazım ve bunun için de devrimlerimizden asla taviz veremeyiz.

Yarından tezi yok, halifelik makamı kaldırılsın ve laiklik ilan edilsin.

Baş üstüne efendim! #speaker:İsmet Paşa #portrait:ismetpasa1
-> END

=== conserve ===
-

Kâzım Paşa şu dönemlerde çok fevri çıkışlar sergilemekte ama böylesine kritik bir zamanda partimizin birliğini bozmaya hiçbir gerekçe yoktur. #speaker:M. Kemal Paşa #portrait:kemalpasa

Eğer zorluklar içerisinde inşa ettiğimiz bu ulusal birlik dağılırsa, bu sadece düşmanlarımızın işine yarar ve büyük mücadeleler sonucunda edindiğimiz ulusal egemenliğimiz bir kez daha yok olma tehlikesi ile karşı karşıya kalır. 

Saltanatı ilga edip, cumhuriyeti ilan ettik, bu bize yeter. 

Varsın Halife Abdülmecid sembolik olarak “İslam Halifesi” unvanına sahip olmaya devam etsin. Boşu boşuna devletin içerisinde bir bölünme yaratmayalım. 

Emredersiniz! #speaker:İsmet Paşa #portrait:ismetpasa

-> END