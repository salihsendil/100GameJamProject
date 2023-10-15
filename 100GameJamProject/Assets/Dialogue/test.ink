INCLUDE globals.ink

//EXTERNAL playEmote(emoteName)

//#audio:animal_crossing_low
{ pokemon_name == "": -> main | -> already_chose }

=== main ===
Hello stranger!<

You have to choose a pokemon.<

Don't ask me why<

Which pokemon do you choose?
    + [Charmander]
        -> chosen("Charmander")
    + [Bulbasaur]
        -> chosen("Bulbasaur")
    + [Squirtle]
        -> chosen("Squirtle")
        
=== chosen(pokemon) ===
~ pokemon_name = pokemon
You chose {pokemon}!
-> END

=== already_chose ===
You already chose {pokemon_name}!
-> END