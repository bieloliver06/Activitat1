# Activitat 1

Desenvolupar un programa que:
Té dues variables de tipus real, anomenades base i altura. S’assigna un valor a cada una
d’aquestes variables.
Ha de calcular l’àrea d’un triangle, i ha de guardar el resultat dins una variable anomenada
area.

ATENCIÓ

- Heu de cercar el tipus equivalent a real pel llenguatge C#.
- El nom de les variables no pot tenir accents ni caràcters especial. És bona
  pràctica posar el nom de les variables en anglès.

## El programa

Per correr el programa el descarregam utilitzant git o ens descarregam el .zip i el descrompimint

### Git :

```bash
git clone https://github.com/notbtc2/Activitat1.git
```

A dins la carpeta a0 utilitza dotnet per correr el programa

```bash
dotnet run
```

## Maneig d'excepcions

Per comprovar que el que hem introduit no sugui null o no sigui un character o una string, i que també que et faci introduir un nombre.

```C#
string? base_input;
float f_base;

while (true)
{
    Console.WriteLine("Introdueix la base (cm) : ");
    base_input = Console.ReadLine();
    if (base_input != null)
    {
        try
        {
            f_base = float.Parse(base_input);
            break;
        }
        catch (System.FormatException)
        {
            Console.WriteLine("El que has introduit no es valid");
        }
    }
}
```

Resultat :

```bash
Introdueix la base (cm) :

El que has introduit no es valid
Introdueix la base (cm) :
asdsa
El que has introduit no es valid
Introdueix la base (cm) :
1
```

### Antic

Per comprovar que el que hem introduit no sigui no sigui null utilitzam try i catch a més de comprovar que no sigui null ja que si nomes utilitzam s'if per comprovar que no sigui null ens segueix donant l'error.

```C#
Console.WriteLine("Introdueix la base (cm) : ");
string? base_input = Console.ReadLine();
if (base_input == null)
{
    return;
}
try
{
    float.Parse(base_input);
}
catch (System.FormatException)
{
    Console.WriteLine("No has introduit un nombre valid");
    return;
}
```

Resultat

```bash
Introdueix la base (cm) :

No has introduit un nombre valid

```

Encanvi si utilitzam nomes l'if ens dona un error.

```C#
Console.WriteLine("Introdueix la base (cm) : ");
string? base_input = Console.ReadLine();
if (base_input == null)
{
    return;
}
```

Resultat

```bash
Introdueix la base (cm) :

Unhandled exception. System.FormatException: Input string was not in a correct format.
   at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
   at System.Single.Parse(String s)
   at Act1.Program.Main() in C:\Users\anxoa\Documents\Escola\Programació i tractament de dades\activitat-1\a0\Program.cs:line 16

```

## License

[MIT](https://choosealicense.com/licenses/mit/)
